using UnityEngine;

public class orco : enemy, IAtacable, IDa�able, IDropeable
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

        Debug.Log(Nombre + " ataca con fuerza bruta! Da�o: " + poder);
    }

    public void RecibirDa�o(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + " recibi� " + cantidad + " de da�o. Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log(Nombre + " dropea un garrote ensangrentado!");
    }
}
