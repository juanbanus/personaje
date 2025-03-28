class Personaje
{
   //Atributos
   public string Nombre { set;get; }
   public int Salud { set;get; }

 
   //Contructor
   public Personaje(string nombre, int salud)
   {
    this.Nombre = nombre;
    this.Salud = salud;
   }

   //Metodo polimorfismo
    public virtual void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca");
    }

    //Metodo
    public void RecibirDanio(int cantidad) 
    {
        Salud -= cantidad;
       

         Console.WriteLine($"{Nombre} ha recibido la cantidad {cantidad} de daño. Su salud es {Salud}");
    }
}
