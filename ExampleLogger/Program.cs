    using System;
    using System.IO;
    using NLog;
    using NLog.Conditions;
    using NLog.Config;
    using NLog.Layouts;
    using NLog.Targets;

namespace ExampleLogger
{
    internal class Program
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            MyLogger();
            Random Rand = new Random();
            int i = 1;
            for (i = 1; i < 100; i++)
            {
                int n = Rand.Next(1, 4);
                switch (n)
                {
                    case 1:
                        Logger.Info("Start method");
                        break;
                    case 2:
                        Logger.Warn("Skipped logic in method");
                        break;
                    case 3:
                        Logger.Error("Acion failed by a reason");
                        break;
                }
            }
        }
        static void MyLogger()
        { 
            var config = new NLog.Config.LoggingConfiguration();
            LogManager.Configuration = new LoggingConfiguration();
            const string LayoutFile = @"${date:format=yyyy-MM-dd HH\:mm\:ss}|${uppercase: ${level}}|${message} ${exception: format=ToString}";
            var consoleTarget = new ColoredConsoleTarget("Console Target")
            {
                Layout = @"${counter}|${date:format=yyyy-MM-dd HH\:mm\:ss}|${uppercase: ${level}}|${message} ${exception: format=ToString}"
            };

            var logfile = new FileTarget();

            if (!Directory.Exists("logs"))
                Directory.CreateDirectory("logs");

            // Rules for mapping loggers to targets
            config.AddRule(LogLevel.Info, LogLevel.Error, logfile);
            config.AddRule(LogLevel.Info, LogLevel.Error, consoleTarget);

            logfile.CreateDirs = true;
            logfile.FileName = $"logs{Path.DirectorySeparatorChar}lastlog.log";
            logfile.AutoFlush = true;
            logfile.LineEnding = LineEndingMode.CRLF;
            logfile.Layout = LayoutFile;
            logfile.FileNameKind = FilePathKind.Absolute;
            logfile.ConcurrentWrites = false;
            logfile.KeepFileOpen = true;
            //color
            var Info = new ConsoleRowHighlightingRule();
            Info.Condition = ConditionParser.ParseExpression("level == LogLevel.Info");
            Info.ForegroundColor = ConsoleOutputColor.Green;
            consoleTarget.RowHighlightingRules.Add(Info);
            var Warn = new ConsoleRowHighlightingRule();
            Warn.Condition = ConditionParser.ParseExpression("level == LogLevel.Warn");
            Warn.ForegroundColor = ConsoleOutputColor.DarkYellow;
            consoleTarget.RowHighlightingRules.Add(Warn);
            var Error = new ConsoleRowHighlightingRule();
            Error.Condition = ConditionParser.ParseExpression("level == LogLevel.Error");
            Error.ForegroundColor = ConsoleOutputColor.DarkRed;
            consoleTarget.RowHighlightingRules.Add(Error);
            NLog.LogManager.Configuration = config;
        }
    }
}