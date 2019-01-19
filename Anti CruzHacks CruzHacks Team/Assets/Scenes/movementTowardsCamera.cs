using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTowardsCamera : MonoBehaviour
{
    private Vector2 spherePosition;
    private float xMovePosition = 0f;
    private float yMovePosition = 7f;
    private float zMovePosition = 0f;
    private float xOriginalPosition = 0f;
    private float yOriginalPosition = 7f;
    private float zOriginalPosition = 0f;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        

    }
    public float getX()
    {
        return xMovePosition;
    }
    public float getY()
    {
        return yMovePosition;
    }
    public float getZ()
    {
        return zMovePosition;
    }
    public void makeNew()
    {
        Instantiate(prefab, new Vector3(xOriginalPosition, yOriginalPosition, zOriginalPosition), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        yMovePosition = yMovePosition - .08f;
        spherePosition = new Vector3(xMovePosition, yMovePosition, zMovePosition);
        transform.position = spherePosition;

        //Touch touch = new Touch();
        //print(touch.position);
        if (Input.GetButtonDown("Fire1") && yMovePosition >= -3.5 && yMovePosition <= -2.5)
        {
            print("winner winner chicken dinner");
            makeNew();
            Destroy(this.gameObject);
        }

        if (Input.GetButtonDown("Fire1") && (yMovePosition <= -3.5 || yMovePosition >= -2.5))
        {
            print("loser loser you're a loser");
            makeNew();
            Destroy(this.gameObject);
        }


        if (yMovePosition < -8)
        {
            makeNew();
            print("loser loser you're a loser");
            Destroy(this.gameObject);
        }
    }

}
