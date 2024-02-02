using Microsoft.Extensions.Options;
using Module2.config;
using Module2.Enum;
using Module2.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Services
{
    public class LogService:ILogService
    {
        private readonly LogOption _logOption;
        private readonly List<string> _logs;

        public LogService(IOptions<LogOption> logOption)
        {
            _logOption =logOption.Value;
            _logs = new List<string>();
        }
        public void Log(LogType logType, string message) 
        {
            var log = $"{DateTime.UtcNow}:{nameof(logType)}:{message}";
            _logs.Add(log);
            Console.WriteLine(log);
            try 
            {
                using (var writer = File.AppendText(_logOption.Path))
                {
                    writer.Write(log);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log: {ex.Message}");
            }
        }
    }
}
