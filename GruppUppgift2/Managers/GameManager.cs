using System.Reflection;

public class GameManager
{
    public static bool gameRunning = false;
    public static Player player;

    public static void Run()
    {
        gameRunning = true;

        // Ifall vi vill använda spelarens namn till något.
        // Console.WriteLine("Enter your name: ");
        // player = new Player(Console.ReadLine());

        player = new Player("Namn");

        RoomManager.CreateRooms();
        RoomManager.EnterRoom("The Hub");

        gameRunning = true;

        while (gameRunning)
        {
            // Console.WriteLine("Type 'help' for a list of commands");
            // Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            MenuManager.GetCurrentMenu().TryExecuteCommand(userInput);
        }
    }
}
