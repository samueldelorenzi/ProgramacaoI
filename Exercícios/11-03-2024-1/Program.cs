//Operadores
int a = 3;
int b = a ++; //++ é um acumulador
//neste ++ vai somar a + 1
WriteLine($"a é {a}, b é {b}");
//-----------------------------------------
int c = 3;
int d = ++c;
WriteLine($"c é {c}, d é {d}");
//++ antes adiciona e depois joga pra variavel, ++ depois joga pra variavel e depois adiciona
//---------------------------------------------------------------------------------------------
int p = 6;
p += 3; //p = p + 3
p -= 3; //p = p - 3
p *= 3; //p = p * 3
p /= 3; //p = p / 3

//Operadores logicos
bool b_A = true;
bool b_B = false;
WriteLine($"AND  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
WriteLine();
WriteLine($"OR  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine();
WriteLine($"XOR  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
