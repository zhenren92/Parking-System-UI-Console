using System;
using System.Collections.Generic;
using Parking_System_UI.Models.Command;
using Parking_System_UI.Models;

namespace Parking_System_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute_Command(args);
        }

        static public async void Execute_Command(string[] args)
        {
            Command_Console Command = new Command_Console();
            List<Command_Console> Help_Command = new List<Command_Console>();
            Help_Command = await Command.Help_Command() as List<Command_Console>;

            bool Quit_Now = false;
            
            while (!Quit_Now)
            {
                args = Console.ReadLine().Split(" ");
                bool Status_Find_Command = false;

                if (args != null)
                {
                    if (Help_Command.Count != 0)
                    {
                        foreach (var arg in args)
                        {
                            if (Status_Find_Command == false)
                            {
                                if (Help_Command.Exists(x => x.Command.ToLower() == arg.ToLower()))
                                {
                                    Command_Console Temp_Command = new Command_Console();
                                    Temp_Command = Help_Command.Find(x => x.Command.ToLower() == arg.ToLower());

                                    if (Temp_Command.Command.ToLower() == "Buat_Ruangan_Parkir".ToLower())
                                    {
                                        Console.WriteLine(await Command.Buat_Ruangan_Parkir(0, args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Kendaraan_Masuk".ToLower())
                                    {
                                        Console.WriteLine(await Command.Kendaraan_Masuk(new Kendaraan(), args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Kendaraan_Keluar".ToLower())
                                    {
                                        Console.WriteLine(await Command.Kendaraan_Keluar(new int(), args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Kendaraan_Parkir_Berdasarkan_No_Polisi".ToLower())
                                    {
                                        Console.WriteLine(await Command.Kendaraan_Parkir_Berdasarkan_No_Polisi(null, args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Kendaraan_Parkir_Berdasarkan_Warna".ToLower())
                                    {
                                        Console.WriteLine(await Command.Kendaraan_Parkir_Berdasarkan_Warna(null, args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Status_Ruangan_Parkir".ToLower())
                                    {
                                        Console.WriteLine(await Command.Status_Ruangan_Parkir(args));
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Tampil_Aktifitas_Kendaraan_Keluar".ToLower())
                                    {
                                        Console.WriteLine(await Command.Tampil_Aktifitas_Kendaraan_Keluar());
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Tampil_Aktifitas_Kendaraan_Masuk".ToLower())
                                    {
                                        Console.WriteLine(await Command.Tampil_Aktifitas_Kendaraan_Masuk());
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Tampil_Aktifitas_Kendaraan_Masuk_Keluar".ToLower())
                                    {
                                        Console.WriteLine(await Command.Tampil_Aktifitas_Kendaraan_Masuk_Keluar());
                                        Status_Find_Command = true;
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Help".ToLower())
                                    {
                                        Console.WriteLine(await Command.Show_Help_Command(Help_Command));
                                        break;                                        
                                    }
                                    else if (Temp_Command.Command.ToLower() == "Exit".ToLower())
                                    {
                                        Quit_Now = true;
                                        break;                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Command "+ arg +" tidak diketahui \n");
                                    break;                                    
                                }
                            }
                            else
                            {
                                break;
                            }                            
                        }
                    }
                }
            }
        }
    }
}
