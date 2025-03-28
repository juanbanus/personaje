class Animal
{

   public int Poder { set; get; }
   public int Salud { set; get; }
   public string Nombre { set; get;}

   public Animal(string nombre, int poder, int salud)
   {
      this.Nombre = nombre;
      this.Poder= poder;
      this.Salud = salud;
   }

   public virtual void Atacar()
   {
      Console.WriteLine($"{Nombre} ataca");
   }


   public void RecibirDaño(int cantidad)
   {
      Salud -= cantidad;


      Console.WriteLine($"{Nombre} ha recibido la cantidad {cantidad} de daño. Su salud es {Salud}");
   }


}
