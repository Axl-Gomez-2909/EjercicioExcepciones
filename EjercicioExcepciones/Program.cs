using EjercicioExcepciones;
//Instanciamiento de la clase operaciones
Operaciones operaciones = new Operaciones();

//Declaración de variables
double num1=0, num2=0;
//Declaración de variable booleana para validar la entrada en los ciclos
bool entradaValida = false;

//Ciclo para validar si se comete un catch por error de formato 
do
{
    //Validación si el primer número no sea una letra o cual quier cosa
    try
    {
        Console.Write("Ingrese el primer número: ");
        num1 = double.Parse(Console.ReadLine());
        entradaValida = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número válido.");
    }
} while (!entradaValida);

entradaValida = false;

//Ciclo para validar si se comete un catch por error de formato 
do
{
    //Validación si el segundo número no sea una letra o cual quier cosa
    try
    {
        Console.Write("Ingrese el segundo número: ");
        num2 = double.Parse(Console.ReadLine());
        entradaValida = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número válido.");
    }
} while (!entradaValida);

//Validación de dividir entre cero
try
{
    double suma = operaciones.Sumar(num1, num2);
    double resta = operaciones.Restar(num1, num2);
    double multiplicacion = operaciones.Multiplicar(num1, num2);
    double division = operaciones.Dividir(num1, num2);

    Console.WriteLine($"Resultado de la suma: {num1}+{num2}= {suma}");
    Console.WriteLine($"Resultado de la resta:  {num1}-{num2}= {resta}");
    Console.WriteLine($"Resultado de la multiplicación:  {num1}*{num2}= {multiplicacion}");
    Console.WriteLine($"Resultado de la división:  {num1}/{num2}= {division}");
}
catch (DivideByZeroException ex)
{

    Console.WriteLine("Error fatal: " + ex.Message);
}
    
