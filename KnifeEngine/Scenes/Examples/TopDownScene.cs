using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using KnifeEngine.Objects;
using KnifeEngine.Engine;

namespace KnifeEngine.Scenes.Examples
{
    public static class TopDownScene
    {
        // Lists
        private static List<SpriteObject> sprites = new List<SpriteObject>(); // Sprites List
        public static List<string> textures_paths = new List<string>();       // Textures Paths List

        // Sprites vars
        private static SpriteObject playerSprite;  // Player

        private static SpriteObject grassSprite;   // Grass 1
        private static SpriteObject grassSprite2;  // Grass 2
        private static SpriteObject grassSprite3;  // Grass 3

        // Gravity and Moving vars
        private static float verticalSpeed = 1.0f;
        private static float horizontalSpeed = 1.0f;

        private static float velocityY = 0f;

        // State vars
        private static bool isJumping = false;
        private static bool isOnGround = false;
        private static bool isDrawHitboxes = false;

        // Velocity
        private static float playerVelocityX = 0f;
        private static float playerVelocityY = 0f;

        // Pressed keys list
        private static HashSet<Keyboard.Key> pressedKeys = new HashSet<Keyboard.Key>();

        /// <summary>
        /// Use this to start Scene
        /// </summary>
        /// <param name="WIDTH"></param>
        /// <param name="HEIGHT"></param>
        /// <param name="TITLE"></param>
        public static void Load(uint WIDTH = 800, uint HEIGHT = 600, string TITLE = "KnifeEngine | Examples/TopDownScene.cs")
        {
            // Clear Scene assets
            TextureManager.Clear();
            textures_paths.Clear();
            pressedKeys.Clear();
            sprites.Clear();

            playerSprite = null;
            grassSprite = null;
            grassSprite2 = null;
            grassSprite3 = null;

            // Setting endcoding for terminal to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Creating window variable
            RenderWindow window = Core.CreateWindow(WIDTH, HEIGHT, TITLE);

            // Hide window
            MainMenuScene.showWindow = false;

            // Registering Handlers (for window)

            // Closing window event
            window.Closed += (s, e) => window.Close();

            // Redirecting Pressed keys to "pressedKeys"
            window.KeyPressed += (s, e) => pressedKeys.Add(e.Code);
            window.KeyReleased += (s, e) => pressedKeys.Remove(e.Code);

            // Setting icon
            Core.SetWindowIcon(window, "Resources/Images/player_right.png");

            // Registering Textures (Use special order = ids like: 0, 1, 2)
            textures_paths.Add("Resources/Images/player_right.png"); // 0
            textures_paths.Add("Resources/Images/player_left.png");  // 1
            textures_paths.Add("Resources/Images/grass.png");        // 2

            TextureManager.RegisterTextures(textures_paths);

            // Sprites
            InitSprites();

            // Hitboxes (neccessay in this case)
            InitHitboxes();

            // Registering Sprites
            RegisterSprites();

            // Creating clock for deltaTime
            Clock clock = Timedelta.MkClock();

            // Main loop
            while (window.IsOpen)
            {
                // Window Events
                window.DispatchEvents();

                // Updating clock for deltaTime
                float deltaTime = Timedelta.Time(clock);

                // Update with deltaTime
                Update(deltaTime, window);

                // Rendering window
                Render(window);
            }
        }

        /// <summary>
        /// Initializing Hitboxes for Sprites
        /// </summary>
        private static void InitHitboxes()
        {
            // Grass Hitboxes
            grassSprite.SetHitbox(new Vector2f(45, 45), new Vector2f(4, 4));
            grassSprite2.SetHitbox(new Vector2f(45, 45), new Vector2f(4, 4));
            grassSprite3.SetHitbox(new Vector2f(45, 45), new Vector2f(4, 4));

            // Player Hitboxes
            playerSprite.SetHitbox(new Vector2f(40, 80), new Vector2f(29, 10));
        }

        /// <summary>
        /// Initializing Sprite Variables to act with them in the code
        /// </summary>
        private static void InitSprites()
        {
            // Player
            playerSprite = new SpriteObject("Resources/Images/player_right.png", new Vector2f(100, 150), new Vector2f(100, 100), 1, true);

            // Grass
            grassSprite = new SpriteObject("Resources/Images/grass.png", new Vector2f(100, 300), new Vector2f(50, 50), 2, true);

            // Bugged
            //grassSprite.SetRotateAroundCenter(true);
            //grassSprite.SetRotation(180.0f);


            grassSprite2 = new SpriteObject("Resources/Images/grass.png", new Vector2f(200, 300), new Vector2f(50, 50), 3, true);
            grassSprite3 = new SpriteObject("Resources/Images/grass.png", new Vector2f(300, 270), new Vector2f(50, 50), 4, true);
        }

        /// <summary>
        /// Registering Texture for Sprites (It's much optimize: 8gb -> 175mb)
        /// </summary>
        private static void RegisterSprites()
        {
            // Player Sprite
            sprites.Add(playerSprite);

            // Grass Platform Sprites
            sprites.Add(grassSprite);
            sprites.Add(grassSprite2);
            sprites.Add(grassSprite3);
        }

        // Pressed keys (not smooth)
        private static void Window_KeyPressed(object sender, KeyEventArgs e) { }

        // Update (smooth, thx Timedelta.cs)
        private static void Update(float deltaTime, RenderWindow window)
        {
            Vector2f currentPos = playerSprite.GetPosition();

            // Reset velocity
            playerVelocityX = 0f;
            playerVelocityY = 0f;

            // Handle horizontal input
            if (pressedKeys.Contains(Keyboard.Key.A))
            {
                playerVelocityX -= horizontalSpeed;
                playerSprite.SetTexture(1); // player facing left
            }
            if (pressedKeys.Contains(Keyboard.Key.D))
            {
                playerVelocityX += horizontalSpeed;
                playerSprite.SetTexture(0); // player facing right
            }

            // Handle vertical input
            if (pressedKeys.Contains(Keyboard.Key.W))
            {
                playerVelocityY -= verticalSpeed;
            }
            if (pressedKeys.Contains(Keyboard.Key.S))
            {
                playerVelocityY += verticalSpeed;
            }

            // Handle engine keys input
            if (pressedKeys.Contains(Keyboard.Key.O))
            {
                isDrawHitboxes = true;
            }
            if (pressedKeys.Contains(Keyboard.Key.P))
            {
                isDrawHitboxes = false;
            }
            if (pressedKeys.Contains(Keyboard.Key.Escape))
            {
                Console.WriteLine("[LOGGER] | WINDOW CLOSED!");

                // Show menu
                MainMenuScene.showWindow = true;
                window.Close();
                SceneManager.LoadScene("MainMenu");
            }

            // Normalize velocity vector to keep consistent speed diagonally
            Vector2f velocity = new Vector2f(playerVelocityX, playerVelocityY);
            if (velocity.X != 0 || velocity.Y != 0)
            {
                float length = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
                velocity.X /= length;
                velocity.Y /= length;
                velocity.X *= horizontalSpeed;
                velocity.Y *= verticalSpeed;
            }

            // Calculate new position
            Vector2f newPos = new Vector2f(
                currentPos.X + velocity.X * deltaTime * 100f,
                currentPos.Y + velocity.Y * deltaTime * 100f
            );

            // Collision check and update position
            if (!IsColliding(newPos))
            {
                playerSprite.SetPosition(newPos);
            }

            // No gravity or physics update needed in top-down
        }


        /// <summary>
        /// Calculating gravity vector
        /// </summary>
        /// <param name="deltaTime"></param>
        private static void UpdatePhysics(float deltaTime)
        {
            Vector2f currentPos = playerSprite.GetPosition();

            //velocityY += gravity * deltaTime * 1000f;
            if (velocityY > 12f) velocityY = 12f;

            Vector2f newYPos = new Vector2f(currentPos.X, currentPos.Y + velocityY * deltaTime * 100f);

            if (!IsColliding(newYPos))
            {
                playerSprite.SetPosition(newYPos);
            }
            else
            {
                velocityY = 0;
            }
        }


        /// <summary>
        /// Checking collisions
        /// </summary>
        /// <param name="newPlayerPos"></param>
        /// <returns></returns>
        private static bool IsColliding(Vector2f newPlayerPos)
        {
            foreach (var sprite in sprites)
            {
                // Checking if sprite is player
                if (sprite == playerSprite) continue;

                // Checking if sprite has tag "player" (You can make invisible triggers)
                //if (sprite.GetTag() == "player") { // DO SOMETHING };

                // Calculating
                if (playerSprite.CheckCustomCollisionAt(newPlayerPos, sprite))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Renderers window
        /// </summary>
        /// <param name="window"></param>
        private static void Render(RenderWindow window)
        {
            window.Clear(Color.White);
            foreach (var sprite in sprites)
            {
                sprite.Render(window);

                if (isDrawHitboxes)
                    sprite.DrawHitbox(window, Color.Red);
            }
            window.Display();
        }
    }
}
