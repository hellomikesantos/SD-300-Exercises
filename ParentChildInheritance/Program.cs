Cat firstAnimal;
ICrawl secondAnimal;

firstAnimal = new Cat();
secondAnimal = new Amoeba();

Console.WriteLine(firstAnimal.Crawl());
Console.WriteLine(firstAnimal.Jump());
Console.WriteLine(secondAnimal.Crawl());

interface IJump
{
    string Jump();
}

interface ICrawl
{
    string Crawl();
}

interface IDIvide
{

}

class Animal
{
    public TypeOfSkin Skin { get; set; }
    public FurType Fur { get; set; }
}



class Cat : Animal, IJump, ICrawl

{
    public Cat()
    {
        Skin = TypeOfSkin.Scales;
        Fur = FurType.FeralGoat;
    }
    public string Jump()
    {
        return $"The cat jumps and lands on all fourse, or possibly its forehead";
    }

    public string Crawl()
    {
        return $"The cat crawls on the ground on the ends of its paws";
    }

}

class Amoeba : Animal, IDIvide, ICrawl
{
    public TypeOfSkin Skin { get; set; }
    public string Crawl()
    {
        return $"I can crawl I'm Amoeba";
    }
}


//create a new enum representing some kind of trait that all your animals
// will have but with different values that you restrict

// provide a property to the parent Animal class
// inherit Animal in your subclasses and give it a value in the constructor

enum BloofType
{
    APositive,
    ANegative,
}

enum TypeOfSkin
{
    Epithelial = 2147483646,
    Scales,
}

enum FurType
{
    BighornSheep,
    BlackBear,
    Blackbuck,
    CapeBuffalo,
    FeralGoat,
    SikaDeer,
    WaterBuffalo,
}