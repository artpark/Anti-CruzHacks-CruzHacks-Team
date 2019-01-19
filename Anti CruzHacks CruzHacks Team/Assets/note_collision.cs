using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class note_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "note") {
            Destroy(collision.gameObject);
        }
    }
}
