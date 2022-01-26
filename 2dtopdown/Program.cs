
using System;
using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "2D-topdown");
Raylib.SetTargetFPS(60);

string room = "Original";


Texture2D doorImage = Raylib.LoadTexture("door.png");
Texture2D heroImage = Raylib.LoadTexture("hero.png");
Texture2D doorImageLocked = Raylib.LoadTexture("lockeddor.png");
Rectangle gameRect = new Rectangle(10, 10, 80, 80);
Rectangle doorRect = new Rectangle(750, 275, 50, 50);
Rectangle doorRect2 = new Rectangle(750, 275, 50, 50);
//Rectangle doorRect3 = new Rectangle(750, 275, 50, 50);
//Rectangle doorRect4 = new Rectangle(750, 275, 50, 50);

Rectangle r1 = new Rectangle(doorRect.x, doorRect.y, 50, 50);

    room = "room1";

while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();


    // -- GENERAL

        Raylib.DrawRectangleRec(gameRect, Color.WHITE);
        Raylib.DrawTexture(heroImage, (int)gameRect.x, (int)gameRect.y, Color.WHITE);


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



    // ROOM 1
    if (room == "room1")
    {
        Raylib.ClearBackground(Color.ORANGE);
//Door/room1
        Raylib.DrawRectangleRec(doorRect, Color.WHITE);
        Raylib.DrawTexture(doorImage,
            Raylib.GetScreenWidth() - doorImage.width,
            Raylib.GetScreenHeight() / 2 - doorImage.height / 2,
            Color.WHITE);
//Hero/room1

//InteractCheck/room1
        if (Raylib.CheckCollisionRecs(r1, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                room = "room2";
            }


        }
    }

    // ROOM 2

    if (room == "room2")
    {
        Raylib.ClearBackground(Color.DARKGREEN);
//Door/room2
        Raylib.DrawRectangleRec(doorRect, Color.WHITE);
        Raylib.DrawTexture(doorImage, 0, Raylib.GetScreenHeight() / 2 - doorImage.height / 2, Color.WHITE);

//Hero/room2

//InteractCheck/room1
        if (Raylib.CheckCollisionRecs(r1, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                Raylib.DrawText("Hi",300, 200, 90,Color.BLACK);
            }
        }
    }


    Raylib.EndDrawing();

}


//MESSAGE OF LAST LESSON: Du ska göra så att dörren av bilden hamnar tvärt emot där den ligger i rum 1, sen så ska du också göra en ny bild där dörren har gller framför sig, och du ska göra så att om man trycker E på dörren bakom galler så kommer det upp ett meddelande som säger att den är låst.

