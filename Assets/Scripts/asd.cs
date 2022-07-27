using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    public Camera cam;
    Vector2 mousePos; 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    private void FixedUpdate()
    {

        transform.position = mousePos; 
    }
}
