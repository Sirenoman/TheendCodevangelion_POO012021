using System;

namespace GBS.InterfacesLocals
{
    public class Hotel : Hebergement, Ireservations 
    {
        // atributos 
        private int reservations;
        private double cost;

        // Constructor 
        // sobrecarga 1
        public Hotel() : base(400.50){
            this.reservations = 0;
            this.cost = 10.00;
        }   
        // sobrecarga 2 por si es necesario definir algun objeto ya con otros datos. 
        public Hotel(double cosP, int reservateP) : base(400.50){
            this.reservations = reservateP;
            this.cost = cosP;
        }

        // Metodos 
        public override void info()
        {
            Console.WriteLine("RESERVACION DE HOTEL");
            base.info();
            Console.WriteLine("Cantidad de reservacion/es realizada: {0}",reservations);
            Console.WriteLine("costo de la reservación es de : ${0}",cost*reservations);
        }
        public void back()
        {
            Console.WriteLine("Cliente devuelve llave de habitacion");
        }

        public bool reservation(int cant)
        {
            int option3;
            Console.Write("Elegir forma de pago: \n1. Efectivo \n2. Tarjeta de credito \n->");
            option3 = Int32.Parse(Console.ReadLine());
            if(option3 == 1){
                Console.WriteLine($"Efectuando factura.... \nPago realizado por ${cant*cost} por {cant} habitaciones");
                Console.WriteLine("Se le entrega llave del alojamiento.");
                reservations = cant;
                return true;
            }else if(option3 == 2){
                Console.WriteLine($"Efectuando pago.... \nPago realizado por ${cant*cost} por {cant} habitaciones cargado a N° de tarjeta xxxxx");
                Console.WriteLine("Se le entrega llave del alojamiento.");
                reservations = cant;
                return true;
            }else{
                Console.WriteLine("Error!");
                return false;
            }
        }
    }
}