using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    // The speed the bombs move
    public float moveSpeed = 5;
    // The y coordinate the prefeabs reach when they are deleted
    public float dead_zone = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the prefabs down the screen at an even rate
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
    
        // Deletes clones once they reach outside the screen
        if(transform.position.y < dead_zone) {
            Debug.Log("object deleted");
            Destroy(gameObject);
        }
    }

    // Deletes fruits when collides with farmer and increases score by 5
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
        if(collision.gameObject.CompareTag("farmer")) {
            if(gameObject.CompareTag("melon")){
                Debug.Log("hit melon");
                ScoreTracker.player_score/=2;
            }else if(gameObject.CompareTag("dragon")){
                Debug.Log("hit drag");
                ScoreTracker.player_score = 0;
            }else{
                Debug.Log("hit bomb");
                // Subtracts 5 from score if player hits a bomb
                // Ensures the score does not go below zero
                if(ScoreTracker.player_score - 5 <= 0) {
                    ScoreTracker.player_score = 0;
                }
                else {
                    ScoreTracker.player_score -= 5;
                }     
            }
            
        }
    }
}
