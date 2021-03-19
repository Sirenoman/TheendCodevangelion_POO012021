using System;

struct Date{
    public int year, month, day;
}

namespace optativeStrct
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday;
            Console.WriteLine("Favor ingresar tu fecha de cumpleaños (en numeracion)");
            Console.Write("Año: ");
            birthday.year = ItRealYear();
            Console.Write("Mes: ");
            birthday.month = ItRealMonth();
            Console.Write("Dia: ");
            birthday.day= ItRealDay(birthday.month);

            Date oneDate;
            Console.WriteLine("Favor ingresar la fecha de ahora (en numeracion)");
            Console.Write("Año: ");
            oneDate.year = ItRealYear();
            Console.Write("Mes: ");
            oneDate.month = ItRealMonth();
            Console.Write("Dia: ");
            oneDate.day= ItRealDay(oneDate.month);

            if(birthday.day == oneDate.day && birthday.month == oneDate.month)
            {
                Console.WriteLine("¡FELICIDADES! Hoy es tu dia, celebralo a lo grande");
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumpleaños :c");
            }
        }

        // metodos para validar el año, el mes y el dia correctamente acorde al calendario.
        static int ItRealYear()
        {
            bool flag = true;
            int y = 0;
            while(flag)
            {
                y = Int32.Parse(Console.ReadLine());
                if( y > 0)
                {
                    flag = false;
                }else
                {
                    Console.WriteLine("error!");
                    Console.Write("Ingrese un año correcto: ");
                }
            }
            return y;
                
        }
        // evaluar mes
        static int ItRealMonth()
        {
            bool flag = true;
            int m = 0;
            while(flag)
            {
                m = Int32.Parse(Console.ReadLine());
                if( m > 0 && m < 13)
                {
                    flag = false;
                }else
                {
                    Console.WriteLine("error!");
                    Console.Write("Ingrese un mes correcto: ");
                }
            }
            return m;
        }
        // evaluar dia
        static int ItRealDay(int mth)
        {
            bool flag = true;
            int d = 0;
            while(flag)
            {
                d = Int32.Parse(Console.ReadLine());
                if( mth == 2)
                {
                    if(d > 0 && d < 28)
                        flag = false;
                    else
                        Console.Write("Error! ingrese un dia correcto: ");
                }
                else if(mth == 1 || mth == 3 || mth == 5 || mth  == 7 || mth == 8 || mth == 10 || mth == 12)
                {
                    if(d > 0 && d < 32)
                        flag = false;
                    else
                        Console.Write("Error! ingrese un dia correcto: ");
                }
                else if(mth == 4 || mth == 6 || mth == 9 || mth == 11)
                {
                    if(d > 0 && d < 31)
                        flag = false;
                    else
                        Console.Write("Error! ingrese un dia correcto: ");
                }
            }
            return d;
        }
    }
}
