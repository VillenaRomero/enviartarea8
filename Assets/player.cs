using System;
using UnityEngine;

public class player : MonoBehaviour, IAtacable, IDañable
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Durabilidad { get; set; }

    private System.Random rng = new System.Random();

    public void Inicializar(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Durabilidad = 10;
    }

    public void Atacar()
    {
        if (Durabilidad <= 0)
            throw new Exception(Nombre + " no puede atacar: su arma está rota.");

        int daño = Ataque + rng.Next(-2, 4);
        Durabilidad -= rng.Next(1, 3);

        Debug.Log(Nombre + " ataca al enemigo con daño: " + daño + " (Durabilidad: " + Durabilidad + ")");
    }

    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + " recibió " + cantidad + " de daño. Vida restante: " + Vida);

        if (Vida <= 0)
            throw new Exception(Nombre + " ha muerto!");
    }
}
