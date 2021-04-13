using System;

namespace GBS.InterfacesLocals
{
    public class Huts : Hebergement, Ireservations
    {
        private int reservations;
        private double cost;

        public Huts() : base(500.00)
        {
            this.reservations = 0;
            this.cost = 20.00;
        }

        public Huts(double costP, int reservateP) : base(500.00){
            this.reservations = reservateP;
            this.cost = costP;
        }

        // Metodos 
        public override void info()
        {
            Console.WriteLine("RESERVACION DE UNA CHOZA");
            base.info();
            Console.WriteLine("Cantidad de reservacion/es realizada: {0}",reservations);
            Console.WriteLine("costo de la reservación es de : ${0}",cost*reservations);
        }
        public void back()
        {
            Console.WriteLine("Cliente devuelve llave de habitacion, leños que le sobraron y aceites sobrantes");
        }

        public bool reservation(int cant)
        {
            int option3;
            Console.Write("Elegir forma de pago: \n1. Efectivo \n2. Tarjeta de credito \n->");
            option3 = Int32.Parse(Console.ReadLine());
            if(option3 == 1){
                Console.WriteLine($"Efectuando factura.... \nPago realizado por ${cant*cost} por {cant} chozas");
                Console.WriteLine("Se le entrega llave del alojamiento, leña para chimenea y aceites aromaticos.");
                reservations = cant;
                return true;
            }else if(option3 == 2){
                Console.WriteLine($"Efectuando pago.... \nPago realizado por ${cant*cost} por {cant} chozas cargado a N° de tarjeta xxxxx");
                Console.WriteLine("Se le entrega llave del alojamiento, leña para chimenea y aceites aromaticos.");
                reservations = cant;
                return true;
            }else{
                Console.WriteLine("Error!");
                return false;
            }
        }
    }
}