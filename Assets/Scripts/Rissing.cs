using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risse : MonoBehaviour
{
    public float speed = 1f; // Rychlost pohybu nahoru
    public string playerTag = "Player"; // Tag hráèe

    private void Update()
    {
        // Pohyb nahoru
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Zkontrolovat, zda kolize je s objektem hráèe
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Zavolat funkci "Konec"
            Konec();
        }
    }

    // Funkce pro provedení akce "konec"
    private void Konec()
    {
        // Sem vložte kód pro provedení akce po dotyku s hráèem
        Debug.Log("Konec funkce byla vyvolána po dotyku s hráèem.");
        // Napøíklad:
        // Destroy(gameObject); // Znièit tento objekt
    }
}