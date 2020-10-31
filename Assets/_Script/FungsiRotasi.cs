using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungsiRotasi : MonoBehaviour
{
    public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, kecepatan * 10 * Time.deltaTime, 0);
    }
}
