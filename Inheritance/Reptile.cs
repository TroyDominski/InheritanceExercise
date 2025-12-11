namespace Inheritance;

public class Reptile : Animal
{
    public string Color  { get; set; }
    public int Length {get; set;}
    public string Diet { get; set; }
    public bool Regenerative {get; set;}

    public Reptile()
    {
        
    }

    public Reptile(string color, int length, string diet, bool regenerative, string name, int age, int legs,
        bool domesticated)
    {
        Color = color;
        Length = length;
        Diet = diet;
        Regenerative = regenerative;
        Name = name;
        Age = age;
        Legs = legs;
        Domesticated = domesticated;
    }
}