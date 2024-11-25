public class Program
{
    private static void Main()
    {
        //45.Realizar un programa en C# que declare un array con N enteros, a continuación, lo inicialice con valores aleatorios (del 1 al 10) y posteriormente en otros 2 arrays guardar el cuadrado de cada uno de los números número y cubo de ese número. Muestre en pantalla cada elemento del primer vector de enteros junto con su cuadrado y su cubo.

        Console.WriteLine("Ingrese el número de elementos: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        //Declaramos los 3 Arrays
        int[] numeros = new int[n];
        double[] cuadrados = new double[n];
        double[] cubos = new double[n];

        FillArray(n, numeros);
        CalculateOperations(n, numeros, cuadrados, cubos);
        ShowResults(n, numeros, cuadrados, cubos);

    }

    private static void ShowResults(int n, int[] numeros, double[] cuadrados, double[] cubos)
    {
        Console.WriteLine("Numero\tCuadrado\tCubo");

        for (int i = 0; i < n; i++)
            Console.WriteLine($"{numeros[i]}\t{cuadrados[i]}\t\t{cubos[i]}");
      
    }

    private static void CalculateOperations(int n, int[] numeros, double[] cuadrados, double[] cubos)
    {
        for (int i = 0; i < n; i++)
        {
            cuadrados[i] = Math.Pow(numeros[i], 2);
            cubos[i] = Math.Pow(numeros[i], 3);
        }
    }

    private static void FillArray(int n, int[] numeros)
    {
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            numeros[i]= random.Next(1, 11);
            //numeros[i] = number;
        }

    }
}