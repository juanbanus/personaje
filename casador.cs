namespace Personajes;

class Casador : Personaje ///herencia
{
    //Atributos particulares del casador 
    public int Fuerza { set; get; }

    //contructor
    public Casador (string nombre, int salud, int fuerza) : base(nombre, salud) //herencia
    {
        this.Fuerza = fuerza;
    }

    //Transcribir el metodo atacar
    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca con su espada.Saca la cantidad de {Fuerza} fuerza");
    }

}














