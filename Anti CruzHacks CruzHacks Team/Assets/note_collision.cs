using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class note_collision : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "note") 
        {
            Destroy(other.gameObject);
        }
    }
}
