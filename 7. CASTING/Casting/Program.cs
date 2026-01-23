// Casting implicito
int valor = 200;
double total = valor;

Console.WriteLine($"Implicito: {total}");

// Casting explicito
double precio = 500.23;
int descuento = (int)precio;

Console.WriteLine($"Explicito: {descuento}");

char letra = 'A';
int codigoAscii = letra;
Console.WriteLine($"Código Ascii: {codigoAscii}");

string palabra = "123456";
int numero = Convert.ToInt32(palabra); // Funcion para convertir strings a enteros
Console.WriteLine($"String a int: {numero}");

string textoDecimal = "150.60";
double valor3 = Double.Parse(textoDecimal); // Valor texto a double
Console.WriteLine($"String a double: {valor3}");


Console.ReadKey();