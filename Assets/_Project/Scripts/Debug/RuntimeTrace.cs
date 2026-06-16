using UnityEngine;
using System;
using System.IO;

namespace TheBonwater.Rebuild.Diagnostics
{
    public static class RuntimeTrace
    {
        private static string logFilePath = Path.Combine(Application.dataPath, "../Logs/runtime_backend_trace.log");

        public static void Log(string category, string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string frame = Time.frameCount.ToString();
            string logLine = $"[{timestamp}] [{frame}] [{category}] {message}";

            // Console output for Unity Editor
            UnityEngine.Debug.Log(logLine);

            // File output for persistent tracing
            int retries = 3;
            while (retries > 0)
            {
                try
                {
                    File.AppendAllText(logFilePath, logLine + Environment.NewLine);
                    break;
                }
                catch (IOException)
                {
                    retries--;
                    System.Threading.Thread.Sleep(50);
                    if (retries == 0)
                    {
                        try { File.AppendAllText(logFilePath + ".fallback", logLine + Environment.NewLine); } catch { }
                    }
                }
                catch (Exception ex)
                {
                    UnityEngine.Debug.LogError($"[RUNTIME_TRACE_ERROR] Failed to write to log file: {ex.Message}");
                    break;
                }
            }
        }

        public static void ClearLog()
        {
            try
            {
                if (File.Exists(logFilePath))
                {
                    File.WriteAllText(logFilePath, $"--- Trace cleared at {DateTime.Now} ---\n");
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[RUNTIME_TRACE_ERROR] Failed to clear log file: {ex.Message}");
            }
        }

        public static void Clear() => ClearLog();

        public static System.Collections.Generic.List<string> GetLogs()
        {
            var logs = new System.Collections.Generic.List<string>();
            try
            {
                if (File.Exists(logFilePath))
                {
                    using (var fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var sr = new StreamReader(fs))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            logs.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[RUNTIME_TRACE_ERROR] Failed to read log file: {ex.Message}");
            }
            return logs;
        }
    }
}
