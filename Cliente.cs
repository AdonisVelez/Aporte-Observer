public class Cliente
{
    public string nombre;
    public string correo;
    public int numerocelular;

    public Cliente(string nombre, string correo , int numerocelular)
    {
        this.nombre = nombre;
        this.correo = correo;
        this.numerocelular = numerocelular;
    }

    public void Imprimir()
    {
        Console.WriteLine();
        Console.WriteLine("Datos del cliente"+
                        " Nombre: "+nombre+
                         " Correo: "+correo+
                         " # Celular: "+numerocelular);
    }

    public void Reparar()
    {
        Console.WriteLine();
    }
}