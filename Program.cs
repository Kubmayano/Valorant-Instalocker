using System.Runtime.InteropServices;

class Instalock
{
    class Cursor //Class for moving cursor to set X and Y position
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);
    }

    class Vector2 //Class for storing x and y values in single variable
    {
        public int x {get; set;}
        public int y {get; set;}

        public Vector2()
        {
            //Empty constructor
        }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    static Dictionary<string, Vector2> cords = new Dictionary<string, Vector2>
    {
        {"ASTRA", new Vector2(785, 1225)},
        {"BREACH", new Vector2(895, 1225)},
        {"BRIMSTONE", new Vector2(1005, 1225)},
        {"CHAMBER", new Vector2(1115, 1225)},
        {"CYPHER", new Vector2(1225, 1225)},
        {"FADE", new Vector2(1335, 1225)},
        {"HARBOR", new Vector2(1445, 1225)},
        {"JETT", new Vector2(1555, 1225)},
        {"KAYO", new Vector2(1665, 1225)},
        {"KILLJOY", new Vector2(1775, 1225)},
        {"NEON", new Vector2(785, 1350)},
        {"OMEN", new Vector2(895, 1350)},
        {"PHOENIX", new Vector2(1005, 1350)},
        {"RAZE", new Vector2(1115, 1350)},
        {"REYNA", new Vector2(1225, 1350)},
        {"SAGE", new Vector2(1335, 1350)},
        {"SKYE", new Vector2(1445, 1350)},
        {"SOVA", new Vector2(1555, 1350)},
        {"VIPER", new Vector2(1665, 1350)},
        {"YORU", new Vector2(1775, 1350)},
        {"LOCK", new Vector2(1290, 1085)}
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Enter agent name: ");
        string agent = Console.ReadLine().ToUpper();

        if (String.IsNullOrEmpty(agent)) throw new Exception("Agent name cannot be empty");

        for (int i = 0; i < 100; i++)
        {
            Cursor.SetCursorPos(cords[agent].x, cords[agent].y);
            Thread.Sleep(1);
            Cursor.SetCursorPos(cords["LOCK"].x, cords["LOCK"].y);
            Thread.Sleep(1);
        }
    }
}