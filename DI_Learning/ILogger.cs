using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Learning
{
    /// <summary>
    /// Notice that nothing about this interface describes how the message is logged and where it is logged to;
    /// it simply has the intention of recording a string to some repository. Next, lets create something which uses this interface. 
    /// Say we create a class which watches a particular directory on disk, and logs a message whenever the directory is changed:
    /// </summary>
    public interface ILogger
    {
        void LogMessge(string messgae);
    }
}
