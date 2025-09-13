using SFML.Graphics;
using SFML.Window;
using System;

namespace KnifeEngine.Engine
{
    public static class Core
    {
        /// <summary>
        /// Creates and return configured RenderWindow
        /// </summary>
        /// <param name="WIDTH"></param>
        /// <param name="HEIGHT"></param>
        /// <param name="TITLE"></param>
        /// <returns>SFML.Graphics.RenderWindow</returns>
        public static RenderWindow CreateWindow(uint WIDTH = 800, uint HEIGHT = 600, string TITLE = "Default Title")
        {
            RenderWindow window = new RenderWindow(new VideoMode(WIDTH, HEIGHT), TITLE);
            return window;
        }

        /// <summary>
        /// Changes the icon of the engine window (only .png)
        /// </summary>
        /// <param name="window"></param>
        /// <param name="path_to_icon"></param>
        public static void SetWindowIcon(RenderWindow window, string path_to_icon)
        {
            // Загружаем иконку
            Image icon = new Image(path_to_icon);

            // Устанавливаем иконку (важно: RGBA и соответствующий размер)
            window.SetIcon(icon.Size.X, icon.Size.Y, icon.Pixels);
        }

        /// <summary>
        /// Changes the title of the engine window
        /// </summary>
        /// <param name="window"></param>
        public static void SetWindowTitle(RenderWindow window, string title)
        {
            window.SetTitle(title);
        }
    }
}
