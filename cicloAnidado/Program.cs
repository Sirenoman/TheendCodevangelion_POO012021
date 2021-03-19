using System;

namespace cicloAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Optativa de Ciclos Anidados");
            Console.Write("Ingrese la cantidad de numeros de la serie: ");
            int total = Int32.Parse(Console.ReadLine());
            double average = 0;

            bool follow = true;
            // funcion While para preguntar al usuario si seguir sacando promedios
            while (follow)
            {
                Console.WriteLine($"Cantidad de la serie: {total}");
                // Funcion for para leer, sumar y promediar los numeros 
                for(int i = 1; i <= total; i++)
                {
                    Console.Write($"#{i} Numero: ");
                    average += Double.Parse(Console.ReadLine());
                }
                var aDouble = average/total;
                Console.WriteLine($"El promedio final es: {aDouble}");

                bool flag = true;
                // Otro While anidado para consultar si seguir y que se tome en cuenta si es la respuesta correta el 's' o 'n'
                while(flag)
                {
                    Console.WriteLine("¿Quieres seguir calculando mas promedios? s/n");
                    var value = Char.Parse(Console.ReadLine());
                    if( value == 'n' || value == 'N')
                    {
                        // si escribe N o n entonces el primer y segundo While se terminaran
                        flag = false;
                        follow = false;
                    }else if(value == 's' || value == 'S')
                    {
                        flag = false;
                    }
                }
        
            }

        }
    }
}
