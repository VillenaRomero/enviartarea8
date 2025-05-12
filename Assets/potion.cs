using UnityEngine;

public class potion : item, IConsumible
{
    public potion(string nombre) : base(nombre) { }

    public void Consumir()
    {
        Debug.Log(Nombre + " consumida: vida restaurada!");
    }
}
