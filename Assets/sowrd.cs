using UnityEngine;

public class sowrd : item, IAplicarBuff
{
    public sowrd(string nombre) : base(nombre) { }

    public void AplicarBuff()
    {
        Debug.Log(Nombre + " equipada: ataque aumentado!");
    }
}
