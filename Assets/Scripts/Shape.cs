using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    private GameObject shapeSelected;
    private Renderer renderer;
    public Material shapeMat;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }

    private void OnMouseExit()
    {
        renderer.material = shapeMat;
    }

}
