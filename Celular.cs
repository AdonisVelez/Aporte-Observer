public class Celular : Dispositivo
{
    private string hardware { get; set;}

    public Celular(string hardware,int imei, string marca, string modelo, string sistemaOperativo) : base (imei,marca,modelo,sistemaOperativo)
    {
        this.hardware = hardware;
    }
}