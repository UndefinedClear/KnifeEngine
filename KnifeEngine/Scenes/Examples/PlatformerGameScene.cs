using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using KnifeEngine.Objects;
using KnifeEngine.Engine;

namespace KnifeEngine.Scenes.Examples
{
    public static class PlatformerGameScene
    {
        // Lists
        private static List<SpriteObject> sprites = new List<SpriteObject>(); // Sprites List
        public static List<string> textures_paths = new List<string>();       // Textures Paths List

        // Sprites vars
        private static SpriteObject playerSprite;  // Player

        private static SpriteObject grassSprite;   // Grass 1
        private static SpriteObject grassSprite2;  // Grass 2
        private static SpriteObject grassSprite3;  // Grass 3
        private static SpriteObject grassSprite4;  // Grass 4
        private static SpriteObject grassSprite5;  // Grass 5

        // Gravity and Moving vars
        private static float verticalSpeed = 1.0f;
        private static float horizontalSpeed = 1.0f;

        private static float velocityY = 0f;
        private static float gravity = 0.005f; // 0.001f
        private static float jumpForce = -2.5f; // -1f

        // State vars
        private static bool isJumping = false;
        private static bool isOnGround = false;
        private static bool isDrawHitboxes = false;

        // Velocity
        private static float playerVelocityX = 0f;

        // Pressed keys list
        private static HashSet<Keyboard.Key> pressedKeys = new HashSet<Keyboard.Key>();

        /// <summary>
        /// Use this to start Scene
        /// </summary>
        /// <param name="WIDTH"></param>
        /// <param name="HEIGHT"></param>
        /// <param name="TITLE"></param>
        public static void Load(uint WIDTH = 800, uint HEIGHT = 600, string TITLE = "KnifeEngine | Examples/PlatformerGameScene.cs")
        {
            // Setting endcoding for terminal to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Clear Scene assets
            TextureManager.Clear();
            textures_paths.Clear();
            pressedKeys.Clear();
            sprites.Clear();

            playerSprite = null;
            grassSprite = null;
            grassSprite2 = null;
            grassSprite3 = null;
            grassSprite4 = null;
            grassSprite5 = null;

            // Hide menu
            MainMenuScene.showWindow = false;

            // Creating window variable
            RenderWindow window = Core.CreateWindow(WIDTH, HEIGHT, TITLE);

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
            Vector2f grassHitboxSize = new Vector2f(45, 45);
            Vector2f grassHitboxOffset = new Vector2f(4, 4);

            // Grass Hitboxes
            grassSprite.SetHitbox(grassHitboxSize, grassHitboxOffset);
            grassSprite2.SetHitbox(grassHitboxSize, grassHitboxOffset);
            grassSprite3.SetHitbox(grassHitboxSize, grassHitboxOffset);
            grassSprite4.SetHitbox(grassHitboxSize, grassHitboxOffset);
            grassSprite5.SetHitbox(grassHitboxSize, grassHitboxOffset);

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
            grassSprite2 = new SpriteObject("Resources/Images/grass.png", new Vector2f(200, 300), new Vector2f(50, 50), 3, true);
            grassSprite3 = new SpriteObject("Resources/Images/grass.png", new Vector2f(300, 270), new Vector2f(50, 50), 4, true);
            grassSprite4 = new SpriteObject("Resources/Images/grass.png", new Vector2f(400, 270), new Vector2f(50, 50), 5, true);
            grassSprite5 = new SpriteObject("Resources/Images/grass.png", new Vector2f(500, 300), new Vector2f(50, 50), 6, true);
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
            sprites.Add(grassSprite4);
            sprites.Add(grassSprite5);
        }

        // Pressed keys (not smooth)
        private static void Window_KeyPressed(object sender, KeyEventArgs e) { }

        // Update (smooth, thx Timedelta.cs)
        private static void Update(float deltaTime, RenderWindow window)
        {
            // Current Vector of position
            Vector2f currentPos = playerSprite.GetPosition();

            // Setting velosity to 0f
            playerVelocityX = 0f;

            // Handle horizontal input
            if (pressedKeys.Contains(Keyboard.Key.A))
            {
                playerSprite.SetTexture(1);
                playerVelocityX -= horizontalSpeed;
            }

            if (pressedKeys.Contains(Keyboard.Key.D))
            {
                playerSprite.SetTexture(0);
                playerVelocityX += horizontalSpeed;
            }

            // Handle vertical input
            if (pressedKeys.Contains(Keyboard.Key.W))
            {
                if (isOnGround && !isJumping)
                {
                    velocityY = jumpForce;
                    isJumping = true;
                    isOnGround = false;
                }
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

            // Updating position by X
            Vector2f newXPos = new Vector2f(currentPos.X + playerVelocityX * deltaTime * 100f, currentPos.Y);
            if (!IsColliding(newXPos))
                playerSprite.SetPosition(newXPos);

            // Updating position by Y (gravity)
            UpdatePhysics(deltaTime);
        }

        /// <summary>
        /// Calculating gravity vector
        /// </summary>
        /// <param name="deltaTime"></param>
        private static void UpdatePhysics(float deltaTime)
        {
            Vector2f currentPos = playerSprite.GetPosition();

            velocityY += gravity * deltaTime * 1000f;
            if (velocityY > 12f) velocityY = 12f;

            Vector2f newYPos = new Vector2f(currentPos.X, currentPos.Y + velocityY * deltaTime * 100f);

            if (!IsColliding(newYPos))
            {
                playerSprite.SetPosition(newYPos);
                isOnGround = false;
            }
            else
            {
                if (velocityY > 0)
                {
                    isOnGround = true;
                    isJumping = false;
                }

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
