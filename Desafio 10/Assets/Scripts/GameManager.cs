using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private int puntuacionDelPersonaje;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }

            return _instance;
        }

    }

    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);
    }

    public void SumarPuntuacion(int puntuacion)
    {
        puntuacionDelPersonaje += puntuacion;
        if(puntuacionDelPersonaje == 4){
           CambiarEscena("escena 2");
        }
        else if (puntuacionDelPersonaje == 12)
        {
            CambiarEscena("GameOver");
        }
    }

    public string RetornarPuntuacion()
    {
        return this.puntuacionDelPersonaje.ToString();
    }

    public void CambiarEscena(string escena)
    {
      SceneManager.LoadScene(escena);
    }

}
