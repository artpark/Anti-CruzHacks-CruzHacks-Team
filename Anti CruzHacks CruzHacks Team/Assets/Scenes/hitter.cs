using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitter : MonoBehaviour
{
    private float collision;
    private float xPosition;
    private float yPosition;
    private float zPosition;
    private Vector2 spherePosition;
    // Start is called before the first frame update
    void Start()
    {
        movementTowardsCamera sphere = new movementTowardsCamera();
        xPosition = sphere.getX();
        yPosition = sphere.getY() - 10;
        zPosition = sphere.getZ();
        
    }

    // Update is called once per frame
    void Update()
    {
        spherePosition = new Vector3(xPosition, yPosition, zPosition);
        transform.position = spherePosition;
    }
}
