class DistribusiGalon : DapatDidistribusikan
{
    private Agen agenTujuan;
    private ProdukGalon produk;
    private int jumlah;

    public DistribusiGalon(
        Agen agen,
        ProdukGalon produkGalon,
        int jumlahKirim
    )
    {
        agenTujuan = agen;
        produk = produkGalon;
        jumlah = jumlahKirim;
    }

    public void KirimPaket()
    {
        Console.WriteLine("\n--- PROSES DISTRIBUSI ---");

        // Validasi jumlah pengiriman
        if (jumlah <= 0)
        {
            Console.WriteLine(
                "GAGAL: Jumlah pengiriman harus lebih dari 0!"
            );
            return;
        }

        // Validasi stok gudang
        if (jumlah > produk.StokGudang)
        {
            Console.WriteLine(
                "GAGAL: Stok gudang tidak mencukupi!"
            );
            return;
        }

        // Jika valid, kurangi stok gudang
        if (produk.KurangiStok(jumlah))
        {
            // Tambahkan stok agen
            agenTujuan.stokAgen += jumlah;

            Console.WriteLine(
                "Paket berhasil dikirimkan ke agen " +
                agenTujuan.namaAgen + "!"
            );

            Console.WriteLine(
                "Jumlah galon dikirim: " + jumlah
            );

            Console.WriteLine(
                "Total transaksi: Rp" +
                produk.HitungBiaya(jumlah)
            );
        }
    }
}
