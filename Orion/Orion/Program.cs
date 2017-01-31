using System;
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Orion
{
    class Program
    {
        static int swunt = 1;
        static Thread checkerThread = null;
        static StreamWriter sw;
        static double defaulthp, health;

        static System.Media.SoundPlayer notarget, revive, noammo, itemlowcondition, itemdestroyed;
        static Random rnd = new Random();

        static String next, weap, sweat, loot, auto;
        static String chatpath, temppath, datapath;

        public static void Initializer()
        {
            try
            {
                XDocument xdoc = XDocument.Load("config.xml");
                next = xdoc.Descendants("NextTarget").First().Value;
                weap = xdoc.Descendants("SwitchWeapon").First().Value;
                sweat = xdoc.Descendants("SwitchSweat").First().Value;
                loot = xdoc.Descendants("Loot").First().Value;
                auto = xdoc.Descendants("AutoUse").First().Value;

                defaulthp = double.Parse(xdoc.Descendants("Health").First().Value);
                swunt = int.Parse(xdoc.Descendants("Swunt").First().Value);

                notarget = new System.Media.SoundPlayer(@xdoc.Descendants("NoTarget").First().Value);
                revive = new System.Media.SoundPlayer(@xdoc.Descendants("Revive").First().Value);
                noammo = new System.Media.SoundPlayer(@xdoc.Descendants("NoAmmo").First().Value);
                itemlowcondition = new System.Media.SoundPlayer(@xdoc.Descendants("LowCondition").First().Value);
                itemdestroyed = new System.Media.SoundPlayer(@xdoc.Descendants("Destroyed").First().Value);

                chatpath = xdoc.Descendants("PathToChatLog").First().Value;
                temppath = xdoc.Descendants("PathToTempLog").First().Value;
                datapath = xdoc.Descendants("PathToDataLog").First().Value;

                health = defaulthp;

                sw = new StreamWriter(datapath, true);
            }
            catch (System.Xml.XmlException)
            {
                Console.WriteLine("Error in Config File!");
                Thread.Sleep(1000);
            }
        }

        public static void Checker()
        {
            long pre = new System.IO.FileInfo(chatpath).Length;
            long pro = pre;
            while (true)
            {
                pro = new System.IO.FileInfo(chatpath).Length;
                if (pro > pre)
                {
                    pre = pro;
                    Updater();
                }
                Thread.Sleep(5);
            }
        }

        public static void Updater()
        {
            String info, sinfo;

            try
            {
                File.Copy(chatpath, temppath);
                sinfo = File.ReadLines(temppath).Skip(File.ReadLines(temppath).Count() - 1).Take(1).First();
                info = sinfo.Substring(20, sinfo.Length - 20);
                Operator(info);
                File.Delete(temppath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not Found!");
            }
        }

        public static void Operator(String info)
        {
            if (info.Contains("[System]"))
            {
                rnd = new Random();

                sw.WriteLine(info);

                if (info.Contains("No target") || info.Contains("interaction"))
                {
                    Thread.Sleep(rnd.Next(750, 1250));
                    KeySim.KeySim.StringToKey(auto);
                    notarget.Play();
                }
                else if (info.Contains("not acquire"))
                {
                    Thread.Sleep(rnd.Next(750, 1250));
                    KeySim.KeySim.StringToKey(weap);
                }
                else if (info.Contains("You inflicted"))
                {
                    double damage = 0;

                    Regex regexpattern = new Regex(@"(([0-9]\.*)*[0-9])");
                    foreach (Match match in regexpattern.Matches(info))
                    {
                        String num = match.Groups[1].Value;
                        damage = double.Parse(num);
                    }
                    health -= damage;
                    if (health < 0)
                    {
                        health = defaulthp;
                        Thread.Sleep(rnd.Next(1000, 1250));
                        KeySim.KeySim.StringToKey(auto);
                        Thread.Sleep(rnd.Next(1000, 1250));
                        KeySim.KeySim.StringToKey(loot);
                        if (swunt == 1)
                        {
                            Thread.Sleep(rnd.Next(1500, 2000));
                            KeySim.KeySim.StringToKey(sweat);
                        }
                        Thread.Sleep(rnd.Next(1000, 1250));
                        KeySim.KeySim.StringToKey(next);
                    }
                }
                else if (info.Contains("revived"))
                {
                    revive.Play();
                }
                else if (info.Contains("carried"))
                {
                    noammo.Play();
                }
                else if (info.Contains("minimum condition"))
                {
                    itemlowcondition.Play();
                }
                else if (info.Contains("damaged"))
                {
                    itemdestroyed.Play();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------//

        static void Main(string[] args)
        {
            Initializer();
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            Console.Clear();
            for (int i = 5; i > 0; i--)
            {
                Console.Write("{0} ", i);
                Thread.Sleep(1000);
            }
            ThreadStart checkerRef = new ThreadStart(Checker);
            checkerThread = new Thread(checkerRef);
            checkerThread.Start();

            Thread.Sleep(rnd.Next(750,1250));
            KeySim.KeySim.StringToKey(sweat);

            Thread.Sleep(rnd.Next(750, 1250));
            KeySim.KeySim.StringToKey(next);

            Thread.Sleep(rnd.Next(750, 1250));
            KeySim.KeySim.StringToKey(auto);

            do
            {
                Thread.Sleep(1000);
            } while (true);
        }
    }
}
