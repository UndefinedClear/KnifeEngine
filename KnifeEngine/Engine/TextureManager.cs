using SFML.Graphics;

namespace KnifeEngine.Engine
{
    public static class TextureManager
    {
        public static List<Texture> textures = new List<Texture>();

        // Texture
        public static void RegisterTextures(List<string> imagePaths)
        {
            foreach (string imagePath in imagePaths)
            {
                Texture texture_ = new Texture(imagePath);
                textures.Add(texture_);
            }
        }

        public static Texture GetTextureFromBuffer(int id)
        {
            Texture ?texture;

            if (id >= 0 && id < textures.Count)
            {
                texture = textures[id];
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Asset not found with id: " + id.ToString());
                Console.ForegroundColor = ConsoleColor.White;

                texture = null;
            }

            return texture;
        }
    }
}
