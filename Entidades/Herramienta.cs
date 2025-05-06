namespace Dsw2025Ej9.Entidades;

public class Herramienta
{
    public string Nombre { get; }
    public bool IsElectrico { get; }

    public Herramienta(string nombre, bool isElectrico = false)
    {
        Nombre = nombre;
        IsElectrico = isElectrico;
    }
}
