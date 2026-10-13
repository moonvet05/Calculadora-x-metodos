namespace Proyecto

{
    internal class program

    {
        static void Main(string[] args) 
        {
            double resultado1, resultado2, resultado3, resultado4;

            Console.Write("ingrese el primer valor: ");
            double num1 = double.Parse(Console.ReadLine());
           

            Console.Write("ingrese el segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado1 = sumar(num1, num2);
            resultado2 = Restar(num1, num2);
            resultado3 = Multiplicar(num1, num2);
            resultado4 = dividir(num1, num2);

            Console.WriteLine("Suma: " + resultado1);
            Console.WriteLine("Resta: " + resultado2);
            Console.WriteLine("multiplicación: " + resultado3);
            Console.WriteLine("Dividir " + resultado4);



            // Suma
            static double sumar(double valor1, double valor2) 
            {
                return valor1 + valor2;

            }
            // resta
            static double Restar(double valor1, double valor2)
            {
                return valor1 - valor2;

            }
            // multiplicacion
            static double Multiplicar(double valor1, double valor2)
            {
                return valor1 * valor2;

            }

            // Divicion
            static double dividir(double valor1, double valor2)
            {
                return valor1 / valor2;

            }




        }

        

    }

}

