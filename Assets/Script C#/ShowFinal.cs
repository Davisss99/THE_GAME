using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFinal : MonoBehaviour
{
    public Button buttonToShow;
    private float timer = 0f;
    private float delay = 15f;
    private bool buttonActivated = false;

    void Start()
    {
        // Imposta il bottone come non attivo all'inizio
        if (buttonToShow != null)
        {
            buttonToShow.interactable = false;
        }
    }

    void Update()
    {
        // Avvia il timer dopo l'avvio dello script
        timer += Time.deltaTime;

        // Controlla se è passato il tempo di attesa
        if (timer >= delay && !buttonActivated)
        {
            // Attiva il bottone dopo il ritardo
            if (buttonToShow != null)
            {
                buttonToShow.interactable = true;
                buttonActivated = true;
            }
        }
    }
}


