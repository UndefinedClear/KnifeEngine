using SFML.Graphics;
using SFML.System;
using SFML.Window;
using KnifeEngine.Engine.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace KnifeEngine.Scenes
{
    public static class MainMenuScene
    {
        public static bool showWindow = true;

        private static RenderWindow window;
        private static Font font;
        private static List<ButtonObject> buttons = new List<ButtonObject>();
        private static bool isRunning = true;
        private static Text titleText;

        public static void StartInThread(uint WIDTH = 800, uint HEIGHT = 600, string TITLE = "Main Menu")
        {
            Thread menuThread = new Thread(() =>
            {
                Load(WIDTH, HEIGHT, TITLE);
            });

            menuThread.SetApartmentState(ApartmentState.STA); // Set STA for UI elements
            menuThread.Start();
        }

        public static void Load(uint WIDTH = 800, uint HEIGHT = 600, string TITLE = "Main Menu")
        {
            isRunning = true;

            window = new RenderWindow(new VideoMode(WIDTH, HEIGHT), TITLE);
            window.Closed += (s, e) => { isRunning = false; window.Close(); };
            window.MouseButtonPressed += OnMousePressed;

            font = new Font("Resources/Fonts/ArialRegular.ttf");

            // Title text
            titleText = new Text("Main Menu", font, 32)
            {
                Position = new Vector2f(250, 100),
                FillColor = Color.White
            };

            CreateButtons();

            while (isRunning)
            {
                window.DispatchEvents();
                Update();
                Render();
            }
        }

        private static void CreateButtons()
        {
            Color backColor = new Color(100, 100, 100);
            Color hoverColor = new Color(70, 70, 70);

            buttons.Clear();

            buttons.Add(
                new ButtonObject(
                    "Start Platformer",
                    font,
                    new Vector2f(250, 200),
                    () =>
                    {
                        Console.WriteLine("Starting Platformer...");
                        Examples.PlatformerGameScene.Load();
                    },
                    backColor,
                    hoverColor
                )
            );

            buttons.Add(
                new ButtonObject(
                    "Start TopDown",
                    font,
                    new Vector2f(250, 280),
                    () =>
                    {
                        Console.WriteLine("Starting TopDown...");
                        Examples.TopDownScene.Load();
                    },
                    backColor,
                    hoverColor
                )
            );

            buttons.Add(
                new ButtonObject(
                    "Exit",
                    font,
                    new Vector2f(250, 360),
                    () =>
                    {
                        Console.WriteLine("Exiting...");
                        isRunning = false;
                        window.Close();
                    },
                    backColor,
                    hoverColor
                )
            );
        }

        private static void Update()
        {
            Vector2i mousePos = Mouse.GetPosition(window);

            foreach (var btn in buttons)
                btn.Update(mousePos);
        }

        private static void Render()
        {
            if (!showWindow) return;

            window.Clear(new Color(30, 30, 30));

            window.Draw(titleText);

            foreach (var btn in buttons)
                btn.Render(window);

            window.Display();
        }

        private static void OnMousePressed(object sender, MouseButtonEventArgs e)
        {
            Vector2i mousePos = new Vector2i(e.X, e.Y);
            foreach (var btn in buttons)
                btn.CheckClick(mousePos);
        }
    }
}
