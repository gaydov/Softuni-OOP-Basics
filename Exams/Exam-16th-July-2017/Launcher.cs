using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_16th_July_2017
{
    public class Launcher
    {
        public static void Main()
        {
            CommandInterpreter engine = new CommandInterpreter();
            engine.TryExecuteCommand();
        }
    }
}
