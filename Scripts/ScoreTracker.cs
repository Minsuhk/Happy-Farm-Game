using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public static int player_score = 0; //change back to 0
    public static int score_multiplier = 1;
    public Text score_text;
    // Start is called before the first frame update
    void Start()
    {
        score_text = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the score and changes the text displayed on the player's screen
        score_text.text = player_score.ToString();
    }
}
