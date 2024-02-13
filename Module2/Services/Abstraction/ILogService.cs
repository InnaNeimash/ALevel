using Microsoft.Extensions.Options;
using Module2.config;
using Module2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Services.Abstraction
{
    interface ILogService
    {
        public void Log(LogType logType, string message);
    }
}
