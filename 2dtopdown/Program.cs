using System;
using Raylib_cs;

Raylib.InitWindow(800,600, "2D-topdown");
Raylib.SetTargetFPS(60);


Rectangle playerRect = new Rectangle(10, 10, 80, 80);



while (!Raylib.WindowShouldClose())
{



Raylib.BeginDrawing();

Raylib.ClearBackground(Color.PURPLE);

Raylib.DrawRectangleRec(playerRect, Color.BLACK);

Raylib.EndDrawing();

}




