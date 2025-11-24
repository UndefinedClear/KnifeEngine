using System;


namespace KnifeEngine.Engine
{
    public class Logger
    {
        private string log_path = "";

        /// <summary>
        /// Logger makes log file in specified path that will contain logs with time info and level of log (e.g. INFO, ERROR, WARNING, DEBUG)
        /// </summary>
        /// <param name="_log_path"></param>
        public Logger(string directory, string _log_path)
        {
            Random rand = new Random();

            if (!directory.EndsWith("/"))
            {
                directory += "/";
            }

            DateTime now = DateTime.Now;
            string time_segment_of_file = @$"{rand.Next(10000, 99999)}_{now.Hour.ToString()}_{now.Minute.ToString()}_{now.Second.ToString()}".Replace('.', '_');

            log_path = directory + _log_path + "_" + time_segment_of_file + ".log";

            if (!Directory.Exists(directory))
            {
                // Create new directory
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(log_path))
            {
                // Create new file
                File.Create(log_path).Close();
            }
        }

        public void Info(string from, string message)
        {
            LogWrite(from, message, "INFO");
        }

        public void Error(string from, string message)
        {
            LogWrite(from, message, "ERROR");
        }

        public void Warning(string from, string message)
        {
            LogWrite(from, message, "WARNING");
        }

        public void Debug(string from, string message)
        {
            LogWrite(from, message, "DEBUG");
        }

        private void LogWrite(string root, string message, string level)
        {
            DateTime _now = DateTime.Now;
            string time_segment_current_log = @$"{_now.Hour.ToString()}:{_now.Minute.ToString()}:{_now.Second.ToString()}";

            File.AppendAllText(log_path, $@"FROM: [${root}] | [{level}] : ${message}" + "\n");
            Console.WriteLine($@"FROM: [${root}] | [{level}] : ${message}");
        }
    }
}
