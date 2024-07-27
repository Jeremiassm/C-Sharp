//1 Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.

/*using System.Drawing;

Console.WriteLine("Ingrese un número para ver si es mayor que 100");
int numero = int.Parse(Console.ReadLine());

if( numero > 100)
{
    Console.WriteLine("El número es mayor que 100");
}

//2 Pedir un número entero por teclado y calcular si es par o impar.

Console.WriteLine("Ingrese un número para ver si es par o impar");
int numero1 = int.Parse(Console.ReadLine());

if( numero1 % 2==0 )
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}

//3 Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición.

Console.WriteLine("Ingrese un número para si es el doble de un impar");
int numero2 = int.Parse(Console.ReadLine());

bool dobleDeImpar;

int mitad = numero2 / 2;

dobleDeImpar = mitad % 2 != 0;

if(dobleDeImpar == true)
{
    Console.WriteLine($"{numero2} es el doble de un número impar.");
}
else
{
    Console.WriteLine($"{numero2} no es el doble de un impar");
}

//4 Dada un número del 1 al 10, devolver su “versión” en números romanos. 
Console.WriteLine("Ingrese un número del 1 al 10 para verlo en números romanos");
int numero3 = int.Parse(Console.ReadLine());

switch (numero3)
{
    case 1:
        Console.WriteLine("El numero 1 en romano es I");
        break;
    case 2:
        Console.WriteLine("El numero 2 en romano es II");
        break;
    case 3:
        Console.WriteLine("El numero 3 en romano es III");
        break;
    case 4:
        Console.WriteLine("El numero 4 en romano es IV");
        break;
    case 5:
        Console.WriteLine("El numero 5 en romano es V");
        break;
    case 6:
        Console.WriteLine("El numero 6 en romano es VI");
        break;
    case 7:
        Console.WriteLine("El numero 7 en romano es VII");
        break;
    case 8:
        Console.WriteLine("El numero 8 en romano es VIII");
        break;
    case 9:
        Console.WriteLine("El numero 9 en romano es IX");
        break;
    case 10:
        Console.WriteLine("El numero 10 en romano es X");
        break;
    default:
        Console.WriteLine("ingrese un numero válido");
        break;
}


//5 Leer el nombre y las edades de dos personas y devolver el nombre del menor. En caso de que tengan la misma edad también debe indicarse. Devolver también la diferencia de edad en caso de corresponder.

Console.WriteLine("Ingrese el nombre de la persona 1");
string nombrePersona1 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la persona 1");
int edadPersona1 =int.Parse (Console.ReadLine());
Console.WriteLine("Ingrese el nombre de la persona 2");
string nombrePersona2 = Console.ReadLine();
Console.WriteLine("Ingrese la edad de la persona 2");
int edadPersona2 = int.Parse(Console.ReadLine());

if (edadPersona1 > edadPersona2)
{
    int diferencia = edadPersona1 - edadPersona2;
    Console.WriteLine($"El menor es {nombrePersona2} con una diferencia de {diferencia} años");
}
else if (edadPersona2 > edadPersona1)
{
    int diferencia = edadPersona2 - edadPersona1;
    Console.WriteLine($"El menor es {nombrePersona1} con una diferencia de {diferencia} años");
}
else
{
    Console.WriteLine("Las dos personas tiene la misma edad");
}

//6 Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
Console.WriteLine("Ingrese la longitud del lado 1:");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la longitud del lado 2:");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la longitud del lado 3:");
double lado3 = Convert.ToDouble(Console.ReadLine());

// Verificar si los lados forman un triángulo
if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
 
    double perimetro = lado1 + lado2 + lado3;
    Console.WriteLine("El perímetro del triángulo es: " + perimetro);

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("El triángulo es equilátero.");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("El triángulo es isósceles.");
    }
    else
    {
        Console.WriteLine("El triángulo es escaleno.");
    }

  
    double s = perimetro / 2;
    double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
    Console.WriteLine("El área del triángulo es: " + area);
}
else
{
    Console.WriteLine("Los lados ingresados no forman un triángulo.");
}


//7
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Ingrese el número a desglosar");
int monto = int.Parse(Console.ReadLine());

int billetes1000 = monto / 1000;
monto %= 1000;

int billetes500 = monto / 500;
monto %= 500;

int billetes100 = monto / 100;
monto %= 100;

int billetes50 = monto / 50;
monto %= 50;

int billetes20 = monto / 20;
monto %= 20;

int billetes10 = monto / 10;
monto %= 10;

int monedas5 = monto / 5;
monto %= 5;

int monedas2 = monto / 2;
monto %= 2;

int monedas1 = monto;

Console.WriteLine("Desglose:");
if (billetes1000 > 0) Console.WriteLine($"{billetes1000} billete(s) de 1000");
if (billetes500 > 0) Console.WriteLine($"{billetes500} billete(s) de 500");
if (billetes100 > 0) Console.WriteLine($"{billetes100} billete(s) de 100");
if (billetes50 > 0) Console.WriteLine($"{billetes50} billete(s) de 50");
if (billetes20 > 0) Console.WriteLine($"{billetes20} billete(s) de 20");
if (billetes10 > 0) Console.WriteLine($"{billetes10} billete(s) de 10");
if (monedas5 > 0) Console.WriteLine($"{monedas5} moneda(s) de 5");
if (monedas2 > 0) Console.WriteLine($"{monedas2} moneda(s) de 2");
if (monedas1 > 0) Console.WriteLine($"{monedas1} moneda(s) de 1");

//8
Console.WriteLine("Ingrese el número");
int numero4 =int.Parse(Console.ReadLine());

Console.WriteLine("Números del 1 al " + numero4 + ":");
for (int i = 1; i <= numero4; i++)
{
    Console.WriteLine(i);
}


//9
int sumaTotal = 0;

for (int i = 1; i <= 15; i++)
{
    Console.Write($"Ingrese el número {i}: ");
    int numero = int.Parse(Console.ReadLine());
    sumaTotal += numero;
}

Console.WriteLine("La suma total de los 15 números es: " + sumaTotal);

//10

bool esMultipoDe3 = false;

for (int i = 1; i < 6; i++) 
{
    Console.WriteLine($"Ingrese el número {i}");
    int numero = int.Parse(Console.ReadLine());
    
    if(numero %3 == 0)
    {
        esMultipoDe3 = true;
    }
}
if (esMultipoDe3)
{
    Console.WriteLine("Al menos un número es multiplo de 3");
}
else
{
    Console.WriteLine("Ninguno de los números es múltiplo de 3");
}


//11

string contraseña1, contraseña2;

do
{
    Console.Write("Ingrese la contraseña: ");
    contraseña1 = Console.ReadLine();

    Console.Write("Vuelva a ingresar la contraseña: ");
    contraseña2 = Console.ReadLine();

    if (contraseña1 != contraseña2)
    {
        Console.WriteLine("Las contraseñas no coinciden. Inténtelo de nuevo.");
    }
} while (contraseña1 != contraseña2);

Console.WriteLine("Las contraseñas coinciden.");

// 12

string contraseña1, contraseña2;
int intentos = 0;
bool coinciden = false;

while (intentos < 3 && !coinciden)
{
    Console.Write("Ingrese la contraseña: ");
    contraseña1 = Console.ReadLine();

    Console.Write("Vuelva a ingresar la contraseña: ");
    contraseña2 = Console.ReadLine();

    if (contraseña1 == contraseña2)
    {
        coinciden = true;
        Console.WriteLine("Las contraseñas coinciden.");
    }
    else
    {
        intentos++;
        if (intentos < 3)
        {
            Console.WriteLine("Las contraseñas no coinciden. Inténtelo de nuevo.");
        }
    }
}
 
//13

    Random random = new Random();
    int numeroSecreto = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
    int intento;
    bool adivinado = false;

    Console.WriteLine("¡Adivina el número secreto entre 1 y 100!");

    while (!adivinado)
    {
        Console.Write("Ingrese su intento: ");
        intento = int.Parse(Console.ReadLine());

        if (intento == numeroSecreto)
        {
            adivinado = true;
            Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
        }
        else
        {
            Console.WriteLine("Intento incorrecto. Inténtelo de nuevo.");
        }
    }


//14
Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int intento;
bool adivinado = false;

Console.WriteLine("¡Adivina el número secreto entre 1 y 100!");

while (!adivinado)
{
    Console.Write("Ingrese su intento: ");
    intento = int.Parse(Console.ReadLine());

    if (intento < numeroSecreto)
    {
        Console.WriteLine("El número secreto es mayor.");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("El número secreto es menor.");
    }
    else
    {
        adivinado = true;
        Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
    }
}

//15

int sumaTotal = 0;
string entrada;

Console.WriteLine("Ingrese números para sumar. Escriba 'fin' para terminar.");

while (true)
{
    entrada = Console.ReadLine();

    if (entrada == "fin")
    {
        break;
    }

    if (int.TryParse(entrada, out int numero))
    {
        sumaTotal += numero;
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número o 'fin' para terminar.");
    }
}

Console.WriteLine("La suma total de los números ingresados es: " + sumaTotal);


//16
Console.Write("Introduce una palabra: ");
string palabra = Console.ReadLine().ToLower();

string inversa = new string(palabra.ToCharArray().Reverse().ToArray());

if (palabra == inversa)
    Console.WriteLine("Es un palíndromo.");
else
    Console.WriteLine("No es un palíndromo.");

//17

Console.Write("Introduce un número para calcular su factorial: ");
int numero = int.Parse(Console.ReadLine());

long factorial = 1;

  for (int i = 1; i <= numero; i++)
  {
     factorial *= i;
  }

Console.WriteLine($"El factorial de {numero} es {factorial}");

//18
Console.WriteLine("Elija una opción:");
Console.WriteLine("1. Celsius a Fahrenheit");
Console.WriteLine("2. Fahrenheit a Celsius");
int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingrese la temperatura: ");
double temperatura = double.Parse(Console.ReadLine());

double resultado;
if (opcion == 1)
{
    resultado = (temperatura * 9 / 5) + 32;
    Console.WriteLine($"{temperatura}°C es igual a {resultado}°F");
}
else if (opcion == 2)
{
    resultado = (temperatura - 32) * 5 / 9;
    Console.WriteLine($"{temperatura}°F es igual a {resultado}°C");
}
else
{
    Console.WriteLine("Opción no válida");
}
//19
Console.Write("Ingrese un número entero positivo para iniciar la secuencia: ");
int inicio = int.Parse(Console.ReadLine());

if (inicio < 0)
{
    Console.WriteLine("Por favor, ingrese un número positivo.");
    return;
}

long a = inicio;
long b = inicio;
int count = 0;

while (count < 50)
{
    Console.Write(a + " ");
    long temp = a;
    a = b;
    b = temp + b;
    count++;
}

//20

string[] palabras = { "programacion", "computadora", "desarrollo", "algoritmo", "inteligencia" };
Random random = new Random();
string palabraSecreta = palabras[random.Next(palabras.Length)];

char[] letrasAdivinadas = new char[palabraSecreta.Length];
for (int i = 0; i < letrasAdivinadas.Length; i++)
    letrasAdivinadas[i] = '_';

int intentosRestantes = 6;

while (intentosRestantes > 0)
{
    Console.WriteLine($"\nPalabra: {string.Join(" ", letrasAdivinadas)}");
    Console.WriteLine($"Intentos restantes: {intentosRestantes}");
    Console.Write("Ingresa una letra: ");
    char letra = Console.ReadLine().ToLower()[0];

    bool acierto = false;
    for (int i = 0; i < palabraSecreta.Length; i++)
    {
        if (palabraSecreta[i] == letra)
        {
            letrasAdivinadas[i] = letra;
            acierto = true;
        }
    }

    if (!acierto)
    {
        intentosRestantes--;
        Console.WriteLine("Letra incorrecta.");
    }

    if (new string(letrasAdivinadas) == palabraSecreta)
    {
        Console.WriteLine($"¡Felicidades! Has adivinado la palabra: {palabraSecreta}");
        return;
    }
}

Console.WriteLine($"Has perdido. La palabra era: {palabraSecreta}");
*/

//21


       
        string[] palabras = { "programacion", "computadora", "desarrollador", "teclado", "raton" };
        Random rnd = new Random();
        string palabra = palabras[rnd.Next(palabras.Length)];
        string palabraOculta = new string('_', palabra.Length);
        int intentos = palabra.Length; 

        Console.WriteLine("¡Bienvenido al juego de adivinar la palabra!");
        Console.WriteLine($"Tienes {intentos} intentos para adivinar la palabra.");

        while (intentos > 0 && palabraOculta.Contains('_'))
        {
            Console.WriteLine($"Palabra: {palabraOculta}");
            Console.Write("Ingresa una letra: ");
            string entrada = Console.ReadLine();

            if (entrada.Length != 1)
            {
                Console.WriteLine("Por favor, ingresa solo una letra.");
                continue;
            }

            char letra = entrada[0];

            if (palabra.Contains(letra))
            {
                
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        palabraOculta = palabraOculta.Remove(i, 1).Insert(i, letra.ToString());
                    }
                }
            }
            else
            {
                intentos--;
                Console.WriteLine($"La letra '{letra}' no está en la palabra. Te quedan {intentos} intentos.");

                
                if (intentos > 0 && palabraOculta.Contains('_'))
                {
                    
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabraOculta[i] == '_')
                        {
                            
                            Random rndChar = new Random();
                            char letraAutocompletada;
                            do
                            {
                                letraAutocompletada = palabra[rndChar.Next(palabra.Length)];
                            } while (palabraOculta.Contains(letraAutocompletada));

                            palabraOculta = palabraOculta.Remove(i, 1).Insert(i, letraAutocompletada.ToString());
                            break; 
                        }
                    }
                }
            }
        }

        if (!palabraOculta.Contains('_'))
        {
            Console.WriteLine($"¡Felicidades! Has adivinado la palabra: {palabra}");
        }
        else
        {
            Console.WriteLine($"¡Game Over! La palabra era: {palabra}");
        }
