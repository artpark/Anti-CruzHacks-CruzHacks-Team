using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButton : MonoBehaviour
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
        Debug.Log("hi");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("bye");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = false;
        }
    }
}
