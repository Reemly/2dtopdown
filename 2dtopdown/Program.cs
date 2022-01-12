
using System;
using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "2D-topdown");
Raylib.SetTargetFPS(60);

string room = "Original";


Texture2D doorImage = Raylib.LoadTexture("door.png");
Texture2D heroImage = Raylib.LoadTexture("hero.png");
Rectangle gameRect = new Rectangle(10, 10, 80, 80);
Rectangle doorRect = new Rectangle(300, 750, 50, 50);
Rectangle r1 = new Rectangle(300, 750, 50, 50);


while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();





    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        gameRect.x -= 3;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        gameRect.y += 3;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        gameRect.x += 3;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        gameRect.y -= 3;
    }








    if (Raylib.CheckCollisionRecs(r1, gameRect))
    {
        gameRect.x += 2;
        room = "room2";
    }
    else
    {
        Raylib.ClearBackground(Color.ORANGE);
         


    }

    if (room == "room1")
    {

    }

    if (room == "room2")
    {
        Raylib.ClearBackground(Color.VIOLET);
        Raylib.DrawText("You winner!!", 275, 300, 40, Color.BLACK);

        if (Raylib.CheckCollisionRecs(r1, gameRect))
        {
            room = "Original";
        }
        else
        {
            Raylib.ClearBackground(Color.VIOLET);
        }
    }


    Raylib.DrawRectangleRec(doorRect, Color.WHITE);

    Raylib.DrawTexture(doorImage, 
        Raylib.GetScreenWidth() - doorImage.width, 
        Raylib.GetScreenHeight()/2 - doorImage.height/2, 
        Color.WHITE);

    Raylib.DrawRectangleRec(gameRect, Color.WHITE);

    Raylib.DrawTexture(heroImage, (int)gameRect.x, (int)gameRect.y, Color.WHITE);

    Raylib.EndDrawing();

}




