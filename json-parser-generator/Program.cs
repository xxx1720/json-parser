using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace json_parser_generator
{
    abstract class json_value
    {
        public abstract StringBuilder print(StringBuilder os, bool format = false, string indent = "");
    }

    class json_object : json_value
    {
        public override StringBuilder print(StringBuilder os, bool format = false, string indent = "")
        {
            if (!format)
                os.Append('{');
            else
                os.Append("{\n");
            for (int i = 0; i < keyvalue.Count; i++)
            {
                var it = keyvalue[i];
                if (!format)
                {
                    os.Append('\"' + it.Key + "\":");
                    it.Value.print(os);
                }
                else
                {
                    os.Append(indent + "  " + it.Key + ": ");
                    it.Value.print(os, true, indent + "  ");
                }
                if (i != keyvalue.Count - 1)
                {
                    if (!format)
                        os.Append(',');
                    else
                        os.Append(",\n");
                }
            }
            if (!format)
                os.Append('}');
            else
                os.Append('\n' + indent + "}");
            return os;
        }

        public List<KeyValuePair<string, json_value>> keyvalue = new List<KeyValuePair<string, json_value>>();
    }

    class json_array : json_value
    {
        public override StringBuilder print(StringBuilder os, bool format = false, string indent = "")
        {
            if (array.Count > 0)
            {
                if (!format)
                    os.Append('[');
                else
                    os.Append("[\n");
                for (int i = 0; i < array.Count; i++)
                {
                    var it = array[i];
                    if (!format)
                        it.print(os);
                    else
                    {
                        os.Append(indent + "  ");
                        it.print(os, true, indent + "  ");
                    }
                    if (i != array.Count - 1)
                    {
                        if (!format)
                            os.Append(',');
                        else
                            os.Append(",\n");
                    }
                }
                if (!format)
                    os.Append(']');
                else
                    os.Append('\n' + indent + "]");
            }
            else
            {
                os.Append("[]");
            }
            return os;
        }

        public List<json_value> array = new List<json_value>();
    }

    class json_numeric : json_value
    {
        public override StringBuilder print(StringBuilder os, bool format = false, string indent = "")
        {
            os.Append(numstr);
            return os;
        }

        public string numstr;
        public bool is_integer = false;
    }

    enum json_token
    {
        none = 0,
        json_nt_json,
        json_nt_array,
        json_nt_object,
        json_nt_members,
        json_nt_pair,
        json_nt_elements,
        json_nt_value,
        object_starts,
        object_ends,
        v_comma,
        v_pair,
        array_starts,
        array_ends,
        v_true,
        v_false,
        v_null,
        v_string,
        v_number,
        eof,
        error,
    };

    class json_state : json_value
    {
        public override StringBuilder print(StringBuilder os, bool format = false, string indent = "")
        {
            switch (type)
            {
                case json_token.v_false:
                    os.Append("false");
                    break;

                case json_token.v_true:
                    os.Append("true");
                    break;

                case json_token.v_null:
                    os.Append("null");
                    break;
            }
            return os;
        }

        public json_token type;
    }

    class json_string : json_value
    {
        public override StringBuilder print(StringBuilder os, bool format = false, string indent = "")
        {
            os.Append(str);
            return os;
        }

        public string str;
    }

    class Program
    {
        static Scanner lexer;
        static ShiftReduceParser parser;

        static Scanner CreateJSonLexer()
        {
            var sg = new ScannerGenerator();

            sg.PushRule("", @"[\t\r\n ]");
            sg.PushRule("comma", "\\,");
            sg.PushRule("v_pair", "\\:");
            sg.PushRule("object_starts", "\\{");
            sg.PushRule("object_ends", "\\}");
            sg.PushRule("array_starts", "\\[");
            sg.PushRule("array_ends", "\\]");
            sg.PushRule("v_true", "true");
            sg.PushRule("v_false", "false");
            sg.PushRule("v_null", "null");
            sg.PushRule("v_string", @"""([^""\\]|\\.)*""");
            sg.PushRule("v_number", @"-?[0-9]+(\.[0-9]+)?([Ee][\+\-]?[0-9]+)?");

            sg.Generate();
#if false
            Console.WriteLine(sg.PrintDiagram());
#endif

            return sg.CreateScannerInstance();
        }

        static ShiftReduceParser CreateJSonParser()
        {
            var gen = new ParserGenerator();

            var JSON = gen.CreateNewProduction("JSON", false);
            var ARRAY = gen.CreateNewProduction("ARRAY", false);
            var OBJECT = gen.CreateNewProduction("OBJECT", false);
            var MEMBERS = gen.CreateNewProduction("MEMBERS", false);
            var PAIR = gen.CreateNewProduction("PAIR", false);
            var ELEMENTS = gen.CreateNewProduction("ELEMENTS", false);
            var VALUE = gen.CreateNewProduction("VALUE", false);

            var object_starts = gen.CreateNewProduction("object_starts");
            var object_ends = gen.CreateNewProduction("object_ends");
            var comma = gen.CreateNewProduction("comma");
            var v_pair = gen.CreateNewProduction("v_pair");
            var array_starts = gen.CreateNewProduction("array_starts");
            var array_ends = gen.CreateNewProduction("array_ends");
            var v_true = gen.CreateNewProduction("v_true");
            var v_false = gen.CreateNewProduction("v_false");
            var v_null = gen.CreateNewProduction("v_null");
            var v_string = gen.CreateNewProduction("v_string");
            var v_number = gen.CreateNewProduction("v_number");

            JSON |= OBJECT + ParserAction.Create(x => x.UserContents = x.Childs[0].UserContents);
            JSON |= ARRAY + ParserAction.Create(x => x.UserContents = x.Childs[0].UserContents);
            OBJECT |= object_starts + object_ends + ParserAction.Create(x => x.UserContents = new json_object());
            OBJECT |= object_starts + MEMBERS + object_ends + ParserAction.Create(x => x.UserContents = x.Childs[1].UserContents);
            MEMBERS |= PAIR + ParserAction.Create(x => {
                var jo = new json_object();
                jo.keyvalue.Add(new KeyValuePair<string, json_value>(x.Childs[0].Childs[0].Contents, x.Childs[0].Childs[2].UserContents as json_value));
                x.UserContents = jo;
            });
            MEMBERS |= PAIR + comma + MEMBERS + ParserAction.Create(x => {
                var jo = x.Childs[2].UserContents as json_object;
                jo.keyvalue.Insert(0, new KeyValuePair<string, json_value>(x.Childs[0].Childs[0].Contents, x.Childs[0].Childs[2].UserContents as json_value));
                x.UserContents = jo;
            });
            PAIR |= v_string + v_pair + VALUE + ParserAction.Create(x => { });
            ARRAY |= array_starts + array_ends + ParserAction.Create(x => x.UserContents = new json_array());
            ARRAY |= array_starts + ELEMENTS + array_ends + ParserAction.Create(x => x.UserContents = x.Childs[1].UserContents);
            ELEMENTS |= VALUE + ParserAction.Create(x => {
                var ja = new json_array();
                ja.array.Add(x.Childs[0].UserContents as json_value);
                x.UserContents = ja;
            });
            ELEMENTS |= VALUE + comma + ELEMENTS + ParserAction.Create(x => {
                var ja = x.Childs[2].UserContents as json_array;
                ja.array.Insert(0, x.Childs[0].UserContents as json_value);
                x.UserContents = ja;
            });
            VALUE |= v_string + ParserAction.Create(x => x.UserContents = new json_string { str = x.Contents });
            VALUE |= v_number + ParserAction.Create(x => x.UserContents = new json_numeric { numstr = x.Contents });
            VALUE |= OBJECT + ParserAction.Create(x => x.UserContents = x.Childs[0].UserContents);
            VALUE |= ARRAY + ParserAction.Create(x => x.UserContents = x.Childs[0].UserContents);
            VALUE |= v_true + ParserAction.Create(x => x.UserContents = new json_state { type = json_token.v_true });
            VALUE |= v_false + ParserAction.Create(x => x.UserContents = new json_state { type = json_token.v_false });
            VALUE |= v_null + ParserAction.Create(x => x.UserContents = new json_state { type = json_token.v_null });

            gen.PushStarts(JSON);
            gen.PrintProductionRules();
            gen.Generate();
            gen.PrintStates();
            gen.PrintTable();

#if false
            Console.WriteLine(gen.GlobalPrinter.ToString());
            Console.WriteLine(gen.CreateExtendedShiftReduceParserInstance().ToCSCode("json_parser"));
#endif

            return gen.CreateExtendedShiftReduceParserInstance();
        }

        static void TestLexer()
        {
            var txt = File.ReadAllText("222.json");

            lexer.AllocateTarget(txt);

            while (lexer.Valid())
            {
                var pp = lexer.Next();
                Console.WriteLine(pp);
            }
        }

        static json_value parse_json_file(string txt)
        {

            lexer.AllocateTarget(txt);
            Action<string, string, int, int> insert = (string x, string y, int a, int b) =>
            {
                parser.Insert(x, y);
                if (parser.Error()) throw new Exception($"[COMPILER] Parser error! L:{a}, C:{b}");
                while (parser.Reduce())
                {
                    var l = parser.LatestReduce();
                    l.Action(l);
#if false
                    Console.Write(l.Production.PadLeft(8) + " => ");
                    Console.WriteLine(string.Join(" ", l.Childs.Select(z => z.Production)));
                    Console.Write(l.Production.PadLeft(8) + " => ");
                    Console.WriteLine(string.Join(" ", l.Childs.Select(z => z.Contents)));
#endif
                    parser.Insert(x, y);
                    if (parser.Error()) throw new Exception($"[COMPILER] Parser error! L:{a}, C:{b}");
                }
            };

            while (lexer.Valid())
            {
                var tk = lexer.Next();
                insert(tk.Item1, tk.Item2, tk.Item3, tk.Item4);
            }

            if (parser.Error()) throw new Exception();
            insert("$", "$", -1, -1);

            var tree = parser.Tree;
#if false
            PrintTree(tree.root, "", true);
#endif
            var root = tree.root.UserContents as json_value;

            var build = new StringBuilder();
            root.print(build, true);
#if false
            File.WriteAllText("export.json", build.ToString());
#endif
            return root;
        }

        public static void PrintTree(ParsingTree.ParsingTreeNode node, string indent, bool last)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("+-");
                indent += "  ";
            }
            else
            {
                Console.Write("|-");
                indent += "| ";
            }

            if (node.Childs.Count == 0)
            {
                Console.WriteLine(node.Production + " " + node.Contents);
            }
            else
            {
                Console.WriteLine(node.Production);
            }
            for (int i = 0; i < node.Childs.Count; i++)
                PrintTree(node.Childs[i], indent, i == node.Childs.Count - 1);
        }

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("./json-parser-generator <filename> <output> [-f|--format]");
                return;
            }

            lexer = CreateJSonLexer();
#if false
            Console.WriteLine(lexer.ToCSCode("json_lexer"));
#endif
            parser = CreateJSonParser();

            var txt = File.ReadAllText(args[0]);
            var val = parse_json_file(txt);

            var build = new StringBuilder();
            if (args.Contains("--format") || args.Contains("-f"))
                val.print(build, true);
            else
                val.print(build);

            File.WriteAllText(args[1], build.ToString());

            return;
        }
    }
}
