using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Parking_System_UI.Interface;
using static Parking_System_UI.Helper.Helper;

namespace Parking_System_UI.Models.Command
{
    public class Command_Console : ICommand_Console
    {
        #region "Deklarasi Properties"
            public string Command { get; set; }
            public string Keterangan_Command {get; set;}
            public List<Command_Parameter> Daftar_Command_Parameter { get; set; }

        #endregion

        #region Deklarasi Method

        public async Task<object> Buat_Ruangan_Parkir(int Banyak_Slot, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Buat_Ruangan_Parkir", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                    if (Daftar_Parameter_Filter.Count != 0)
                    {

                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--Slot".ToLower()) || (value.Key.ToLower() == "--s".ToLower()))
                                {
                                    Banyak_Slot = (int) int.Parse((value.Value != "" ? value.Value : "0"));
                                }
                            }
                    }

                    obj = await Get_Data("Buat_Ruangan_Parkir?BanyakSlot=" + Banyak_Slot);
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Kendaraan_Masuk(Kendaraan kendaraan, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Kendaraan_Masuk", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    if ((obj as Dictionary<string,string>).Count != 0)
                    {
                        Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                        if (Daftar_Parameter_Filter.Count != 0)
                        {
                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--No_Polisi".ToLower()) || (value.Key.ToLower() == "--NP".ToLower()))
                                {
                                    kendaraan.No_Polisi = value.Value;
                                }
                                else if ((value.Key.ToLower() == "--Warna".ToLower()) || (value.Key.ToLower() == "--W".ToLower()))
                                {
                                    kendaraan.Warna = value.Value;
                                }
                            }

                            obj = await Post_Data("Kendaraan_Masuk", kendaraan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Kendaraan_Keluar(int No_Slot, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Kendaraan_Keluar", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    if ((obj as Dictionary<string,string>).Count != 0)
                    {
                        Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                        if (Daftar_Parameter_Filter.Count != 0)
                        {
                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--Slot".ToLower()) || (value.Key.ToLower() == "--s".ToLower()))
                                {
                                    No_Slot = (int) int.Parse((value.Value != "" ? value.Value : "0"));
                                }
                            }

                            obj = await Post_Data("Kendaraan_Keluar/"+ No_Slot, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Kendaraan_Parkir_Berdasarkan_No_Polisi(string No_Polisi, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Kendaraan_Parkir_Berdasarkan_No_Polisi", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                    if (Daftar_Parameter_Filter.Count != 0)
                    {

                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--No_Polisi".ToLower()) || (value.Key.ToLower() == "--NP".ToLower()))
                                {
                                    No_Polisi = value.Value;
                                }
                            }
                    }

                    obj = await Get_Data("Kendaraan_Parkir_Berdasarkan_No_Polisi/" + No_Polisi);
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Kendaraan_Parkir_Berdasarkan_Warna(string Warna, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Kendaraan_Parkir_Berdasarkan_Warna", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                    if (Daftar_Parameter_Filter.Count != 0)
                    {

                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--Warna".ToLower()) || (value.Key.ToLower() == "--w".ToLower()))
                                {
                                    Warna = value.Value;
                                }
                            }
                    }

                    obj = await Get_Data("Kendaraan_Parkir_Berdasarkan_Warna/" + Warna);
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Status_Ruangan_Parkir()
        {
            object obj = new object();

            try
            {
                obj = await Get_Data("Status_Ruangan_Parkir");
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Status_Ruangan_Parkir(int Baris_Ruangan, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Status_Ruangan_Parkir", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                    if (Daftar_Parameter_Filter.Count != 0)
                    {

                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--Baris_Ruangan".ToLower()) || (value.Key.ToLower() == "--BR".ToLower()))
                                {
                                    Baris_Ruangan = (int) int.Parse((value.Value != "" ? value.Value : "0"));
                                }
                            }
                    }

                    obj = await Get_Data("Status_Ruangan_Parkir/" + Baris_Ruangan);
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Status_Ruangan_Parkir(int Baris_Ruangan, int Nomor_Slot, string[] args)
        {
            object obj = new object();

            try
            {
                obj = await Filter_Parameter("Status_Ruangan_Parkir", args);

                if (obj.GetType() == typeof(Dictionary<string, string>))
                {
                    Dictionary<string, string> Daftar_Parameter_Filter = obj as Dictionary<string, string>;

                    if (Daftar_Parameter_Filter.Count != 0)
                    {

                            foreach (var value in Daftar_Parameter_Filter)
                            {
                                if ((value.Key.ToLower() == "--Baris_Ruangan".ToLower()) || (value.Key.ToLower() == "--BR".ToLower()))
                                {
                                    Baris_Ruangan = (int) int.Parse((value.Value != "" ? value.Value : "0"));
                                }
                                else if ((value.Key.ToLower() == "--Slot".ToLower()) || (value.Key.ToLower() == "--s".ToLower()))
                                {
                                    Nomor_Slot = (int) int.Parse((value.Value != "" ? value.Value : "0"));
                                }
                            }
                    }

                    obj = await Get_Data("Status_Ruangan_Parkir/" + Baris_Ruangan + "/" + Nomor_Slot);
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Tampil_Aktifitas_Kendaraan_Keluar()
        {
            object obj = new object();

            try
            {
                obj = await Get_Data("Tampil_Aktifitas_Kendaraan_Keluar");
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Tampil_Aktifitas_Kendaraan_Masuk()
        {
            object obj = new object();

            try
            {
                obj = await Get_Data("Tampil_Aktifitas_Kendaraan_Masuk");
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Tampil_Aktifitas_Kendaraan_Masuk_Keluar()
        {
            object obj = new object();

            try
            {
                obj = await Get_Data("Tampil_Aktifitas_Kendaraan_Masuk_Keluar");
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        public async Task<object> Get_Data(string URL_API)
        {
            object obj = new object();

            try
            {
                WebClient client = new ParkirAPI().Initial();
                var res = client.DownloadString(URL_API);

                var result = res;

                obj = JsonConvert.DeserializeObject<object>(result);
            }
            catch (System.Exception ex)
            {
                obj = ex.ToString();
            }

            return obj;
        }
        public async Task<object> Post_Data(string URL_API, object obj_data)
        {
            object obj = new object();

            try
            {
                WebClient client = new ParkirAPI().Initial();
                var res = client.UploadString(URL_API, JsonConvert.SerializeObject(obj_data));

                var result = res;

                obj = JsonConvert.DeserializeObject<object>(result);
            }
            catch (System.Exception ex)
            {
                obj = ex.ToString();
            }

            return obj;
        }
        public async Task<object> Help_Command()
        {
            List<Command_Console> Daftar_Command = new List<Command_Console>();

            Command_Parameter Slot_Ruang_Parkir = new Command_Parameter() 
            {
                Parameter_Alias = "--Slot",
                Parameter_Code = "--s",
                Keterangan_Parameter = "Slot Ruangan Parkir",
                Status_Optional = false
            };

            Command_Parameter No_Polisi_Command_Parameter = new Command_Parameter() 
            {
                Parameter_Alias = "--No_Polisi",
                Parameter_Code = "--NP",
                Keterangan_Parameter = "Nomor Polisi Kendaraan" ,
                Status_Optional = false
            };

            Command_Parameter Warna_Command_Parameter = new Command_Parameter() 
            {
                Parameter_Alias = "--Warna",
                Parameter_Code = "--W",
                Keterangan_Parameter = "Warna Kendaraan",
                Status_Optional = false
            };

            Command_Parameter Help_Command_Parameter = new Command_Parameter() 
            {
                Parameter_Alias = "--Help",
                Parameter_Code = "--h",
                Keterangan_Parameter = "Help",
                Status_Optional = true
            };

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Buat_Ruangan_Parkir" ,
                                    Keterangan_Command = "Membuat ruangan parkir",
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Slot_Ruang_Parkir
                                        } ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Kendaraan_Masuk" ,
                                    Keterangan_Command = "Kendaraan masuk" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            No_Polisi_Command_Parameter
                                        } ,
                                        {
                                            Warna_Command_Parameter
                                        }  ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Kendaraan_Keluar" ,
                                    Keterangan_Command = "Kendaraan keluar" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Slot_Ruang_Parkir
                                        } ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Kendaraan_Parkir_Berdasarkan_No_Polisi" ,
                                    Keterangan_Command = "Kendaraan parkir berdasarkan nomor polisi" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            No_Polisi_Command_Parameter
                                        } ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Kendaraan_Parkir_Berdasarkan_Warna" ,
                                    Keterangan_Command = "Kendaraan parkir berdasarkan warna" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Warna_Command_Parameter
                                        } ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Status_Ruangan_Parkir" ,
                                    Keterangan_Command = "Status ruangan parkir" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            new Command_Parameter 
                                            {
                                                Parameter_Alias = "--Baris_Ruangan" ,
                                                Parameter_Code = "--BR",
                                                Keterangan_Parameter = "Optional : Baris Ruangan Parkir",
                                                Status_Optional = true
                                            }
                                        } ,
                                        {
                                            Slot_Ruang_Parkir
                                        } ,
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Tampil_Aktifitas_Kendaraan_Masuk" ,
                                    Keterangan_Command = "Tampil aktifitas kendaraan masuk" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Tampil_Aktifitas_Kendaraan_Keluar" ,
                                    Keterangan_Command = "Tampil aktifitas kendaraan keluar" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Tampil_Aktifitas_Kendaraan_Masuk_Keluar" ,
                                    Keterangan_Command = "Tampil aktifitas kendaraan masuk dan keluar" ,
                                    Daftar_Command_Parameter = new List<Command_Parameter>()
                                    {
                                        {
                                            Help_Command_Parameter
                                        }                                        
                                    } 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Help",
                                    Keterangan_Command = "Help" 
                                });

            Daftar_Command.Add(new Command_Console 
                                {
                                    Command = "Exit",
                                    Keterangan_Command = "Keluar" 
                                });

            return Daftar_Command;
        }
        public async Task<string> Show_Help_Command(List<Command_Console> Daftar_Command)
        {
            string obj = "";

            try
            {
                if (Daftar_Command != null)
                {
                    obj = "Commands : \n";
                    foreach (var item in Daftar_Command)
                    {
                        obj = obj + "\t" + item.Command + "\t ( " + item.Keterangan_Command + " ) \n";
                    }
                }                
            }
            catch (System.Exception ex)
            {                
                obj = ex.Message.ToString();
            }

            return obj;
        }
        public async Task<string> Show_Help_Command(List<Command_Console> Daftar_Command, string Nama_Command)
        {
            string obj = "";

            try
            {
                if (Daftar_Command != null)
                {
                    foreach (var item in Daftar_Command.FindAll(x => x.Command.ToLower() == Nama_Command.ToLower()))
                    {
                        obj = obj + "Command : " + item.Command + "\t ( " + item.Keterangan_Command + " ) \n";
                        obj = obj + "---------------------------------- \n";
                        obj = obj + "Parameter : \n";

                        if (item.Daftar_Command_Parameter != null)
                        {
                            foreach (var value in item.Daftar_Command_Parameter)
                            {
                                obj = obj + "\t " + value.Parameter_Alias + " , " + value.Parameter_Code + "\t \t ( " + value.Keterangan_Parameter + ") \n";
                            }
                        }

                        obj = obj + " \n";
                    }
                }                
            }
            catch (System.Exception ex)
            {                
                obj = ex.Message.ToString();
            }

            return obj;
        }
        private static async Task<object> Filter_Parameter(string Nama_Command,string[] args)
        {
            object obj = new object();

            try
            {
                List<Command_Console> Daftar_Command = await new Command.Command_Console().Help_Command() as List<Command_Console>;
                List<Command_Parameter> Daftar_Temp_Parameter_Command = Daftar_Command.Find(x => x.Command.ToLower() == Nama_Command.ToLower()).Daftar_Command_Parameter;
                List<string> Daftar_Args_Filter = new List<string>();

                foreach (var item in args)
                {
                    if (item != Nama_Command)
                    {
                        Daftar_Args_Filter.Add(item);
                    }
                }

                if (Daftar_Args_Filter.Count != 0)
                {
                    foreach (var item in Daftar_Args_Filter)
                    {
                        if (Daftar_Temp_Parameter_Command.Exists(x => (x.Parameter_Alias.ToLower() == item.ToLower()) || (x.Parameter_Code.ToLower() == item.ToLower())))
                        {
                            if (Daftar_Args_Filter.Exists(x => (x == "--Help".ToLower()) || (x == "--h".ToLower()) ))
                            {
                                obj = await new Command_Console().Show_Help_Command(Daftar_Command, Nama_Command.ToLower());                                
                            }
                            else
                            {
                                string Combine_Parameter = string.Join(" ", Daftar_Args_Filter);
                                string[] Split_Value_Parameter = Combine_Parameter.Split("--");
                                Dictionary<string, string> Daftar_Parameter_Filter = new Dictionary<string, string>();

                                foreach (var value in Split_Value_Parameter)
                                {
                                    if (value != "")
                                    {
                                        string[] split_value = value.Split(" ");
                                        split_value[0] = "--" + split_value[0];

                                        if (split_value.Length > 1)
                                        {
                                            Daftar_Parameter_Filter.Add(split_value[0],split_value[1].Replace(" ",""));
                                        }
                                        else
                                        {
                                            obj = "Parameter " + split_value[0] + " tidak memiliki nilai";
                                            return obj;
                                        }
                                    }
                                }

                                foreach (var value in Daftar_Temp_Parameter_Command.FindAll(x => (x.Parameter_Alias != "--Help") && (x.Status_Optional == false)))
                                {
                                    if ((Daftar_Parameter_Filter.ContainsKey(value.Parameter_Alias) == false) && (Daftar_Parameter_Filter.ContainsKey(value.Parameter_Code) == false))
                                    {
                                        obj = "Parameter " + value.Parameter_Alias + " tidak ada";
                                        return obj;
                                    }
                                }

                                if (Daftar_Parameter_Filter.Count != 0)
                                {
                                    obj = Daftar_Parameter_Filter;                                    
                                }
                                else
                                {
                                    obj = "Tidak ada parameter yang diinput \n \n" + await new Command_Console().Show_Help_Command(Daftar_Command, Nama_Command.ToLower());
                                }

                                break;
                            }
                        }
                        else
                        {
                            obj = "Parameter " + item + " tidak dikenali \n" + await new Command_Console().Show_Help_Command(Daftar_Command, Nama_Command.ToLower());
                            break;
                        }
                    } 
                }
                else
                {
                    obj = "Tidak ada parameter yang diinput \n \n" + await new Command_Console().Show_Help_Command(Daftar_Command, Nama_Command.ToLower());
                }
            }
            catch (Exception ex)
            {
                obj = ex.Message.ToString();
            }  

            return obj;
        }

        #endregion
    }
}