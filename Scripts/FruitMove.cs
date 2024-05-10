using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // The speed the fruits move
    public float moveSpeed;
    // The y coordinate the prefeabs reach when they are deleted
    public float dead_zone = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the fruits down the screen at an even rate
        if(!PauseMenu.is_game_paused) {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
    
        // Deletes clones once they reach outside the screen
        if(transform.position.y < dead_zone) {
            Debug.Log("object deleted");
            Destroy(gameObject);
        }
    }

    // Deletes fruits when collides with farmer and increases score by one
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Collision Detected - Object: " + collision.gameObject.name + ", Tag: " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("farmer")) {
            // Since 'gameObject' in this context refers to the object this script is attached to (e.g., the fruit prefab),
            // and 'collision.gameObject' is what it collided with (the farmer),
            // you should check the tag of 'gameObject', not 'collision.gameObject'.

            if (gameObject.CompareTag("avocado")) {
                Debug.Log("hit avocado");
                ScoreTracker.player_score *= (2 * ScoreTracker.score_multiplier);
            } else if (gameObject.CompareTag("star")) {
                Debug.Log("hit starfruit");
                ScoreTracker.player_score += (5 * ScoreTracker.score_multiplier);
            } else if (gameObject.CompareTag("banana")) {
                Debug.Log("hit banana");
                int randomNumber = Random.Range(1, 10);
                if (randomNumber % 2 == 0) {
                    ScoreTracker.player_score = 100;
                } else {
                    ScoreTracker.player_score = 0;
                }
            }else {
                Debug.Log("increase score by 1");
                ScoreTracker.player_score += (1 * ScoreTracker.score_multiplier);
            }
            
            Destroy(gameObject);  // Destroy the fruit object after processing the collision
        }
    }
}
