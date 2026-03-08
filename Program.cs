using System.Runtime.InteropServices;
using Raylib_cs;

namespace InteractiveCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Raylib.InitWindow(800, 480, "InteractiveCalculator");

        bool wasClicked = false;

        while (!Raylib.WindowShouldClose())
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                wasClicked = !wasClicked;
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.LightGray);

            Raylib.DrawText("Welcome to interactive calculator", 12, 12, 20, Color.Black);

            if (wasClicked)
            {
                Raylib.DrawText("The mouse was clicked", 30, 30, 30, Color.Black);
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}