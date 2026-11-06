using UTSPBO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("       SISTEM MANAJEMEN MAFIA GALON");
        Console.WriteLine("======================================");

        Agen agen1 = new Agen(
            "A001", "Agen Metropolis", 50
        );

        Agen agen2 = new Agen(
            "A002", "Agen Pusat Kota", 30
        );

        Console.WriteLine("\n=== DATA AGEN ===");

        agen1.TampilInfo();

        Console.WriteLine();

        agen2.TampilInfo();

        GalonAkua akua = new GalonAkua(
            "P001", "Galon Akua", 200
        );

        GalonBerkeran berkeran = (
            "P002", "Galon Berkeran", 150, "Keran Putar"
        );

        ProdukGalon produk1 = akua;
        ProdukGalon produk2 = berkeran;

        Console.WriteLine("\n=== DAFTAR PRODUK ===");

        Console.WriteLine("Produk: " + produk1.NamaProduk);
        Console.WriteLine("Harga 10 galon: Rp" +
            produk1.HitungBiaya(10));

        Console.WriteLine();

        Console.WriteLine("Produk: " + produk2.NamaProduk);
        Console.WriteLine("Jenis Keran: " + berkeran.JenisKeran);
        Console.WriteLine("Harga 10 galon: Rp" +
            produk2.HitungBiaya(10));

        SindikatGalon sindikat = new SindikatGalon();

        sindikat.TambahAgen(agen1);
        sindikat.TambahAgen(agen2);

        sindikat.TambahProduk(akua);
        sindikat.TambahProduk(berkeran);

        sindikat.TampilkanSindikat();

        Console.WriteLine("\n=== DISTRIBUSI GALON ===");

        DapatDidistribusikan kiriman1 =
            new DistribusiGalon(agen1, produk1, 20);

        kiriman1.KirimPaket();

        DapatDidistribusikan kiriman2 =
            new DistribusiGalon(agen2, produk2, 15);

        kiriman2.KirimPaket();

        Console.WriteLine("\n=== STOK SETELAH DISTRIBUSI ===");

        sindikat.TampilkanSindikat();

        Console.WriteLine("======================================");
        Console.WriteLine("       SISTEM SELESAI DIJALANKAN");
        Console.WriteLine("======================================");
    }
}