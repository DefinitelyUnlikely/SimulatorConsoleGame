public class UseCommand : Command
{
    public UseCommand()
        : base("use", "Use <item> - use specified item, if possible. ") { }

    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 2)
        {
            throw new ArgumentException("Use what?");
        }
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(commandArgs[1]))
            {
                if (item is UsableItem mediator)
                {
                    mediator.UseItem();
                    return;
                }
                else
                {
                    item.Display();
                    return;
                }
            }
        }

        Console.WriteLine("There seems to be no use for that item");
    }
}
