class GalonAkua : ProdukGalon
{
    public GalonAkua(string id, string nama, int stok)
        : base(id, nama, stok)
    {
    }

    public override decimal HitungBiaya(int jumlah)
    {
        return jumlah * 20000;
    }
}