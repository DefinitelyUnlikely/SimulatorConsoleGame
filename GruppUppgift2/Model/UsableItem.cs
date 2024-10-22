// Detta är föremål som skall kunna interageras med på ett sätt som är mer betydelsefullt än
// enbart skriva ut en beskriving vid inspektion. Objekt ska ta hand om sig själva, så mycket kring
// denna klass tas mycket möjligt hand om av andra klasser.
public class UsableItem : GameObject
{
    protected readonly string? UseDescription;
    protected string UsableWith { get; }

    public UsableItem(
        string name,
        string description,
        string? useDescription = null,
        string useWith = ""
    )
        : base(name, description)
    {
        UseDescription = useDescription;
        // ?? är en short hand för if (useWith == null) { UsableWith = []; } else { UsableWith = useWith; }
        // Gör så att vi slipper kolla för null i metoden UseItemWith.
        UsableWith = useWith;
    }

    public virtual void UseItem()
    {
        Console.WriteLine(UseDescription);
    }

    public virtual void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine("This seems to do nothing of value");
            return;
        }

        Console.WriteLine($"Using {this} with {itemName}. Implement function.");
    }
}
