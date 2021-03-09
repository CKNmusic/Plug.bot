using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLights : MonoBehaviour
{
    [Range(-10, 10)] public int velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,5 * velocidade * Time.deltaTime, 0);
    }
}
