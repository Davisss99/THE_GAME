using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMovement : MonoBehaviour
{
    public float y_target = 17.81f;
    public float y_start = -4.71f;
    public float speed = 5f;
    private bool isMoving = false;

    void Start()
    {
        // Avvia il movimento quando la scena viene caricata
        StartMovement();
    }

    void Update()
    {
        // Controlla se l'oggetto è in movimento e lo sposta
        if (isMoving)
        {
            MoveObject();
        }
    }

    void StartMovement()
    {
        // Imposta l'oggetto alla posizione iniziale
        transform.position = new Vector3(transform.position.x, y_start, transform.position.z);
        isMoving = true;
    }

    void MoveObject()
    {
        // Calcola il passo del movimento in base al tempo
        float step = speed * Time.deltaTime;

        // Muovi l'oggetto verso la posizione target
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, y_target, transform.position.z), step);

        // Controlla se l'oggetto ha raggiunto la posizione target
        if (Mathf.Abs(transform.position.y - y_target) < 0.01f)
        {
            // L'oggetto ha raggiunto la posizione target, ferma il movimento
            isMoving = false;
        }
    }
}

