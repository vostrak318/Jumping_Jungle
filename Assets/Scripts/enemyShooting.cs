using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public GameObject spike;
    public Transform spikePos;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(spike,spikePos.position,Quaternion.identity);
    }
}
