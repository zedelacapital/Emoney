using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Gelf.Extensions.Logging;
using System.Net;


namespace Emoney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (Environment.GetEnvironmentVariable("") != null && Environment.GetEnvironmentVariable("") == "")
            {
                ConfigManager.OverrideDefaultConfigPath("");
            }
            if (Environment.GetEnvironmentVariable("INTEGRATION_LABEL") == null)
            {
                Environment.SetEnvironmentVariable("INTEGRATION_LABEL", "emoney");
            }
            CreateWebHostBuilder(args).Build().Run();
        }
        }
    }
}
