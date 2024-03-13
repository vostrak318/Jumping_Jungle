using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Kontrola, zda hráè se dotkl objektu s tagem "Water"
        if (other.CompareTag("water"))
        {
            // Zastavení scény
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
