using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour
{
    public int count;
    public Text textCount;
    
    private Sphere sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textCount.text = count.ToString();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Sphere"))
        {
            count++;
            sphere = collider.GetComponent<Sphere>();
            sphere.Destroy();
        }
    }
}
