using System;

namespace espias
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            nombre = "Fulano";
            apellido = "De tal";
        }
    }
    class Anonymous
    {
        public static void anonimiza(ref Persona p)
        {
            p.nombre = "xxxxxxxxx";
            p.apellido = "xxxxxxxx";
        }
        public static void cambia( Persona p)
        {
            p=new Persona();
            p.nombre = "new";
        }
    }
    class Duplicador 
    {
        public void duplica(int x)
        {
            x = x * 2;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
                Persona p = new Persona();
                Console.WriteLine(p.nombre);
                Anonymous.anonimiza( p);
                Anonymous.cambia(ref p);
                Console.WriteLine(p.nombre);
                Duplicador dup = new Duplicador();
                dup.duplica(2);

            int x = 2;
            dup.duplica(x);


            Console.WriteLine("x es {0}",x);
        }
    }
}
