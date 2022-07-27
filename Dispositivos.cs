public  class Dispositivo
{
    public int imei;
    public string marca;
    public string modelo;
    public string sistemaOperativo;

    public Dispositivo(int imei, string marca, string modelo, string sistemaOperativo)
    {
        this.imei = imei;
        this.marca = marca;
        this.modelo = modelo;
        this.sistemaOperativo = sistemaOperativo;
    }

    public void Imprimir()
    {
        Console.WriteLine();
        Console.WriteLine("IMEI: "+imei+
                          " Marca: "+marca+
                          " Modelo: "+modelo+
                          " Sistema operativo: "+sistemaOperativo);

    }

    

}