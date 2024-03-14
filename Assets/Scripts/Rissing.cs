using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risse : MonoBehaviour
{
    public float speed = 1f; // Rychlost pohybu nahoru
    public string playerTag = "Player"; // Tag hr��e

    private void Update()
    {
        // Pohyb nahoru
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Zkontrolovat, zda kolize je s objektem hr��e
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Zavolat funkci "Konec"
            Konec();
        }
    }

    // Funkce pro proveden� akce "konec"
    private void Konec()
    {
        // Sem vlo�te k�d pro proveden� akce po dotyku s hr��em
        Debug.Log("Konec funkce byla vyvol�na po dotyku s hr��em.");
        // Nap��klad:
        // Destroy(gameObject); // Zni�it tento objekt
    }
}