using UnityEngine;

public interface IConsumible
{
    void Consumir();
}

public interface IAplicarBuff
{
    void AplicarBuff();
}

public class item : MonoBehaviour
{
    public string Nombre { get; private set; }

    public item(string nombre)
    {
        Nombre = nombre;
    }
}
