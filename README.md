# json-parser

## Lexer

```
   0: ( ,1) (
,1) ( ,1) (,,2) (:,3) ({,4) (},5) ([,6) (],7) (t,8) (f,9) (n,10) (",11) (-,12) (0,13) (1,13) (2,13) (3,13) (4,13) (5,13) (6,13) (7,13) (8,13) (9,13)
  13: (0,13) (1,13) (2,13) (3,13) (4,13) (5,13) (6,13) (7,13) (8,13) (9,13) (.,19) (E,20) (e,20) (ACCEPT,v_number)
  20: (+,25) (-,25) (0,26) (1,26) (2,26) (3,26) (4,26) (5,26) (6,26) (7,26) (8,26) (9,26)
  26: (0,26) (1,26) (2,26) (3,26) (4,26) (5,26) (6,26) (7,26) (8,26) (9,26) (ACCEPT,v_number)
  25: (0,26) (1,26) (2,26) (3,26) (4,26) (5,26) (6,26) (7,26) (8,26) (9,26)
  19: (0,24) (1,24) (2,24) (3,24) (4,24) (5,24) (6,24) (7,24) (8,24) (9,24)
  24: (0,24) (1,24) (2,24) (3,24) (4,24) (5,24) (6,24) (7,24) (8,24) (9,24) (E,20) (e,20) (ACCEPT,v_number)
  12: (0,13) (1,13) (2,13) (3,13) (4,13) (5,13) (6,13) (7,13) (8,13) (9,13)
  11: (null,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) ,11) (  ,11) (
,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (1) (,11) (,11) (,11) (,11) ( ,11) (!,11) (#,11) ($,11) (%,11) (&,11) (',11) ((,11) (),11) (*,11) (+,11) (,,11) (-,11) (.,11) (/,11) (0,11) (1,11) (2,11) (3,11) (4,11) (5,11) (6,11) (7,11) (8,11) (9,11) (:,11) (;,11) (<,11) (=,11) (>,11) (?,11) (@,11) (A,11) (B,11) (C,11) (D,11) (E,11) (F,11) (G,11) (H,11) (I,11) (J,11) (K,11) (L,11) (M,11) (N,11) (O,11) (P,11) (Q,11) (R,11) (S,11) (T,11) (U,11) (V,11) (W,11) (X,11) (Y,11) (Z,11) ([,11) (],11) (^,11) (_,11) (`,11) (a,11) (b,11) (c,11) (d,11) (e,11) (f,11) (g,11) (h,11) (i,11) (j,11) (k,11) (l,11) (m,11) (n,11) (o,11) (p,11) (q,11) (r,11) (s,11) (t,11) (u,11) (v,11) (w,11) (x,11) (y,11) (z,11) ({,11) (|,11) (},11) (~,11) (,11) (,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (¡,11) (￠,11) (￡,11) (¤,11) (￥,11) (|,11) (§,11) (¨,11) (ⓒ,11) (ª,11) (≪,11) (￢,11) (­,11) (®,11) (?,11) (°,11) (±,11) (²,11) (³,11) (´,11) (μ,11) (¶,11) (·,11) (¸,11) (¹,11) (º,11) (≫,11) (¼,11) (½,11) (¾,11) (¿,11) (A,11) (A,11) (A,11) (A,11) (A,11) (A,11) (Æ,11) (C,11) (E,11) (E,11) (E,11) (E,11) (I,11) (I,11) (I,11) (I,11) (Ð,11) (N,11) (O,11) (O,11) (O,11) (O,11) (O,11) (×,11) (Ø,11) (U,11) (U,11) (U,11) (U,11) (Y,11) (Þ,11) (ß,11) (a,11) (a,11) (a,11) (a,11) (a,11) (a,11) (æ,11) (c,11) (e,11) (e,11) (e,11) (e,11) (i,11) (i,11) (i,11) (i,11) (ð,11) (n,11) (o,11) (o,11) (o,11) (o,11) (o,11) (÷,11) (ø,11) (u,11) (u,11) (u,11) (u,11) (y,11) (þ,11) (y,11) (\,17) (",18)
  18: (ACCEPT,v_string)
  17: (null,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) ,11) (  ,11) (
,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (,11) (1) (,11) (,11) (,11) (,11) ( ,11) (!,11) (",11) (#,11) ($,11) (%,11) (&,11) (',11) ((,11) (),11) (*,11) (+,11) (,,11) (-,11) (.,11) (/,11) (0,11) (1,11) (2,11) (3,11) (4,11) (5,11) (6,11) (7,11) (8,11) (9,11) (:,11) (;,11) (<,11) (=,11) (>,11) (?,11) (@,11) (A,11) (B,11) (C,11) (D,11) (E,11) (F,11) (G,11) (H,11) (I,11) (J,11) (K,11) (L,11) (M,11) (N,11) (O,11) (P,11) (Q,11) (R,11) (S,11) (T,11) (U,11) (V,11) (W,11) (X,11) (Y,11) (Z,11) ([,11) (\,11) (],11) (^,11) (_,11) (`,11) (a,11) (b,11) (c,11) (d,11) (e,11) (f,11) (g,11) (h,11) (i,11) (j,11) (k,11) (l,11) (m,11) (n,11) (o,11) (p,11) (q,11) (r,11) (s,11) (t,11) (u,11) (v,11) (w,11) (x,11) (y,11) (z,11) ({,11) (|,11) (},11) (~,11) (,11) (,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (?,11) (¡,11) (￠,11) (￡,11) (¤,11) (￥,11) (|,11) ( §,11) (¨,11) (ⓒ,11) (ª,11) (≪,11) (￢,11) (­,11) (®,11) (?,11) (°,11) (±,11) (²,11) (³,11) (´,11) (μ,11) ( ¶,11) (·,11) (¸,11) (¹,11) (º,11) (≫,11) (¼,11) (½,11) (¾,11) (¿,11) (A,11) (A,11) (A,11) (A,11) (A,11) (A,11) (Æ,11) (C,11) (E,11) (E,11) (E,11) (E,11) (I,11) (I,11) (I,11) (I,11) (Ð,11) (N,11) (O,11) (O,11) (O,11) (O,11) (O,11) (×,11) (Ø,11) (U,11) (U,11) (U,11) (U,11) (Y,11) (Þ,11) (ß,11) (a,11) (a,11) (a,11) (a,11) (a,11) (a,11) (æ,11) (c,11) (e,11) (e,11) (e,11) (e,11) (i,11) (i,11) (i,11) (i,11) (ð,11) (n,11) (o,11) (o,11) (o,11) (o,11) (o,11) (÷,11) (ø,11) (u,11) (u,11) (u,11) (u,11) (y,11) (þ,11) (y,11)
  10: (u,16)
  16: (l,23)
  23: (l,29)
  29: (ACCEPT,v_null)
   9: (a,15)
  15: (l,22)
  22: (s,28)
  28: (e,30)
  30: (ACCEPT,v_false)
   8: (r,14)
  14: (u,21)
  21: (e,27)
  27: (ACCEPT,v_true)
   7: (ACCEPT,array_ends)
   6: (ACCEPT,array_starts)
   5: (ACCEPT,object_ends)
   4: (ACCEPT,object_starts)
   3: (ACCEPT,v_pair)
   2: (ACCEPT,comma)
   1: (ACCEPT,)
```

## Parser

```
==================================================

                 PRODUCTION RULES

==================================================
   1:         S' -> JSON
   2:       JSON -> OBJECT
   3:       JSON -> ARRAY
   4:      ARRAY -> array_starts array_ends
   5:      ARRAY -> array_starts ELEMENTS array_ends
   6:     OBJECT -> object_starts object_ends
   7:     OBJECT -> object_starts MEMBERS object_ends
   8:    MEMBERS -> PAIR
   9:    MEMBERS -> PAIR comma MEMBERS
  10:       PAIR -> v_string v_pair VALUE
  11:   ELEMENTS -> VALUE
  12:   ELEMENTS -> VALUE comma ELEMENTS
  13:      VALUE -> v_string
  14:      VALUE -> v_number
  15:      VALUE -> OBJECT
  16:      VALUE -> ARRAY
  17:      VALUE -> v_true
  18:      VALUE -> v_false
  19:      VALUE -> v_null

==================================================

                FISRT, FOLLOW SETS

==================================================
FIRST(S')={object_starts,array_starts}
FIRST(JSON)={object_starts,array_starts}
FIRST(ARRAY)={array_starts}
FIRST(OBJECT)={object_starts}
FIRST(MEMBERS)={v_string}
FIRST(PAIR)={v_string}
FIRST(ELEMENTS)={v_string,v_number,v_true,v_false,v_null,object_starts,array_starts}
FIRST(VALUE)={v_string,v_number,v_true,v_false,v_null,object_starts,array_starts}
FIRST(object_starts)={object_starts}
FIRST(object_ends)={object_ends}
FIRST(comma)={comma}
FIRST(v_pair)={v_pair}
FIRST(array_starts)={array_starts}
FIRST(array_ends)={array_ends}
FIRST(v_true)={v_true}
FIRST(v_false)={v_false}
FIRST(v_null)={v_null}
FIRST(v_string)={v_string}
FIRST(v_number)={v_number}
FOLLOW(S')={$}
FOLLOW(JSON)={$}
FOLLOW(ARRAY)={$,comma,object_ends,array_ends}
FOLLOW(OBJECT)={$,comma,object_ends,array_ends}
FOLLOW(MEMBERS)={object_ends}
FOLLOW(PAIR)={comma,object_ends}
FOLLOW(ELEMENTS)={array_ends}
FOLLOW(VALUE)={comma,object_ends,array_ends}
FOLLOW(object_starts)={object_ends}
FOLLOW(array_starts)={array_ends}
FOLLOW(v_string)={v_pair}

==================================================

                   LALR STATES

==================================================
-----I0-----
        S' -> ·JSON                         $
      JSON -> ·OBJECT                       $
      JSON -> ·ARRAY                        $
    OBJECT -> ·object_starts object_ends    $
    OBJECT -> ·object_starts MEMBERS object_ends $
     ARRAY -> ·array_starts array_ends      $
     ARRAY -> ·array_starts ELEMENTS array_ends $
-----I1-----
        S' -> JSON ·                        $
-----I2-----
      JSON -> OBJECT ·                      $
-----I3-----
      JSON -> ARRAY ·                       $
-----I4-----
    OBJECT -> object_starts ·object_ends    $/array_ends/comma/object_ends
    OBJECT -> object_starts ·MEMBERS object_ends $/array_ends/comma/object_ends
   MEMBERS -> ·PAIR                         object_ends
   MEMBERS -> ·PAIR comma MEMBERS           object_ends
      PAIR -> ·v_string v_pair VALUE        object_ends/comma
-----I5-----
     ARRAY -> array_starts ·array_ends      $/array_ends/comma/object_ends
     ARRAY -> array_starts ·ELEMENTS array_ends array_ends/comma/$/object_ends
  ELEMENTS -> ·VALUE                        array_ends/comma
  ELEMENTS -> ·VALUE comma ELEMENTS         array_ends/comma
     VALUE -> ·v_string                     array_ends/comma
     VALUE -> ·v_number                     array_ends/comma
     VALUE -> ·OBJECT                       array_ends/comma
     VALUE -> ·ARRAY                        array_ends/comma
     VALUE -> ·v_true                       array_ends/comma
     VALUE -> ·v_false                      array_ends/comma
     VALUE -> ·v_null                       array_ends/comma
    OBJECT -> ·object_starts object_ends    array_ends/comma
    OBJECT -> ·object_starts MEMBERS object_ends array_ends/comma
     ARRAY -> ·array_starts array_ends      array_ends/comma
     ARRAY -> ·array_starts ELEMENTS array_ends array_ends/comma
-----I6-----
    OBJECT -> object_starts object_ends ·   $/array_ends/comma/object_ends
-----I7-----
    OBJECT -> object_starts MEMBERS ·object_ends $/array_ends/comma/object_ends
-----I8-----
   MEMBERS -> PAIR ·                        object_ends
   MEMBERS -> PAIR ·comma MEMBERS           object_ends
-----I9-----
      PAIR -> v_string ·v_pair VALUE        object_ends/comma
-----I10-----
     ARRAY -> array_starts array_ends ·     $/array_ends/comma/object_ends
-----I11-----
     ARRAY -> array_starts ELEMENTS ·array_ends $/array_ends/comma/object_ends
-----I12-----
  ELEMENTS -> VALUE ·                       array_ends
  ELEMENTS -> VALUE ·comma ELEMENTS         array_ends
-----I13-----
     VALUE -> v_string ·                    array_ends/comma/object_ends
-----I14-----
     VALUE -> v_number ·                    array_ends/comma/object_ends
-----I15-----
     VALUE -> OBJECT ·                      array_ends/comma/object_ends
-----I16-----
     VALUE -> ARRAY ·                       array_ends/comma/object_ends
-----I17-----
     VALUE -> v_true ·                      array_ends/comma/object_ends
-----I18-----
     VALUE -> v_false ·                     array_ends/comma/object_ends
-----I19-----
     VALUE -> v_null ·                      array_ends/comma/object_ends
-----I20-----
    OBJECT -> object_starts MEMBERS object_ends ·$/array_ends/comma/object_ends
-----I21-----
   MEMBERS -> PAIR comma ·MEMBERS           object_ends
   MEMBERS -> ·PAIR                         object_ends
   MEMBERS -> ·PAIR comma MEMBERS           object_ends
      PAIR -> ·v_string v_pair VALUE        comma/object_ends
-----I22-----
      PAIR -> v_string v_pair ·VALUE        object_ends/comma
     VALUE -> ·v_string                     object_ends/comma
     VALUE -> ·v_number                     object_ends/comma
     VALUE -> ·OBJECT                       object_ends/comma
     VALUE -> ·ARRAY                        object_ends/comma
     VALUE -> ·v_true                       object_ends/comma
     VALUE -> ·v_false                      object_ends/comma
     VALUE -> ·v_null                       object_ends/comma
    OBJECT -> ·object_starts object_ends    object_ends/comma
    OBJECT -> ·object_starts MEMBERS object_ends object_ends/comma
     ARRAY -> ·array_starts array_ends      object_ends/comma
     ARRAY -> ·array_starts ELEMENTS array_ends object_ends/comma
-----I23-----
     ARRAY -> array_starts ELEMENTS array_ends ·$/array_ends/comma/object_ends
-----I24-----
  ELEMENTS -> VALUE comma ·ELEMENTS         array_ends
  ELEMENTS -> ·VALUE                        array_ends
  ELEMENTS -> ·VALUE comma ELEMENTS         array_ends
     VALUE -> ·v_string                     comma/array_ends
     VALUE -> ·v_number                     comma/array_ends
     VALUE -> ·OBJECT                       comma/array_ends
     VALUE -> ·ARRAY                        comma/array_ends
     VALUE -> ·v_true                       comma/array_ends
     VALUE -> ·v_false                      comma/array_ends
     VALUE -> ·v_null                       comma/array_ends
    OBJECT -> ·object_starts object_ends    comma/array_ends
    OBJECT -> ·object_starts MEMBERS object_ends comma/array_ends
     ARRAY -> ·array_starts array_ends      comma/array_ends
     ARRAY -> ·array_starts ELEMENTS array_ends comma/array_ends
-----I25-----
   MEMBERS -> PAIR comma MEMBERS ·          object_ends
-----I26-----
      PAIR -> v_string v_pair VALUE ·       object_ends/comma
-----I27-----
  ELEMENTS -> VALUE comma ELEMENTS ·        array_ends

==================================================

                   FINAL STATES

==================================================
I0 => SHIFT{(JSON,I1),(OBJECT,I2),(ARRAY,I3),(object_starts,I4),(array_starts,I5)}
I1 => REDUCE{($,accept,0)}
I2 => REDUCE{($,JSON,0)}
I3 => REDUCE{($,JSON,1)}
I4 => SHIFT{(object_ends,I6),(MEMBERS,I7),(PAIR,I8),(v_string,I9)}
I5 => SHIFT{(array_ends,I10),(ELEMENTS,I11),(VALUE,I12),(v_string,I13),(v_number,I14),(OBJECT,I15),(ARRAY,I16),(v_true,I17),(v_false,I18),(v_null,I19),(object_starts,I4),(array_starts,I5)}
I6 => REDUCE{($,OBJECT,0),(array_ends,OBJECT,0),(comma,OBJECT,0),(object_ends,OBJECT,0)}
I7 => SHIFT{(object_ends,I20)}
I8 => SHIFT{(comma,I21)}
      REDUCE{(object_ends,MEMBERS,0)}
I9 => SHIFT{(v_pair,I22)}
I10 => REDUCE{($,ARRAY,0),(array_ends,ARRAY,0),(comma,ARRAY,0),(object_ends,ARRAY,0)}
I11 => SHIFT{(array_ends,I23)}
I12 => SHIFT{(comma,I24)}
       REDUCE{(array_ends,ELEMENTS,0)}
I13 => REDUCE{(array_ends,VALUE,0),(comma,VALUE,0),(object_ends,VALUE,0)}
I14 => REDUCE{(array_ends,VALUE,1),(comma,VALUE,1),(object_ends,VALUE,1)}
I15 => REDUCE{(array_ends,VALUE,2),(comma,VALUE,2),(object_ends,VALUE,2)}
I16 => REDUCE{(array_ends,VALUE,3),(comma,VALUE,3),(object_ends,VALUE,3)}
I17 => REDUCE{(array_ends,VALUE,4),(comma,VALUE,4),(object_ends,VALUE,4)}
I18 => REDUCE{(array_ends,VALUE,5),(comma,VALUE,5),(object_ends,VALUE,5)}
I19 => REDUCE{(array_ends,VALUE,6),(comma,VALUE,6),(object_ends,VALUE,6)}
I20 => REDUCE{($,OBJECT,1),(array_ends,OBJECT,1),(comma,OBJECT,1),(object_ends,OBJECT,1)}
I21 => SHIFT{(MEMBERS,I25),(PAIR,I8),(v_string,I9)}
I22 => SHIFT{(VALUE,I26),(v_string,I13),(v_number,I14),(OBJECT,I15),(ARRAY,I16),(v_true,I17),(v_false,I18),(v_null,I19),(object_starts,I4),(array_starts,I5)}
I23 => REDUCE{($,ARRAY,1),(array_ends,ARRAY,1),(comma,ARRAY,1),(object_ends,ARRAY,1)}
I24 => SHIFT{(ELEMENTS,I27),(VALUE,I12),(v_string,I13),(v_number,I14),(OBJECT,I15),(ARRAY,I16),(v_true,I17),(v_false,I18),(v_null,I19),(object_starts,I4),(array_starts,I5)}
I25 => REDUCE{(object_ends,MEMBERS,1)}
I26 => REDUCE{(object_ends,PAIR,0),(comma,PAIR,0)}
I27 => REDUCE{(array_ends,ELEMENTS,1)}

==================================================

                  PARSING TABLE

==================================================
+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+
|               | object_starts |   object_ends |         comma |        v_pair |  array_starts |    array_ends |        v_true |       v_false |        v_null |      v_string |      v_number |             $ |          JSON |         ARRAY |        OBJECT |       MEMBERS |          PAIR |      ELEMENTS |         VALUE |
+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+
|            0  |            s4 |               |               |               |            s5 |               |               |               |               |               |               |               |             1 |             3 |             2 |               |               |               |               |
|            1  |               |               |               |               |               |               |               |               |               |               |               |           acc |               |               |               |               |               |               |               |
|            2  |               |               |               |               |               |               |               |               |               |               |               |            r1 |               |               |               |               |               |               |               |
|            3  |               |               |               |               |               |               |               |               |               |               |               |            r2 |               |               |               |               |               |               |               |
|            4  |               |            s6 |               |               |               |               |               |               |               |            s9 |               |               |               |               |               |             7 |             8 |               |               |
|            5  |            s4 |               |               |               |            s5 |           s10 |           s17 |           s18 |           s19 |           s13 |           s14 |               |               |            16 |            15 |               |               |            11 |            12 |
|            6  |               |            r5 |            r5 |               |               |            r5 |               |               |               |               |               |            r5 |               |               |               |               |               |               |               |
|            7  |               |           s20 |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |
|            8  |               |            r7 |           s21 |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |
|            9  |               |               |               |           s22 |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           10  |               |            r3 |            r3 |               |               |            r3 |               |               |               |               |               |            r3 |               |               |               |               |               |               |               |
|           11  |               |               |               |               |               |           s23 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           12  |               |               |           s24 |               |               |           r10 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           13  |               |           r12 |           r12 |               |               |           r12 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           14  |               |           r13 |           r13 |               |               |           r13 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           15  |               |           r14 |           r14 |               |               |           r14 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           16  |               |           r15 |           r15 |               |               |           r15 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           17  |               |           r16 |           r16 |               |               |           r16 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           18  |               |           r17 |           r17 |               |               |           r17 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           19  |               |           r18 |           r18 |               |               |           r18 |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           20  |               |            r6 |            r6 |               |               |            r6 |               |               |               |               |               |            r6 |               |               |               |               |               |               |               |
|           21  |               |               |               |               |               |               |               |               |               |            s9 |               |               |               |               |               |            25 |             8 |               |               |
|           22  |            s4 |               |               |               |            s5 |               |           s17 |           s18 |           s19 |           s13 |           s14 |               |               |            16 |            15 |               |               |               |            26 |
|           23  |               |            r4 |            r4 |               |               |            r4 |               |               |               |               |               |            r4 |               |               |               |               |               |               |               |
|           24  |            s4 |               |               |               |            s5 |               |           s17 |           s18 |           s19 |           s13 |           s14 |               |               |            16 |            15 |               |               |            27 |            12 |
|           25  |               |            r8 |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           26  |               |            r9 |            r9 |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |               |
|           27  |               |               |               |               |               |           r11 |               |               |               |               |               |               |               |               |               |               |               |               |               |
+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+---------------+
```
