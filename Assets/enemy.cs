using UnityEngine;
public interface IAtacable
{
    void Atacar();
}
public interface IDañable
{
    void RecibirDaño(int cantidad);
}
public interface IDropeable
{
    void DropearItem();
}
public class enemy : MonoBehaviour
{
    protected string nombre;
    protected int vida;
    protected int ataque;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public int Ataque { get => ataque; set => ataque = value; }

    public virtual void Inicializar(string nombre, int vida = 100, int ataque = 10)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
    }

    public void MostrarInfo()
    {
        Debug.Log("Soy " + nombre + " , Vida: " + vida + " , Ataque: " + ataque);
    }
}
