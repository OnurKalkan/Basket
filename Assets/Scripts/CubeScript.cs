using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CubeHover()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void CubeHoverExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
