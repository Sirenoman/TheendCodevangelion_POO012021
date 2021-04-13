using System;

namespace GBS
{
    public class Hebergement 
    {
        // Atributos 
        protected double area;
        
        // Constructor 
        public Hebergement(double area){
            this.area = area;
        }

        // Metodos 
        public virtual void info(){
            Console.WriteLine($"Este alojamiento tiene un espacio de: {area} metros cuadrado");
        }
    }
}