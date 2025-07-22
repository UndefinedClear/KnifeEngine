using SFML.System;

namespace KnifeEngine.Engine
{
    public static class Timedelta
    {
        //private static List<ObjectSprite> scenes = new List<ObjectSprite>();

        /// <summary>
        /// Make a Clock, than write it into var with type: SFML.System.Clock<br></br>
        /// Than use Timedelta.Time(your_var);<br></br>
        /// Like here:<br></br>
        /// float deltaTime = Timedelta.Time(your_var);
        /// </summary>
        /// <returns>SFML.System.Clock</returns>
        public static Clock MkClock()
        {
            Clock clock = new Clock();
            return clock;
        }

        public static float Time(Clock clock)
        {
            float deltaTime = clock.Restart().AsSeconds();
            return deltaTime;
        }
    }
}
