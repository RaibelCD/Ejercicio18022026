using System;
using System.Globalization;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int opcion = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("       SOLUCIONARIO COMPLETO (20 EJERCICIOS)      ");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Positivo/Negativo/Cero    11. Cálculo de Impuestos");
                Console.WriteLine("2. Par o Impar               12. Clasificar 3 Números");
                Console.WriteLine("3. Mayor de Edad             13. Verificar Año Bisiesto");
                Console.WriteLine("4. Múltiplo de 5             14. Notas a Letras");
                Console.WriteLine("5. Descuento Cine            15. Formar Triángulo");
                Console.WriteLine("6. Calificación Aprobada     16. Calculadora Descuentos");
                Console.WriteLine("7. Día de la Semana          17. Tipo de Triángulo");
                Console.WriteLine("8. Mayor de Dos              18. Evaluar Temperatura");
                Console.WriteLine("9. Mayor de Tres             19. Horas a Turnos");
                Console.WriteLine("10. Clasificar Ángulos       20. Clasificación IMC");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                    continue;

                Console.WriteLine("\n RESULTADO");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número:");
                        double n1 = double.Parse(Console.ReadLine() ?? "0");
                        if (n1 > 0) Console.WriteLine("Positivo");
                        else if (n1 < 0) Console.WriteLine("Negativo");
                        else Console.WriteLine("Cero");
                        break;

                    case 2:
                        Console.Write("Ingrese un número entero:");
                        int n2 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(n2 % 2 == 0 ? "Es Par" : "Es Impar");
                        break;

                    case 3:
                        Console.Write("Ingrese su edad:");
                        int edad = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "Es menor de edad");
                        break;

                    case 4:
                        Console.Write("Ingrese un número:");
                        int n4 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(n4 % 5 == 0 ? "Es múltiplo de 5" : "No es múltiplo de 5");
                        break;

                    case 5:
                        Console.Write("Edad:");
                        int e5 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(e5 > 60 ? "Aplica para el 50% de descuento" : "No aplica para descuento");
                        break;

                    case 6:
                        Console.Write("Calificación (0-100):");
                        int nota = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(nota >= 60 ? "Aprobó" : "Reprobó");
                        break;

                    case 7:
                        Console.Write("Día (1-7):");
                        int d = int.Parse(Console.ReadLine() ?? "0");
                        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                        if (d >= 1 && d <= 7)
                            Console.WriteLine("Día: " + dias[d - 1]);
                        else
                            Console.WriteLine("Número inválido");
                        break;

                    case 8:
                        Console.Write("N1: "); double a = double.Parse(Console.ReadLine() ?? "0");
                        Console.Write("N2: "); double b = double.Parse(Console.ReadLine() ?? "0");
                        if (a > b) Console.WriteLine($"{a} es el mayor");
                        else if (b > a) Console.WriteLine($"{b} es el mayor");
                        else Console.WriteLine("Son iguales");
                        break;

                    case 9:
                        Console.Write("N1: "); double x1 = double.Parse(Console.ReadLine() ?? "0");
                        Console.Write("N2: "); double x2 = double.Parse(Console.ReadLine() ?? "0");
                        Console.Write("N3: "); double x3 = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("El mayor es:" + Math.Max(x1, Math.Max(x2, x3)));
                        break;

                    case 10:
                        Console.Write("Ángulo:");
                        double ang = double.Parse(Console.ReadLine() ?? "0");
                        if (ang < 90) Console.WriteLine("Agudo");
                        else if (ang == 90) Console.WriteLine("Recto");
                        else if (ang < 180) Console.WriteLine("Obtuso");
                        else if (ang == 180) Console.WriteLine("Llano");
                        else Console.WriteLine("Ángulo inválido");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú.");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
