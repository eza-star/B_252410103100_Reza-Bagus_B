class SindikatGalon
{
    public List<Agen> daftarAgen = new List<Agen>();
    public List<ProdukGalon> daftarProduk =
        new List<ProdukGalon>();

    // Hubungan SindikatGalon dengan Agen adalah Aggregation.
    // SindikatGalon menyimpan kumpulan objek Agen.
    // Objek Agen tetap dapat berdiri sendiri
    // meskipun tidak dimasukkan ke dalam SindikatGalon.

    public void TambahAgen(Agen agen)
    {
        daftarAgen.Add(agen);
    }

    public void TambahProduk(ProdukGalon produk)
    {
        daftarProduk.Add(produk);
    }

    public void TampilkanSindikat()
    {
        Console.WriteLine("\n=== DATA ASET SINDIKAT ===");

        Console.WriteLine("\n--- DAFTAR AGEN ---");

        foreach (Agen agen in daftarAgen)
        {
            agen.TampilInfo();
            Console.WriteLine();
        }

        Console.WriteLine("--- DAFTAR PRODUK ---");

        foreach (ProdukGalon produk in daftarProduk)
        {
            Console.WriteLine("ID Produk   : " + produk.IdProduk);
            Console.WriteLine("Nama Produk : " + produk.NamaProduk);
            Console.WriteLine("Stok Gudang : " + produk.StokGudang);
            Console.WriteLine();
        }
    }
}
