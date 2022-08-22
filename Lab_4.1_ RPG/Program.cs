
List<GameCharacter> gameCharacters = new List<GameCharacter>();
gameCharacters.Add(new Warrior("Tnnarg the Barbarian", 15, 8, "Axe"));
gameCharacters.Add(new Warrior("Mr. Poopy Christmas", 19, 5, "Axe"));
gameCharacters.Add(new Wizard("lady Witherell", 17, 12, 9, 4));
gameCharacters.Add(new Wizard("Lord Voldemort", 17, 12, 9, 4));
gameCharacters.Add(new Wizard("Gandolf", 29, 15, 11, 8));



foreach(GameCharacter character in gameCharacters)
{
    character.Play();
}


class GameCharacter
{
    public string Name;
    public int Strength;
    public int Intelligence;

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
}

class Warrior : GameCharacter
{
    public string WeaponType;
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
    public Wizard(string name, int strength, int intelligence, int magicalenergy, int spell ) : base(name, strength, intelligence, magicalenergy)
    {
        SpellNumber = spell;
    }
    public override void Play()
    {
        Console.WriteLine($"Name:{Name}, Strength:{Strength}, Intelligence:{Intelligence}, MagicalEnergy:{MagicalEnergy}, Spell Number:{SpellNumber}");
    }
}