using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePressFighter : MonoBehaviour
{
    public GameObject theFighter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("SpaceKey"))
        {
            theFighter.GetComponent<Animator>().Play("Stumble Backwards");            
        }
    }
}
