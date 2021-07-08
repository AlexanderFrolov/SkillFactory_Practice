using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SF_mod10_interface
{
    class Worker1 : Logger.IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker1 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker1 закончил свою работу");
        }
    }

    class Worker2 : Logger.IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker2 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker2 закончил свою работу");
        }
    }


    class Worker3 : Logger.IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker3 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker3 закончил свою работу");
        }
    }


}
