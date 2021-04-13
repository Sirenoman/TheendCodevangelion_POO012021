using System;
using System.Collections.Generic;

namespace GBS.InterfacesLocals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Definimos todas las listas y objetos que usare en este programa 
            var listHo = new List<Hotel>();
            var listCa = new List<Cabins>();
            var listHu = new List<Huts>();
            int NumRooms = 0; // para llevar la cantidad de habitaciones/cabañas/chozas reservará
            bool follow = true;

            Console.WriteLine("BIENVENIDO A TU SITIO WEB PARA HACER RESERVACIONES 'Gualterpistola Booking Services' ");
            do{
                Console.WriteLine("---------------------MENU--------------------");
                Console.WriteLine("1) Reservar \n2) info de reservaciones \n3) Cliente devuelve reservacion \n4) Salir");
                Console.Write("-> ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: // Opcion para hacer las reservaciones.
                        Console.Write("Que desea reservar: \n 1-Hotel \n 2-Cabaña \n 3-Choza \n->");
                        int option2 = Int32.Parse(Console.ReadLine());
                        if(option2 == 1)
                        {
                            var hotel = new Hotel(); // creamos el objeto para hacer la reservacion. 
                            Console.Write("Cantidad de habitaciones? :");
                            NumRooms = Int32.Parse( Console.ReadLine());  // pide la cantidad de habitaciones
                            if(hotel.reservation(NumRooms)) // usa la funcion de la interfaz para evaluar y guardar la reservacion 
                                listHo.Add(hotel); // y lo agrego a la lista que despues usare para mostrar el historial de reservaciones y devolver reservacion.
                            else
                                Console.WriteLine("ERROR");
                        }else if(option2 == 2)
                        {
                            var cabin = new Cabins();
                            Console.Write("Cantidad de Cabañas? :");
                            NumRooms = Int32.Parse( Console.ReadLine());
                            if(cabin.reservation(NumRooms))
                                listCa.Add(cabin);
                            else
                                Console.WriteLine("ERROR");
                        }else if(option2 == 3)
                        {
                            var hut = new Huts();
                            Console.Write("Cantidad de Chozas? :");
                            NumRooms = Int32.Parse( Console.ReadLine());
                            if(hut.reservation(NumRooms))
                                listHu.Add(hut);
                            else 
                                Console.WriteLine("ERROR");
                        }else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case 2: //  Opcion para mostrar el historia de reservaciones con una funcion Lambda 
                        Console.Write("Seleccione el Historial que desea ver: \n 1.Hotel \n 2.Cabañas \n 3.Chozas \n->");
                        option2 = Int32.Parse(Console.ReadLine());
                        if(option2 == 1)
                        {
                            listHo.ForEach(ho => { // Utilizando una funcion lambda de las funciones que tiene la Lista.
                                ho.info(); // llamo al metodo que trae la clase padre para mostrar la informacion. 
                            });

                        }else if(option2 == 2)
                        { // mismo caso para las reservaciones de Cabañas
                            listCa.ForEach(ca => {
                                ca.info();
                            });

                        }else if(option2 == 3)
                        { // y para recorrer las reservaciones de Chozas 
                            listHu.ForEach(hu => {
                                hu.info();
                            });

                        }else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 3: // Mostar cuando un cliente regresa todo lo que se le devolvio para su reservacion ya sea hotel, cabaña y choza
                        Console.Write("Seleccione alojamiento para devolver materiales: \n 1.Hotel \n 2.Cabañas \n 3.Chozas \n->");
                        option2 = Int32.Parse(Console.ReadLine()); // pide que Local que se reservo se devolverla los materiales
                        if(option2 == 1)
                        {
                            foreach(Hotel ho in listHo){ // use foreach para encontrar el valor que eliminara pero que primero
                                ho.back(); // mostrara un mensaje donde diga que el cliente devuelve todos los materiales que ya no usara.
                                listHo.Remove(ho); // ahora se elimina de la lista
                                break; // y para no afectar a mas objetos dentro de la lista, se termina el foreach con break
                            }
                        }else if(option2 == 2)
                        {
                            foreach(Cabins ho in listCa){ // mismo caso para la lista de cabañas
                                ho.back();
                                listCa.Remove(ho);
                                break;
                            }
                        }else if(option2 == 3)
                        { // y seria mismo caso para la lista de Chozas 
                            foreach(Huts ho in listHu){
                                ho.back();
                                listHu.Remove(ho);
                                break;
                            }
                        }else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 4: follow = false; break;
                    default: 
                        Console.WriteLine("Error!"); 
                        break;
                }
            }while(follow);

            Console.WriteLine("Muchas gracias por visitarnos");
        }
    }
}