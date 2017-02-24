using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DI_Learning
{
    /// <summary>
    ///  uses ILogger interface a class  logs a message 
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// The key thing to notice is that the constructor, we require that something which implements ILogger is given to us,
        /// but again notice that we don't care about where the log goes or how it is created.
        /// We can just program against the interface and not worry about it.
        /// This means that in order to create an instance of our Animal we must also
        /// have an implementation of ILogger ready. 
        /// </summary>
        private ILogger _logger;
        public Animal(ILogger logger)
        {
            _logger = logger;
            _logger.LogMessge("I am Animal");

        }


    }

    /// <summary>
    /// logs messages to a text file
    /// </summary>
    public class TextFileLogger: ILogger
    {
        public void LogMessge(string message)
        {
            using (FileStream stream = new FileStream("C:\\log.txt", FileMode.Append))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(message);
                writer.Flush();
            }
        }

    }

    /// <summary>
    /// logs messages to a console
    /// </summary>
    public class ConsoleLogger: ILogger
    {
        public void LogMessge(string message)
        {
            Console.WriteLine(message);
        }

    }




}
