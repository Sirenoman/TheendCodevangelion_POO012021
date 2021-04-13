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
            //Request the data
            Console.WriteLine("Please enter your birthday date (a integer)");
            Console.Write("Year: ");
            birthday.year = ItRealYear();
            Console.Write("Month: ");
            birthday.month = ItRealMonth();
            Console.Write("Day: ");
            birthday.day= ItRealDay(birthday.month);

            Date oneDate;
            Console.WriteLine("Please enter the date now (a integer)");
            Console.Write("Year: ");
            oneDate.year = ItRealYear();
            Console.Write("Month: ");
            oneDate.month = ItRealMonth();
            Console.Write("Day: ");
            oneDate.day= ItRealDay(oneDate.month);

            if(birthday.day == oneDate.day && birthday.month == oneDate.month)
            {
                Console.WriteLine("CONGRATULATIONS! Today is your day, celebrate it with your family");
            }
            else
            {
                Console.WriteLine("Today is not your birthday");
            }
        }

        // Methods to validate the year, month and day correctly according to the calendar.
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
                    Console.Write("Please enter a correct year: ");
                }
            }
            return y;
                
        }
        // Methods to validate the month
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
                    Console.Write("Please enter a correct month:  ");
                }
            }
            return m;
        }
        // Methods to validate the day
        static int ItRealDay(int mth)
        {
            bool flag = true;
            int d = 0;
            while(flag)
            {
                d = Int32.Parse(Console.ReadLine());
                if( mth == 2)
                {
                    if(d > 0 && d <= 28)
                        flag = false;
                    else
                        Console.Write("Error! enter a correct day:  ");
                }
                else if(mth == 1 || mth == 3 || mth == 5 || mth  == 7 || mth == 8 || mth == 10 || mth == 12)
                {
                    if(d > 0 && d < 32)
                        flag = false;
                    else
                        Console.Write("Error! enter a correct day:  ");
                }
                else if(mth == 4 || mth == 6 || mth == 9 || mth == 11)
                {
                    if(d > 0 && d < 31)
                        flag = false;
                    else
                        Console.Write("Error! enter a correct day:  ");
                }
            }
            return d;
        }
    }
}
