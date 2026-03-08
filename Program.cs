using Raylib_cs;

namespace InteractiveCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Raylib.InitWindow(800, 480, "InteractiveCalculator");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.LightGray);

            Raylib.DrawText("Welcome to interactive calculator", 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}