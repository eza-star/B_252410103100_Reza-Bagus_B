using UTSPBO;

abstract class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;
    private int stok;

    public string IdProduk
    {
        get { return idProduk; }
        set { idProduk = value; }
    }

    public string NamaProduk
    {
        get { return namaProduk; }
        set { namaProduk = value; }
    }

    public int StokGudang
    {
        get { return stokGudang; }
        private set
        {
            if (value >= 0)
            {
                stokGudang = value;
            }
        }
    }

    public ProdukGalon(string id, string nama, int stok)
    {
        idProduk = id;
        namaProduk = nama;

        if (stok < 0)
        {
            throw new ArgumentException(
                "Stok gudang tidak boleh negatif!"
            );
        }

        stokGudang = stok;
    }

    public bool KurangiStok(int jumlah)
    {
        if (jumlah <= 0)
        {
            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
            return false;
        }

        if (jumlah > stokGudang)
        {
            Console.WriteLine("Stok gudang tidak mencukupi!");
            return false;
        }

        stokGudang -= jumlah;
        return true;
    }

    // ABSTRACT METHOD
    public abstract decimal HitungBiaya(int jumlah);

    public static implicit operator ProdukGalon(GalonBerkeran v)
    {
        throw new NotImplementedException();
    }
}
