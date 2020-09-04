using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresList : MonoBehaviour
{
    //public List<GameObject> spheres = new List<GameObject>();
    public GameObject[] spheres = new GameObject[73];
    public Color[] randomColors = new Color[8];
    
    // Start is called before the first frame update
    void Start()
    {
        for (int s = 1; s < spheres.Length+1; s++)
        {
            spheres[s - 1] = GameObject.Find("Sphere (" + s + ")");
        }

        foreach (var sphere in spheres)
        {
            sphere.GetComponent<MeshRenderer>().material.color =
                randomColors[Random.Range(0, randomColors.Length-1)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
