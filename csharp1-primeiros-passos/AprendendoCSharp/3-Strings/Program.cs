Console.WriteLine("Executando o Projeto 3 - Strings");

// character ' '
char umaLetra = 'L';
Console.WriteLine($"umaLetra = 'L' = {umaLetra}");

umaLetra = (char)65;
Console.WriteLine($"(char)65 = {umaLetra}");

// string
string texto = "Esse é um texto usando string";
Console.WriteLine(texto);

string testeLinhas1 = "Cursos:" +
    "\n- Java" +
    "\n- Python" +
    "\n- C#";

string testeLinhas2 = 
@"Cursos:
- Java
- Python
- C#";

Console.WriteLine(testeLinhas1);
Console.WriteLine(testeLinhas2);

