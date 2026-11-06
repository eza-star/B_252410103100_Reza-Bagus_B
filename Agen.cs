class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen(string id, string nama, int stok)
    {
        idAgen = id;
        namaAgen = nama;
        stokAgen = stok;
    }

    public void TampilInfo()
    {
        Console.WriteLine("ID Agen       : " + idAgen);
        Console.WriteLine("Nama Agen     : " + namaAgen);
        Console.WriteLine("Stok Agen     : " + stokAgen);
    }
}


