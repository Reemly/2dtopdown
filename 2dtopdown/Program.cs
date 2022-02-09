
using System;
using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "2D-topdown");
Raylib.SetTargetFPS(60);

string room = "Original";

//images
Texture2D doorImage = Raylib.LoadTexture("door.png");
Texture2D heroImage = Raylib.LoadTexture("hero.png");
Texture2D doorImageLocked = Raylib.LoadTexture("lockeddor.png");
Texture2D doorfire = Raylib.LoadTexture("door3.png");
Texture2D doorplant = Raylib.LoadTexture("door4.png");

//goes under image
Rectangle gameRect = new Rectangle(10, 10, 80, 80);
Rectangle doorRect = new Rectangle(750, 275, 50, 50);
Rectangle doorRect2 = new Rectangle(0, 275, 50, 50);
Rectangle doorRect3 = new Rectangle(750, 275, 50, 50);
Rectangle doorRect4 = new Rectangle(750, 275, 50, 50);
Rectangle doorRect5 = new Rectangle(750, 275, 50, 50);

Rectangle r1 = new Rectangle(doorRect.x, doorRect.y, 50, 50);
Rectangle r2 = new Rectangle(doorRect2.x, doorRect2.y, 50, 50);
Rectangle r3 = new Rectangle(doorRect3.x, doorRect3.y, 50, 50);
Rectangle r4 = new Rectangle(doorRect4.x, doorRect4.y, 50, 50);
Rectangle r5 = new Rectangle(doorRect5.x, doorRect5.y, 50, 50);


room = "room1";

int countdown = 0;

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
        Raylib.DrawText("E to open Doors.", 400, 100, 30, Color.BLUE);
        //Door/room1
        Raylib.DrawRectangleRec(doorRect, Color.WHITE);
        Raylib.DrawTexture(doorImage, (int)doorRect.x, (int) doorRect.y, Color.WHITE);


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
        Raylib.DrawRectangleRec(doorRect2, Color.WHITE);
        Raylib.DrawTexture(doorImageLocked, (int)doorRect2.x, (int)doorRect2.y, Color.WHITE);

        //doorfire/room2
Raylib.DrawRectangleRec(doorRect3, Color.WHITE);
Raylib.DrawTexture(doorfire, (int)doorRect3.x, (int)doorRect3.y, Color.WHITE);
        //doorplant/room2
Raylib.DrawRectangleRec(doorRect4, Color.WHITE);
Raylib.DrawTexture(doorplant, (int)doorRect4.x, (int)doorRect4.y, Color.WHITE);
        //doorwater/room2
Raylib.DrawRectangleRec(doorRect5, Color.WHITE);
Raylib.DrawTexture(, (int)doorRect5.x, (int)doorRect5.y, Color.WHITE);
        //InteractCheck/room1
        if (Raylib.CheckCollisionRecs(r2, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                countdown = 120;
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        if (countdown > 0)
        {
            Raylib.DrawText("The door is sealed", 100, 150, 50, Color.BLACK);
            countdown--;
        }
        
    }


    Raylib.EndDrawing();

}


//MESSAGE OF LAST LESSON: work on water door and make rects for them.

