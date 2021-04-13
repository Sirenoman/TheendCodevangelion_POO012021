using System;

namespace GBS.InterfacesLocals
{
    public class Cabins : Hebergement, Ireservations
    {
        private int reservations;
        private double cost;

        public Cabins() : base(450.10){
            this.cost = 15.00;
            this.reservations = 0;
        }

        public Cabins(double costP, int reservateP) : base(450.10){
            this.reservations = reservateP;
            this.cost = costP;
        }

        public override void info()
        {
            Console.WriteLine("RESERVACION DE UNA CABAÑA");
            base.info();
            Console.WriteLine("Cantidad de reservacion/es realizada: {0}",reservations);
            Console.WriteLine("costo de la reservación es de : ${0}",cost*reservations);
        }
        public void back()
        {
            Console.WriteLine("Cliente devuelve llave de habitacion y leños que le sobraron");
        }

        public bool reservation(int cant)
        {
            int option3;
            Console.Write("Elegir forma de pago: \n1. Efectivo \n2. Tarjeta de credito \n->");
            option3 = Int32.Parse(Console.ReadLine());
            if(option3 == 1){
                Console.WriteLine($"Efectuando factura.... \nPago realizado por ${cant*cost} por {cant} Cabañas");
                Console.WriteLine("Se le entrega llave del alojamiento y leña para chimenea.");
                reservations = cant;
                return true;
            }else if(option3 == 2){
                Console.WriteLine($"Efectuando pago.... \nPago realizado por ${cant*cost} por {cant} cabañas cargado a N° de tarjeta xxxxx");
                Console.WriteLine("Se le entrega llave del alojamiento y leña para chimenea.");
                reservations = cant;
                return true;
            }else{
                Console.WriteLine("Error!");
                return false;
            }
        }
    }
}