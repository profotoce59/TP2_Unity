using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        renderer.material.SetColor("_Color",Random.ColorHSV());
        Debug.Log("hitted");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
