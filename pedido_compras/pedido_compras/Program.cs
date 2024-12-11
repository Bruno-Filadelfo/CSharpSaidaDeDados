string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 28;
int codigo = 256892;
char genero = 'M';

double preco1 = 1200.0;
double preco2 = 650.00;

Console.WriteLine("Produtos:");
Console.WriteLine("{0}, cujo preço é R${1:F2}", produto1, preco1);
Console.WriteLine("{0}, cujo preço é R${1:F2}", produto2, preco2);
Console.WriteLine();
Console.WriteLine("Registro: {0} anos de idade código {1} gênero \"{2}\"", idade, codigo, genero);
