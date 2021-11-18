using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public TMPro.TextMeshProUGUI texto;

    private void Start()
    {
        texto = GetComponentInChildren<TMPro.TextMeshProUGUI>();
    }
    void Update()
    {
        texto.text = "Caramelos: " + GameManager.Instance.RetornarPuntuacion().ToString();

    }
}
