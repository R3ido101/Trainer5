using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer5
{
    class towerScanner
    {
        private static Mem memlib;

        public static List<int> selectedTowers = new List<int>();
        public static List<int> hoveredTowers = new List<int>();
        public static List<int> allTowers = new List<int>();

        public static List<int> hoveredCache = new List<int>();

        static BackgroundWorker scanWorker = new BackgroundWorker();
        static BackgroundWorker cacheWorker = new BackgroundWorker();
        static BackgroundWorker cacheResetWorker = new BackgroundWorker();

        public static void startScanners(Mem lib)
        {
            memlib = lib;
            scanWorker.DoWork += scan;
            if(!scanWorker.IsBusy)
            {
                scanWorker.RunWorkerAsync();
            }
            cacheWorker.DoWork += cache;
            if (!cacheWorker.IsBusy)
            {
                cacheWorker.RunWorkerAsync();
            }
            cacheResetWorker.DoWork += resetCache;
            if (!cacheResetWorker.IsBusy)
            {
                cacheResetWorker.RunWorkerAsync();
            }
        }

        private static void cache(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (hoveredTowers.Count > 0)
                {
                    foreach (int cacheTower in hoveredTowers)
                    {
                        if (!hoveredCache.Contains(cacheTower))
                        {
                            hoveredCache.Add(cacheTower);
                        }
                    }
                }
            }
        }
        private static void resetCache(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(100000);
                hoveredCache = hoveredTowers;
            }
        }

        public static int getHoveredTower()
        {
            if(hoveredCache.Count > 0)
            {
                foreach (int tower in hoveredCache)
                {
                    int hoverCheck = tower + 0x215;
                    if (memlib.readByte(hoverCheck.ToString("X")) > 0)
                    {
                        return tower;
                    }
                }
            }
            return 0;
        }

        private static void scan(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                List<long> scanResult = memlib.AoBScan("0? 01 00 01 01 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ??", true, true).Result.ToList();
                List<int> towerResult = new List<int>();
                hoveredTowers = new List<int>();
                selectedTowers = new List<int>();
                foreach (long result in scanResult)
                {
                    try
                    {
                        int baseV = (int)result & int.MaxValue;
                        string hexS = baseV.ToString("X");
                        int hexI = int.Parse(hexS, System.Globalization.NumberStyles.HexNumber);
                        hexI -= 0xF0;
                        int soldCheck = hexI + 0x12C;
                        if (memlib.readByte(soldCheck.ToString("X")) < 1)
                        {
                            towerResult.Add(hexI);
                            int hoverCheck = hexI + 0x215;
                            int selectedCheck = hexI + 0xF0;
                            if (memlib.readByte(hoverCheck.ToString("X")) > 0)
                            {
                                hoveredTowers.Add(hexI);
                            }
                            if (memlib.readByte(selectedCheck.ToString("X")) > 0)
                            {
                                selectedTowers.Add(hexI);
                            }
                        }
                    }
                    catch (OverflowException) { }
                }
                allTowers = towerResult;
            }
        }
    }
}
