using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Meadow;
using Meadow.Devices;
using Meadow.Hardware;
using Meadow.Logging;

namespace MeadowCloudProject
{
    public class MeadowApp : App<F7CoreComputeV2>
    {
        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            var cloudLogger = new CloudLogger();

            Resolver.Log.AddProvider(cloudLogger);

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            Resolver.Log.Info("Hello, Meadow Core-Compute!");

            while (true)
            {
                Thread.Sleep(1000);
            }

            return Task.CompletedTask;
        }
    }
}