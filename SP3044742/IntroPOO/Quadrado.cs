public class Quadrado
{
    //propriedade
    public double Lado {get; set;}

     public double Area {get => Lado*Lado;}
  
     public double Perimetro  {get => 4*Lado;}

    //construtor
    public Quadrado(double lado) => this.Lado = lado; 
}