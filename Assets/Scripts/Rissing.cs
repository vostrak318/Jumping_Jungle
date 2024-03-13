using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risse : MonoBehaviour
{
    public float speed = 1f; 

    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
