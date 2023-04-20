using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEnemy : MonoBehaviour
{
    public float velocidad = 5f; // velocidad de movimiento
    public Transform jugador; // referencia al objeto del jugador
    public float distanciaMinima = 5f; // distancia m�nima para moverse hacia el jugador

    void FixedUpdate()
    {
        Vector3 posicionJugador = jugador.position; // obtener la posici�n actual del jugador
        Vector3 posicionEnemigo = transform.position; // obtener la posici�n actual del enemigo
        float distancia = Vector3.Distance(posicionJugador, posicionEnemigo); // obtener la distancia entre el enemigo y el jugador

        if (distancia <= distanciaMinima) // mover solo si est� cerca del jugador
        {
            Vector3 direccion = posicionJugador - posicionEnemigo; // obtener la direcci�n hacia el jugador

            // Normalizar la direcci�n y multiplicarla por la velocidad para mover el enemigo en esa direcci�n
            transform.position = Vector3.MoveTowards(posicionEnemigo, posicionJugador, velocidad * Time.deltaTime);
        }
    }
}



