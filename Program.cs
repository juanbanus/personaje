using System.Collections;

namespace Personajes;

class Program
{
    static void Main(string[]args)
    {
         //Crear personaje 
       Casador casador1 = new Casador("Rodolfo", 100, 10);
       Animal animal1 = new Animal("Arturo", 100, 30);

      
       //Metodo
       casador1.Atacar();
       animal1.Atacar();
       animal1.RecibirDaño(15);
      
    }
}
