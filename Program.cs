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

    static void Main(string[] args)
    {
        Vector2 cords = new Vector2();
    }
}