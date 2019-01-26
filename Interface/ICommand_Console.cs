using System.Collections.Generic;
using System.Threading.Tasks;
using Parking_System_UI.Models;
using Parking_System_UI.Models.Command;

namespace Parking_System_UI.Interface
{
    public interface ICommand_Console
    {
        Task<object> Buat_Ruangan_Parkir(int Banyak_Slot, string[] args);
        Task<object> Kendaraan_Masuk(Kendaraan kendaraan, string[] args);
        Task<object> Kendaraan_Keluar(int No_Slot, string[] args);
        Task<object> Kendaraan_Parkir_Berdasarkan_No_Polisi(string No_Polisi, string[] args);
        Task<object> Kendaraan_Parkir_Berdasarkan_Warna(string Warna, string[] args);
        Task<object> Status_Ruangan_Parkir(string[] args);
        Task<object> Status_Ruangan_Parkir(int Baris_Ruangan, string[] args);
        Task<object> Status_Ruangan_Parkir(int Baris_Ruangan, int Nomor_Slot, string[] args);
        Task<object> Tampil_Aktifitas_Kendaraan_Keluar();
        Task<object> Tampil_Aktifitas_Kendaraan_Masuk();
        Task<object> Tampil_Aktifitas_Kendaraan_Masuk_Keluar();
        Task<object> Get_Data(string URL_API);
        Task<object> Post_Data(string URL_API,object obj_data);
        Task<object> Help_Command();
        Task<string> Show_Help_Command(List<Command_Console> Daftar_Command);
        Task<string> Show_Help_Command(List<Command_Console> Daftar_Command, string Nama_Command);
    }
}