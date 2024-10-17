public class InspectCommand : Command
{
    public InspectCommand() : base("inspect", "Inspect <item> - inspects an item in the game world.") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(commandArgs[1]))
            {
                Console.WriteLine(item.Description);
                return;
            }
        }

        Console.WriteLine("There is nothing to inspect with that name");

    }
}