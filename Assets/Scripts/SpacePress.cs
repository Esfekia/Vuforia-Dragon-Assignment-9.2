using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePress : MonoBehaviour
{
    public GameObject theArcher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("SpaceKey"))
        {
            theArcher.GetComponent<Animator>().Play("Dodge Backward");
            //theArcher.transform.position += new Vector3(-0.004f, 0, 0);
        }
    }
}
