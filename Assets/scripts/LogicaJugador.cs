using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaJugador : MonoBehaviour
{
    public Vida vida;
    public bool Vida0 = false;
    [SerializeField] private Animator animadorPerder;

    // Start is called before the first frame update
    void Start()
    {
        vida = GetComponent<Vida>();
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
    }

    void RevisarVida()
    {
        if (Vida0) return;
        if(vida.valor <= 0)
        {
            Vida0 = true;
        }
    }
    // cambiar esto en un futuro por pantalla de muerte
    void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
