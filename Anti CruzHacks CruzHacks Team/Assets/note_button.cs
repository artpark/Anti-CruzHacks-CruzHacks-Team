using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_button : MonoBehaviour
{
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        //print("hi");
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        print("hi");
        Debug.Log("hi");
        if (other.gameObject.name == "note") {
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        print("bye");
        Debug.Log("bye");
        if (other.gameObject.name == "note") {
            isActive = false;
        }
    }
}
