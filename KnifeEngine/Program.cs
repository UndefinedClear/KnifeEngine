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

            // Регистрируем сцены
            SceneManager.RegisterScene("TopDown", () => TopDownScene.Load());
            SceneManager.RegisterScene("Platformer", () => PlatformerGameScene.Load());
            SceneManager.RegisterScene("MainMenu", () => MainMenuScene.Load());

            // Запускаем нужную сцену
            //SceneManager.LoadScene("MainMenu");

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
                    SceneManager.LoadScene("TopDown");
                    break;
                case '2':
                    SceneManager.LoadScene("TopDown");
                    break;
                case '3':
                    SceneManager.LoadScene("MainMenu");
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
