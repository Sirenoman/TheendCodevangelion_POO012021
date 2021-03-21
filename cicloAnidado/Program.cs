using System;

namespace cicloAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nested Cycles");
            Console.Write("Enter the number of numbers in the series: ");
            
            //Declaration of variables
            int total = Int32.Parse(Console.ReadLine());
            double average = 0;
            bool follow = true;
            
            //Funtion works to ask user if it should keep taking averages
            while (follow)
            {
                Console.WriteLine($"Series quantity: {total}");
                // Funcion for para leer, sumar y promediar los numeros 
                for(int i = 1; i <= total; i++)
                {
                    Console.Write($"#{i} Number: ");
                    average += Double.Parse(Console.ReadLine());
                }
                var aDouble = average/total;
                Console.WriteLine($"The final average is: {aDouble}");

                //Function to check if it should be repeated
                bool flag = true;
                while(flag)
                {   
                    //if you type N or n then the first and second While will be terminated
                    Console.WriteLine("Do you want to calcute the average again? s/n");
                    var value = Char.Parse(Console.ReadLine());
                    if( value == 'n' || value == 'N')
                    {
                        
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
