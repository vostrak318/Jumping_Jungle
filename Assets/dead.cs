using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Kontrola, zda hr�� se dotkl objektu s tagem "Water"
        if (other.CompareTag("water"))
        {
            // Zastaven� sc�ny
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
