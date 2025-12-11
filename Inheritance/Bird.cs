namespace Inheritance;

public class Bird : Animal
{


    public string Color { get; set; }
    public string Type { get; set; }
    public bool CanFly { get; set; }
    public string Food { get; set; }


    public Bird()
    {

    }

    public Bird(string name, int age, int legs, bool domesticated, string color, string type, bool canFly, string food)
    {
        Name = name;
        Age = age;
        Legs = legs;
        Domesticated = domesticated;
        Color = color;
        Type = type;
        CanFly = canFly;
        Food = food;
    }
}