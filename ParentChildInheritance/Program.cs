ISayHello Entity = new Person();
ISayHello OtherEntity = new Alien();

Entity.SayHello();
OtherEntity.SayHello();

interface ISayHello
{
    string SayHello();
}

interface IMakeSandwiches
{
    string MakeSandwiches(string mainIngredient);
}

class Person : ISayHello, IMakeSandwiches
{
    public string Name { get; set; }
    public string SayHello()
    {
        return $"Hello, my name is {Name}, the Person";
    }
    public string MakeSandwiches(string mainIngredient)
    {
        return $"I'm a person and I make sandwiches with {mainIngredient}";
    }

}

class Alien : ISayHello
{
    public string AlientTitle { get; set; }
    public string SayHello()
    {
        return $"Hello, my name is {AlientTitle}, the Alien"
    }
}






// what are some things that some types of animals can do, and other can't
// create at least 3 interfaces of an animal's specific behaviour
// create at least 3 implementations of these interfaces

//interface IFlameThrower
//{
//    string FlameThrow();
//}

//interface ICastLightningStrike
//{
//    string CastLightningStrike();
//}

//interface ICastInvisibility
//{
//    string CastInvisibility();
//}

//interface ICastMagicSpell
//{
//    string CastMagicSpell();
//}

//class Wizard: ICastMagicSpell
//{
//    public string Name { get; set; }
//    public string CastMagicSpell()
//    {
//        return $"I am a wizard {Name}, ** Stupefy!!!";
//    }
//    public Wizard(string name)
//    {
//        Name = name;
//    }
//}

//class Pokemon: IFlameThrower
//{
//    public string Name { get; set; }
//    public string FlameThrow()
//    {
//        return $"I'm a {Name} Pokemon! *** Flamethrower!!!";
//    }
//    public Pokemon(string name)
//    {
//        Name = name;
//    }
//}

//class MarvelHero: IFlameThrower, ICastLightningStrike, ICastInvisibility
//{
//    public string Name { get; set; }
//    public string FlameThrow()
//    {
//        return $"I'm {Name} from the Marvel Universe!, **flamethrower!!";
//    }
//    public MarvelHero(string name)
//    {
//        Name = name;
//    }

//    public string CastLightningStrike()
//    {
//        return $"I'm {Name} from Marvel Universe!, **Lightning STRIKE!!!";
//    }

//    public string CastInvisibility()
//    {
//        return $"I'm {Name} from Marvel Universe!, **Invisibility!!!";
//    }
//}









//Cat firstAnimal;
//ICrawl secondAnimal;

//firstAnimal = new Cat();
//secondAnimal = new Amoeba();

//Console.WriteLine(firstAnimal.Crawl());
//Console.WriteLine(firstAnimal.Jump());
//Console.WriteLine(secondAnimal.Crawl());

//interface IJump
//{
//    string Jump();
//}

//interface ICrawl
//{
//    string Crawl();
//}

//interface IDIvide
//{

//}

//class Animal
//{
//    public TypeOfSkin Skin { get; set; }
//    public FurType Fur { get; set; }
//}



//class Cat : Animal, IJump, ICrawl

//{
//    public Cat()
//    {
//        Skin = TypeOfSkin.Scales;
//        Fur = FurType.FeralGoat;
//    }
//    public string Jump()
//    {
//        return $"The cat jumps and lands on all fourse, or possibly its forehead";
//    }

//    public string Crawl()
//    {
//        return $"The cat crawls on the ground on the ends of its paws";
//    }

//}

//class Amoeba : Animal, IDIvide, ICrawl
//{
//    public TypeOfSkin Skin { get; set; }
//    public string Crawl()
//    {
//        return $"I can crawl I'm Amoeba";
//    }
//}


// create a new enum representing some kind of trait that all your animals
// will have but with different values that you restrict

// provide a property to the parent Animal class
// inherit Animal in your subclasses and give it a value in the constructor

//enum BloofType
//{
//    APositive,
//    ANegative,
//}

//enum TypeOfSkin
//{
//    Epithelial = 2147483646,
//    Scales,
//}

//enum FurType
//{
//    BighornSheep,
//    BlackBear,
//    Blackbuck,
//    CapeBuffalo,
//    FeralGoat,
//    SikaDeer,
//    WaterBuffalo,
//}