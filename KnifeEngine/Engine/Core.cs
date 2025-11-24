using SFML.Graphics;
using SFML.System;
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
        /// Get Absoulute Mouse Position (OUTSIDE WINDOW)
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static Vector2i GetAbsouluteMousePosition(RenderWindow window)
        {
            return Mouse.GetPosition(window);
        }

        /// <summary>
        /// Get InGame Mouse Position
        /// </summary>
        /// <param name="window"></param>
        /// <param name="absolute_mouse_pos"></param>
        /// <returns>Vector2i -> Vector2f</returns>
        public static Vector2f GetInGameMousePosition(RenderWindow window, Vector2i absolute_mouse_pos)
        {
            return window.MapPixelToCoords(absolute_mouse_pos);
        }

        /// <summary>
        /// Converts screen pixels to game coordinates
        /// </summary>
        /// <param name="window"></param>
        /// <param name="pixels_position"></param>
        /// <returns>Vector2i -> Vector2f</returns>
        public static Vector2f PixelsToGameCoordinates(RenderWindow window, Vector2i pixels_position)
        {
            return window.MapPixelToCoords(pixels_position);
        }

        /// <summary>
        /// Converts game coordinates to screen pixels
        /// </summary>
        /// <param name="window"></param>
        /// <param name="coordinates"></param>
        /// <returns>Vector2f -> Vector2i</returns>
        public static Vector2i GameCoordinatesToPixels(RenderWindow window, Vector2f coordinates)
        {
            return window.MapCoordsToPixel(coordinates);
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
