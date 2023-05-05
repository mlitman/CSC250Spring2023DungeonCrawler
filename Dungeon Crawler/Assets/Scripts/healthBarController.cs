using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarController : MonoBehaviour
{
    public GameObject[] theHealthBoxes = new GameObject[10];
    
    // Start is called before the first frame update
    void Start()
    {
        this.theHealthBoxes[9].SetActive(false);
        this.theHealthBoxes[8].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
