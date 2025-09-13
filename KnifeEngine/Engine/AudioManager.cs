using SFML.Audio;

namespace KnifeEngine.Engine
{
    public static class AudioManager
    {
        private static Dictionary<string, SoundBuffer> soundBuffers = new Dictionary<string, SoundBuffer>();
        private static Dictionary<string, Sound> sounds = new Dictionary<string, Sound>();

        /// <summary>
        /// Registering an Audio File and Saving them by the key (only .wav)
        /// </summary>
        public static void RegisterSound(string key, string path)
        {
            if (!soundBuffers.ContainsKey(key))
            {
                SoundBuffer buffer = new SoundBuffer(path);
                soundBuffers[key] = buffer;
                sounds[key] = new Sound(buffer);
            }
        }

        /// <summary>
        /// Returns Sound by Key
        /// </summary>
        public static Sound GetSound(string key)
        {
            if (sounds.ContainsKey(key))
            {
                return sounds[key];
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[AudioManager] Sound with key \"{key}\" doesn't regstered!");
            Console.ResetColor();
            return null;
        }

        /// <summary>
        /// Checks whether the sound has finished playing
        /// </summary>
        public static bool IsSoundFinished(string key)
        {
            if (sounds.ContainsKey(key))
            {
                return sounds[key].Status == SoundStatus.Stopped;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[AudioManager] Sound with key \"{key}\" doesn't regstered!");
            Console.ResetColor();
            return true; // return true to not cycling
        }
    }
}
