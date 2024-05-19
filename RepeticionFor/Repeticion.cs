
namespace RepeticionFor
{
    public class Repeticion
    {
        public void ValoresMayores()

        {

            try
            {

                int numero = 0;
                int valor = 0;
                int MayorDe1k = 0;

                Console.WriteLine("Ingrese la cantidad de numeros a consultar ->");
                numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= numero; i++)

                {
                    Console.WriteLine($"Ingrese el valor {i}");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor >= 1000)

                    {
                        MayorDe1k++;
                    }

                }

                {
                    Console.WriteLine($" El numero de valores Mayores o Iguales a 1,000 es -> {MayorDe1k} <- ");
                }

            }

            catch (Exception ex)

            {
                Console.WriteLine($"Ocurrio un error con los datos suministrados {ex.Message}");
            }

        }

        public void Triangulo()

        {
            try
            {
                int Base = 0;
                int Altura = 0;
                int Pares = 0;
                int Superficie = 0;
                int Mayor12 = 0;

                {
                    Console.WriteLine("Cuantos pares de triangulos desea calcular?");
                    Pares = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 1; i <= Pares; i++)
                {
                    Console.WriteLine($"Ingrese la medida de la base del Triangulo {i}");
                    Base = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Ingrese la medida de la altura del Triangulo {i}");
                    Altura = Convert.ToInt32(Console.ReadLine());

                    Superficie = Base * Altura / 2;

                    if (Superficie > 12)

                    {
                        Mayor12++;
                    }

                    {
                        Console.WriteLine($"La Base del triangulo es {Base}");
                        Console.WriteLine($"La Altura del triangulo es {Altura}");
                        Console.WriteLine($"La superficie del triangulo es {Superficie}");
                    }

                }

                {
                    Console.WriteLine($" --> {Mayor12} <-- Son Triangulos con superficie mayor de 12");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error con los datos suministrados {ex.Message}");
            }

        }

        public void TablaDel5()
        {
            try
            {
                int multiplo = 0;

                {
                    Console.WriteLine(" Ingrese la tabla de multiplicacion que desea visualizar:");
                    multiplo = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= 50; i++)

                    {
                        Console.WriteLine(multiplo + " X " + i + " = " + multiplo * i);
                    }

                }

            }
            catch (Exception ex)

            {

                Console.WriteLine ($" Ha ocurrido un error en los datos suministrados {ex.Message}");
            }

        }
    }
}




