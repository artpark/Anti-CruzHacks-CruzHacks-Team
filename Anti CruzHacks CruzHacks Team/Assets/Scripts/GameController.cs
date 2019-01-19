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
        if(Time.frameCount % 90 == 0)
        {
            Debug.Log("New note created");
            NewNote(6);
            //Destroy (newNote, 5f);            
        }
    }

    void NewNote(float speed) //normal speed is 6
    {
        GameObject newNote = (GameObject)Instantiate(note, note.transform.position, note.transform.rotation);
        newNote.GetComponent<Rigidbody>().velocity = newNote.transform.forward * -speed;
    }
}
