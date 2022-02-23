using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Shape : MonoBehaviour
{

    private GameObject shapeId;
    private Renderer renderer;
    private Material shapeMat;
    public  TextMeshProUGUI shapeIdText;

    private string shapeName;
    private string shapeColor;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        shapeMat = renderer.sharedMaterial;
        shapeColor = shapeMat.name;
        shapeId = GameObject.Find("Id");
        shapeIdText = shapeId.GetComponent<TextMeshProUGUI>();
        shapeName = gameObject.name;
        





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

    private void OnMouseDown()
    {
        DisplayText(); 
        
    }

    public virtual void DisplayText()
    {
        shapeIdText.text = "This Is a " + shapeColor + " " + shapeName;
    }

    

}
