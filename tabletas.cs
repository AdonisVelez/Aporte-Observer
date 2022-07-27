public class Tabletas : Dispositivo
{
    private string chip;
    private string pais;

    public Tabletas (string chip, string pais,int imei, string marca, string modelo, string sistemaOperativo) : base (imei,marca,modelo,sistemaOperativo)
    {
        this.chip = chip;
        this.pais = pais;
    }

}