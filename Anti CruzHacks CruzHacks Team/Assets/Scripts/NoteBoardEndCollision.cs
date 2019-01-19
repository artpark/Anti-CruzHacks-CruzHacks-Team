using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class NoteBoardEndCollision : MonoBehaviour
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
        if (other.gameObject.name == "Note(Clone)") 
        {
            Destroy(other.gameObject);
        }
    }
}
