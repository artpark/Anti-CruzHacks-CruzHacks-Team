using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject note;
    public Transform noteSpawn;
    public Material Note;
    public Material Note_1;
    public Material Note_2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // if(Time.frameCount % 45 == 0)
        // {
        //     Debug.Log("New note created");
        //     NewNote(10);
        //     //Destroy (newNote, 5f);            
        // }
    }

    public void NewNote(float speed) //normal speed is 6
    {
        int bar = Random.Range(0, 3);

        //Debug.Log(bar);
        float track = (float) (-1 + (1 * bar));

        if (bar == 0){
            note.GetComponent<Renderer>().material = Note_2;
        }
        if (bar == 1){
            note.GetComponent<Renderer>().material = Note_1;
        }
        if (bar == 2){
            note.GetComponent<Renderer>().material = Note;

        }

        note.transform.position = new Vector3(track,0,14);
        GameObject newNote = (GameObject)Instantiate(note, note.transform.position, note.transform.rotation);
        newNote.GetComponent<Rigidbody>().velocity = newNote.transform.forward * -speed;

    }
}
