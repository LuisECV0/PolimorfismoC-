using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    // Clase base
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método virtual que puede ser sobrescrito por las clases derivadas
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // Clase derivada que hereda de Animal
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau guau!");
        }
    }

    // Otra clase derivada que hereda de Animal
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de animales con referencias de clase base
            Animal[] animales = new Animal[]
            {
                new Perro("Rex"),
                new Gato("Misu")
            };

            // Usar polimorfismo para invocar métodos de sonido
            foreach (Animal animal in animales)
            {
                animal.HacerSonido(); // El método apropiado se llama en tiempo de ejecución
            }
        }
    }
}
