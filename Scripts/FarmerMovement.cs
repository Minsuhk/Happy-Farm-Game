using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMovement : MonoBehaviour
{
    // We can adjust the speed of the character
    public float speed = 5f;
    private float halfPlayerSizeX;

    // Start is called before the first frame update
    void Start()
    {
        // Use to get the center point of the screen
        halfPlayerSizeX = GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.is_game_paused) {
            // Allows players to move character left and right using arrow keys
            if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
            LimitMovement();
        }
        
    }

    // Constricts the player to only move within the screen
    void LimitMovement()
    {
        Vector3 position = transform.position;

        float distance = transform.position.z - Camera.main.transform.position.z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + halfPlayerSizeX;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - halfPlayerSizeX;

        position.x = Mathf.Clamp(position.x, leftBorder, rightBorder);
        transform.position = position;
    }

}
