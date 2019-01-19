using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject note;
    public Transform noteSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            GameObject newNote = (GameObject)Instantiate(note, note.transform.position, note.transform.rotation);
            newNote.GetComponent<Rigidbody>().velocity = newNote.transform.forward * -6.0f;
        }
    }
}
