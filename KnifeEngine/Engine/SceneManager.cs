using System;
using System.Collections.Generic;

namespace KnifeEngine.Engine
{
    public static class SceneManager
    {
        private static Dictionary<string, Action> scenes = new Dictionary<string, Action>();
        private static string currentSceneName;

        /// <summary>
        /// Регистрирует новую сцену.
        /// </summary>
        public static void RegisterScene(string name, Action sceneLoadMethod)
        {
            if (!scenes.ContainsKey(name))
                scenes.Add(name, sceneLoadMethod);
        }

        /// <summary>
        /// Загружает и запускает сцену.
        /// </summary>
        public static void LoadScene(string name)
        {
            if (scenes.ContainsKey(name))
            {
                currentSceneName = name;
                Console.WriteLine($"\n[SceneManager] | Loading scene: {name}");
                scenes[name].Invoke();
            }
            else
            {
                Console.WriteLine($"\n[SceneManager] | Scene '{name}' not found.");
            }
        }

        public static string GetCurrentSceneName()
        {
            return currentSceneName;
        }

        public static void Clear()
        {
            scenes.Clear();
        }
    }
}
