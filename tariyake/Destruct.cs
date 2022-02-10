using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xainp
{
    internal class Destruct
    {
        private string stringtoaobs(string a)
        {
            string text = "";
            byte[] bytes = Encoding.UTF8.GetBytes(a);
            int num = bytes.Count();
            int num2 = 0;
            byte[] array = bytes;
            for (int i = 0; i < array.Length; i++)
            {
                byte b = array[i];
                num2++;
                text = ((!(text == "")) ? ((num2 - 1 != num) ? (text + " 00 " + b.ToString("X")) : (text + " " + b.ToString("X"))) : (text + b.ToString("X")));
            }
            return text;
        }

        public async void destruct(bool clearPrefetch, bool clearStrings, bool USNJournal)
        {
            if (clearStrings) await Task.Run(delegate { clearStringMemory(); });
            if (clearPrefetch) await Task.Run(delegate { clearPrefetchVoid(); });
            if (USNJournal) await Task.Run(delegate { clearUSNJournal(); });
            Environment.Exit(4);
        }

        private async void clearStringMemory()
        {
            int dpsprocid = dpsprocessid();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if ((!process.ProcessName.Equals("explorer") && !process.ProcessName.Equals("javaw") && !process.ProcessName.Equals("SearchIndexer") && !process.ProcessName.Equals("svchost")) || (process.ProcessName == "svchost" && process.Id != dpsprocid))
                {
                    continue;
                }
                switch (process.ProcessName)
                {
                    case "javaw":
                        min = 15000000L;
                        max = 30000000L;
                        break;
                    case "explorer":
                        min = 10000000L;
                        max = 450000000L;
                        break;
                    case "SearchIndexer":
                        min = 1366816000000L;
                        max = 1369000000000L;
                        break;
                    case "svchost":
                        min = 272465000000L;
                        max = 2724680000000L;
                        break;
                }
                M.OpenProcess(process.ProcessName);
                if (process.ProcessName.Equals("explorer"))
                {
                    strings = await M.AoBScan(min, 450000000L, "64 00 6f 00 77 00 20 00 28 00 41 00 78 00 65 00 6e 00 74 00 61 00 2e 00 65 00 78 00 65 00 29", true, true, "");
                    foreach (long a4 in strings)
                    {
                        await Task.Run(delegate
                        {
                            M.WriteBytes(a4.ToString("X"), replace, "");
                        });
                    }
                    strings = await M.AoBScan(min, max, stringtoaobs("TRACE,0000,0000,PcaClient,MonitorProcess," + Application.ExecutablePath + ",Time,0"), true, true, "");
                    foreach (long a3 in strings)
                    {
                        await Task.Run(delegate
                        {
                            M.WriteBytes(a3.ToString("X"), replace2, "");
                        });
                    }
                }
                strings = await M.AoBScan(min, max, "41 78 65 6e 74 61", true, true, "");
                foreach (long a2 in strings)
                {
                    await Task.Run(delegate
                    {
                        M.WriteBytes(a2.ToString("X"), replace, "");
                    });
                }
                strings = await M.AoBScan(min, max, stringtoaobs("Xain"), true, true, "");
                foreach (long a in strings)
                {
                    await Task.Run(delegate
                    {
                        M.WriteBytes(a.ToString("X"), replace, "");
                    });
                }
            }
        }

        private int dpsprocessid()
        {
            ManagementObject managementObject = new ManagementObject("Win32_Service.Name='DPS'"); managementObject.Get();
            return Convert.ToInt32(managementObject["ProcessId"]);
        }

        private void clearPrefetchVoid()
        {
            new DirectoryInfo("C:\\windows\\prefetch");
            new List<string>(Directory.GetFiles("C:\\windows\\prefetch")).ForEach(delegate (string file)
            {
                if (file.IndexOf(Process.GetCurrentProcess().ProcessName, StringComparison.OrdinalIgnoreCase) >= 0) File.Delete(file);
            });
        }

        private void clearUSNJournal()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe",
                Arguments = "fsutil usn deletejournal /D C:",
                WindowStyle = ProcessWindowStyle.Hidden,
                Verb = "runas"
            });
        }

        private readonly Mem M = new Mem();
        private readonly byte[] replace = new byte[8];
        private readonly byte[] replace2 = new byte[57];
        private IEnumerable<long> strings;
        private long min;
        private long max;
    }
}
