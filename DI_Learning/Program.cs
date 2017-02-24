using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Now we have two separate implementations which log messages in very different ways, but both implement ILogger, 
            ///which means that either one can be used where an instance of ILogger is required.
            ///Now we can create an instance of Animal and have it use one of our loggers:

            ILogger txtlogger = new TextFileLogger();
            Animal textanimal = new Animal(txtlogger);


            ILogger csllogger = new ConsoleLogger();
            Animal cslanimal = new Animal(csllogger);


        }
    }
}
