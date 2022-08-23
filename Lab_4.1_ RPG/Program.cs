
List<GameCharacter> gameCharacters = new List<GameCharacter>();
gameCharacters.Add(new Warrior("Tnnarg the Barbarian", 15, 8, "Axe"));
gameCharacters.Add(new Warrior("Mr. Poopy Christmas", 19, 5, "Axe"));
gameCharacters.Add(new Wizard("lady Witherell", 17, 12, 9, 4));
gameCharacters.Add(new Wizard("Lord Voldemort", 17, 12, 9, 4));
gameCharacters.Add(new Wizard("Gandolf", 29, 15, 11, 8));



foreach(GameCharacter character in gameCharacters)
{
    Console.WriteLine(character.Dice());
    
   
}

foreach(GameCharacter character in gameCharacters)
{
    Console.WriteLine(character.diceNum);
}

class GameCharacter
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int diceNum;

    public GameCharacter(string name, int strength, int intelligence)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
    }

    public virtual void Play()
    {
        Console.WriteLine($"Name:{Name}, Strength:{Strength}, Intelligence:{Intelligence}");
    }
    public virtual int Dice()
    {
        Random dice = new Random();
        int die = dice.Next(1, 6);
        int die2 = dice.Next(1, 6);
        int combinded = die+ die2;
        this.diceNum = combinded;
        return combinded;
        
    }
}

class Warrior : GameCharacter
{
    public string WeaponType;
    public int diceNum;

    public Warrior(string name, int strength, int intelligence, string weapontype) : base (name, strength,intelligence)
    {
        WeaponType = weapontype;
    }
    public override void Play()
    {
        Console.WriteLine($"Name:{Name}, Strength:{Strength}, Intelligence:{Intelligence}, Weapon Type:{WeaponType}");
    }

}

class MagicUsingCharacter : GameCharacter
{
    public int MagicalEnergy;
    

    public MagicUsingCharacter(string name, int strength, int intelligence,int magicalenergy) : base(name,strength,intelligence)
    {
        MagicalEnergy = magicalenergy;
    }
    public override void Play()
    {
        Console.WriteLine($"Name:{Name}, Strength:{Strength}, Intelligence:{Intelligence}, MagicalEnergy:{MagicalEnergy}");
    }
}

class Wizard :  MagicUsingCharacter 
{
    public int SpellNumber;
    public int diceNum;

    public Wizard(string name, int strength, int intelligence, int magicalenergy, int spell ) : base(name, strength, intelligence, magicalenergy)
    {
        SpellNumber = spell;
    }
    public override void Play()
    {
        Console.WriteLine($"Name:{Name}, Strength:{Strength}, Intelligence:{Intelligence}, MagicalEnergy:{MagicalEnergy}, Spell Number:{SpellNumber}");
    }
}