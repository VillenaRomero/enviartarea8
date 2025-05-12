using UnityEngine;

public class orco : enemy, IAtacable, IDañable, IDropeable
{
    private System.Random rng = new System.Random();

    public void Inicializar(string nombre, int vida, int ataque)
    {
        base.Inicializar(nombre, vida, ataque);
    }

    public void Atacar()
    {
        int chance = rng.Next(0, 100);
        int poder = Ataque;

        if (chance > 70)
        {
            poder *= 2;
            Debug.Log(Nombre + " entra en furia y duplica su ataque!");
        }

        Debug.Log(Nombre + " ataca con fuerza bruta! Daño: " + poder);
    }

    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + " recibió " + cantidad + " de daño. Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log(Nombre + " dropea un garrote ensangrentado!");
    }
}
