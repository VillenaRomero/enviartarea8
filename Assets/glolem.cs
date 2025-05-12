using UnityEngine;

public class glolem : enemy, IAtacable, IDañable, IDropeable
{
    private int defensa;
    private System.Random rng = new System.Random();

    public int Defensa
    {
        get => defensa;
        set => defensa = value;
    }

    public void Inicializar(string nombre, int vida, int ataque, int defensa)
    {
        base.Inicializar(nombre, vida, ataque);
        this.defensa = defensa;
    }

    public void Atacar()
    {
        int fuerza = Ataque;
        Debug.Log(Nombre + " ataca con fuerza bruta! Daño: " + fuerza);
    }

    public void RecibirDaño(int cantidad)
    {
        int chance = rng.Next(0, 100);
        int defensaFinal = defensa;

        if (chance > 60)
        {
            defensaFinal *= 2;
            Debug.Log(Nombre + " endurece su piel y duplica su defensa!");
        }

        int dañoFinal = Mathf.Max(cantidad - defensaFinal, 0);
        Vida -= dañoFinal;

        Debug.Log(Nombre + " recibió " + cantidad + " de daño. Defensa: " + defensaFinal + ". Daño real: " + dañoFinal + ". Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log(Nombre + " dropea una roca mágica!");
    }
}
