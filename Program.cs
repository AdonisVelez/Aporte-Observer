using System;
namespace AdonisObserverAporte
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Cliente cliente = new Cliente("Adonis Velez", "aavc.1234",0960498557);

            Dispositivo  celular = new Celular("Cargador",123456,"Nokia","500","Android");
            celular.Imprimir();

            Dispositivo tablet = new Tabletas("Claro","EEUU",123456,"Huawei","500","android");

        }
    }
}
