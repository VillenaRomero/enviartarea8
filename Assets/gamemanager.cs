using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private player player;
    private orco enemigoOrco;
    private glolem enemigoGlolem;
    private System.Random rng = new System.Random();

    void Start()
    {
        player = gameObject.AddComponent<player>();
        player.Inicializar("Héroe", 100, 15);

        enemigoOrco = gameObject.AddComponent<orco>();
        enemigoOrco.Inicializar("Orco Malvado", 80, 10);

        enemigoGlolem = gameObject.AddComponent<glolem>();
        enemigoGlolem.Inicializar("Gólem de Piedra", 120, 8, 5);

        Debug.Log(" Combate iniciado!");
        enemigoOrco.MostrarInfo();
        enemigoGlolem.MostrarInfo();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("¡Pelea aleatoria!");

            int enemigoElegido = rng.Next(0, 2); // 0 = Orco, 1 = Glolem

            if (enemigoElegido == 0)
            {
                Debug.Log(" Peleando contra el ORCO");
                RealizarCombate(player, enemigoOrco);
            }
            else
            {
                Debug.Log(" Peleando contra el GÓLEM");
                RealizarCombate(player, enemigoGlolem);
            }
        }
    }

    void RealizarCombate(player jugador, enemy enemigo)
    {
        try
        {
            jugador.Atacar();

            if (enemigo is IDañable dañable)
            {
                int daño = rng.Next(5, jugador.Ataque + 5);
                dañable.RecibirDaño(daño);

                if (enemigo.Vida <= 0 && enemigo is IDropeable dropeable)
                {
                    dropeable.DropearItem();
                    return;
                }
            }

            if (enemigo is IAtacable atacante)
            {
                atacante.Atacar();
            }

            jugador.RecibirDaño(rng.Next(3, enemigo.Ataque + 3));
        }
        catch (System.Exception ex)
        {
            Debug.LogWarning("EXCEPCIÓN: " + ex.Message);
        }
    }
}
