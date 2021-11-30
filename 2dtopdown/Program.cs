using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "2D-topdown");
Raylib.SetTargetFPS(60);

Texture2D playerImage = Raylib.LoadTexture("kool.png");
Rectangle playerRect = new Rectangle(10, 10, 80, 80);



while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();



    Raylib.ClearBackground(Color.PURPLE);

    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        playerRect.x -= 3;
    }

if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        playerRect.y += 3;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        playerRect.x += 3;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        playerRect.y -= 3;
        //Raylib.DrawTriangle (10, 10, 10, );
    }

    Raylib.DrawRectangleRec(playerRect, Color.WHITE);

    Raylib.DrawTexture(playerImage, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

    Raylib.EndDrawing();

}




