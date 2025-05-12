using UnityEngine;

public class glolem : enemy, IAtacable, IDa�able, IDropeable
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
        Debug.Log(Nombre + " ataca con fuerza bruta! Da�o: " + fuerza);
    }

    public void RecibirDa�o(int cantidad)
    {
        int chance = rng.Next(0, 100);
        int defensaFinal = defensa;

        if (chance > 60)
        {
            defensaFinal *= 2;
            Debug.Log(Nombre + " endurece su piel y duplica su defensa!");
        }

        int da�oFinal = Mathf.Max(cantidad - defensaFinal, 0);
        Vida -= da�oFinal;

        Debug.Log(Nombre + " recibi� " + cantidad + " de da�o. Defensa: " + defensaFinal + ". Da�o real: " + da�oFinal + ". Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log(Nombre + " dropea una roca m�gica!");
    }
}
