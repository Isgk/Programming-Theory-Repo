using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    
    private Renderer renderer;
    public Material shapeMat;

    private string shapeName;
    private string shapeColor;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        shapeName = gameObject.ToString();
        shapeColor = renderer.material.name;
        Debug.Log(shapeName);
        Debug.Log(shapeColor);


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
