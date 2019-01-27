# Parking-System-UI-Console

# Requirement Development :

- Visual Studio Code (IDE) : Optional
  (Link : https://code.visualstudio.com/download)
  
- .NET Core 2.0 SDK 64-bit / 32-bit

  (Link [64-bit](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.0.0-windows-x64-binaries) | Required) atau 
  (Alternatif Link [64-bit](https://download.microsoft.com/download/1/B/4/1B4DE605-8378-47A5-B01B-2C79D6C55519/dotnet-sdk-2.0.0-win-x64.zip))
  
  (Link [32-bit](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.0.0-windows-x86-binaries)) atau 
  (Alternatif Link [32-bit](https://download.microsoft.com/download/1/B/4/1B4DE605-8378-47A5-B01B-2C79D6C55519/dotnet-sdk-2.0.0-win-x86.zip))
  
# Requirement Runtime :
 
- .NET Core 2.0 Runtime 64-bit / 32-bit

  (Link [64-bit](https://dotnet.microsoft.com/download/thank-you/dotnet-runtime-2.0.0-windows-x64-binaries)) atau 
  (Alternatif Link [64-bit](https://download.microsoft.com/download/5/F/0/5F0362BD-7D0A-4A9D-9BF9-022C6B15B04D/dotnet-runtime-2.0.0-win-x64.zip))
  
  (Link [32-bit](https://dotnet.microsoft.com/download/thank-you/dotnet-runtime-2.0.0-windows-x86-binaries)) atau
  (Alternatif Link [32-bit](https://download.microsoft.com/download/5/F/0/5F0362BD-7D0A-4A9D-9BF9-022C6B15B04D/dotnet-runtime-2.0.0-win-x86.zip))
  
# Setting Environment (Hanya untuk OS Windows) :
 
- Klik Kanan pada "My Computer" --> "Properties"
- Klik "Advanced system settings" --> Pilih "Tab Advanced" --> Klik "Environment Variables"
- Pilih "Path" pada "System variables" --> Tekan "Edit"
- Tambahkan "Lokasi folder" yang mengarah ke .NET Core 2.0 yang sudah di download sebelumnya, contoh 
lokasi folder "C:\\.NET Core\dotnet-sdk-2.0.0-win-x64;"
- Kemudian Tekan "Ok" sampai selesai.

# Uji coba .NET Core 2.0

- Buka "Command Prompt" atau "cmd.exe"
- Kemudian Ketik "dotnet --version", maka output yang akan ditampilkan adalah "2.0.0"

# Uji coba Project "Parking-System-UI-Console"

- Pastikan anda sudah menjalankan Parking-System-API 
  (Link : https://github.com/zhenren92/Parking-System-API)
  
- Clone atau Download Project "Parking-System-UI-Console"
- Extract Project jika project di download berupa file ".zip", contoh di extract ke "D:\\Parking-System-UI-Console\"
- Buka "Command Prompt" atau "cmd.exe"
- Masuk ke lokasi folder yang didalamnya memiliki file "Parking-System-API.csproj", contoh di "D:\\Parking-System-UI-Console\" dengan cara mengetik "cd D:\\Parking-System-UI-Console\" dan kemudian ketik "D:"

- 1). ketikkan "dotnet restore" pada "Command Prompt" atau "cmd.exe"
- 2). ketikkan "dotnet build" pada "Command Prompt" atau "cmd.exe"
- 3). ketikkan "dotnet run" pada "Command Prompt" atau "cmd.exe"
- 4). ketikkan "Help" pada "Command Prompt" atau "cmd.exe", maka akan menampilkan daftar command yang bisa digunakan.

# Command yang disediakan

 1). Daftar Command
-
  - 1.1). Command Membuat ruangan parkir : 
    -
    - Command : Buat_Ruangan_Parkir --{Parameter} {Value}
    - Command (Contoh) : Buat_Ruangan_Parkir --Slot 5
    
  - 1.2). Parameter Command : 
    -
    - --Slot , --S            ( Slot Ruangan Parkir )
    - --Help , --H            ( Help )

  - 2.1). Command Kendaraan Masuk : 
    -
    - Command : Kendaraan_Masuk --{Parameter} {Value}
    - Command (Contoh) : Kendaraan_Masuk --No_Polisi BG-12345-AA --Warna Merah
    
  - 2.2). Parameter Command : 
    -
    - --No_Polisi , --NP      ( Nomor Polisi Kendaraan )
    - --Warna , --W           ( Warna Kendaraan )
    - --Help , --H            ( Help )

  - 3.1). Command Kendaraan Keluar : 
    -
    - Command : Kendaraan_Keluar --{Parameter} {Value}
    - Command (Contoh) : Kendaraan_Keluar --Slot 5
    
  - 3.2). Parameter Command : 
    -
    - --Slot , --S            ( Slot Ruangan Parkir )
    - --Help , --H            ( Help )

  - 4.1). Command Kendaraan Parkir Berdasarkan No Polisi : 
    -
    - Command : Kendaraan_Parkir_Berdasarkan_No_Polisi --{Parameter} {Value}
    - Command (Contoh) : Kendaraan_Parkir_Berdasarkan_No_Polisi --No_Polisi BG-12345-AA
    
  - 4.2). Parameter Command : 
    -
    - --No_Polisi , --NP      ( Nomor Polisi Kendaraan )
    - --Help , --H            ( Help )

  - 5.1). Command Kendaraan Parkir Berdasarkan Warna : 
    -
    - Command : Kendaraan_Parkir_Berdasarkan_Warna --{Parameter} {Value}
    - Command (Contoh) : Kendaraan_Parkir_Berdasarkan_Warna --Warna Merah
    
  - 5.2). Parameter Command : 
    -
    - --Warna , --W      ( Warna Kendaraan )
    - --Help , --H       ( Help )

  - 6.1). Command Status Ruangan Parkir : 
    -
    - Command : Status_Ruangan_Parkir --{Parameter} {Value}
    - Command (Contoh) : Status_Ruangan_Parkir --Warna Merah
    
  - 6.2). Parameter Command : 
    -
    - --Baris_Ruangan , --BR          ( Optional : Baris Ruangan Parkir )
    - --Slot , --S                    ( Optional : Slot Ruangan Parkir )
    - --Help , --H                    ( Help )
    
  - 7). Command Tampil Aktifitas Kendaraan Masuk : 
    -
    - Command : Tampil_Aktifitas_Kendaraan_Masuk
    - Command (Contoh) : Tampil_Aktifitas_Kendaraan_Masuk

  - 8). Command Tampil Aktifitas Kendaraan Keluar : 
    -
    - Command : Tampil_Aktifitas_Kendaraan_Keluar
    - Command (Contoh) : Tampil_Aktifitas_Kendaraan_Keluar

  - 9). Command Tampil Aktifitas Kendaraan Masuk dan Keluar : 
    -
    - Command : Tampil_Aktifitas_Kendaraan_Masuk_Keluar
    - Command (Contoh) : Tampil_Aktifitas_Kendaraan_Masuk_Keluar
    
