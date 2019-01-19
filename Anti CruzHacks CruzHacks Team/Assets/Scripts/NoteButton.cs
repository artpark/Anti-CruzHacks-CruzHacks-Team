using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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
        Debug.Log("Note Enter");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = true;
        }
    }

    private void OnTriggerStay(Collider other) {
        if(Input.GetButtonDown("Fire2")) {
            Debug.Log("Hit");
            Destroy(other.gameObject);
        }

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                if(Physics.Raycast(ray, out hit)) {
                    if(hit.collider.name == "Bar 1 Hit Spot")
                    {
                        Debug.Log("Hit");
                        Destroy(other.gameObject);
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Note Exit");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = false;
        }
    }
}
