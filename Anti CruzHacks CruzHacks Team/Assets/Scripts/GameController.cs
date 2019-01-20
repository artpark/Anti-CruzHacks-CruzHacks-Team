using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject note;
    public Transform noteSpawn;
    public Text coordinates;

    // Start is called before the first frame update
    void Start()
    {
        coordinates.text = "Touch Position : None";
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 45 == 0)
        {
            Debug.Log("New note created");
            NewNote(10);
            //Destroy (newNote, 5f);            
        }
        // if(Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);
        //     coordinates.text = "Touch Position : " + touch.position.x + " " + touch.position.y;
        // }
    }

    void NewNote(float speed) //normal speed is 6
    {
        GameObject newNote = (GameObject)Instantiate(note, note.transform.position, note.transform.rotation);
        newNote.GetComponent<Rigidbody>().velocity = newNote.transform.forward * -speed;
    }
}
