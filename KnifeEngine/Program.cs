// SYSTEM
using KnifeEngine.Engine;
// NAMESPACES
using KnifeEngine.Objects;
using KnifeEngine.Scenes;
using KnifeEngine.Scenes.Examples;
// SFML
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace KnifeEngine
{
    class Program
    {
        const uint WIDTH = 800;
        const uint HEIGHT = 600;
        const string TITLE = "KnifeEngine";

        static void Main(string[] args)
        {
            // Setting Encoding
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(@"Select Scene:
1. Platformer
2. TopDown
3. MainMenu");

            Console.Write("> ");
            ConsoleKeyInfo answer = Console.ReadKey();

            // Loading and Starting neccessarry Scene
            switch (answer.KeyChar)
            {
                case '1':
                    PlatformerGameScene.Load(WIDTH, HEIGHT);
                    break;
                case '2':
                    TopDownScene.Load(WIDTH, HEIGHT);
                    break;
                case '3':
                    MainMenuScene.Load(WIDTH, HEIGHT);
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine(answer.ToString() + " not found section by this number");
                    Console.WriteLine("\n");
                    break;
            }
        }
    }
}
