// SYSTEM
using System;
using System.Collections.Generic;

// SFML
using SFML.Graphics;
using SFML.System;
using SFML.Window;

// NAMESPACES
using KnifeEngine.Objects;
using KnifeEngine.Scenes.Examples;
using KnifeEngine.Engine;

namespace KnifeEngine
{
    class Program
    {
        const uint WIDTH = 800;
        const uint HEIGHT = 600;
        const string TITLE = "KnifeEngine | Examples/PlatformerGameScene.cs";

        static void Main(string[] args)
        {
            // Setting Encoding
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(@"Select Scene:
1. Platformer
2. TopDown");

            Console.Write("> ");
            ConsoleKeyInfo answer = Console.ReadKey();

            // Loading and Starting neccessarry Scene
            switch (answer.KeyChar)
            {
                case '1':
                    PlatformerGameScene.Load(WIDTH, HEIGHT, TITLE);
                    break;
                case '2':
                    TopDownScene.Load(WIDTH, HEIGHT, TITLE);
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
