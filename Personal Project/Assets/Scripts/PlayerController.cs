using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // How fast player moves
    public float speed = 10.0f;
    // Accounts for player input for movement
    private float forwardInput, horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Gets input and associates it with directions for movement
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player forwards, backwards, right, and left
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
