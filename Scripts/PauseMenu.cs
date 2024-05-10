using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Keeps track of the level the player is on
    public static bool is_game_paused = false;
    public static bool is_menu_visible = false;
    public GameObject pause_menu;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        // Pops up pause screen when esc key pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if the game is not paused, then open the panel
            if (!is_game_paused)
            {
                Pause();
            }
            else//if the game is paused, then resume
            {
                Resume();
            }
        }
    }

    public void Resume() {
        Debug.Log("Resumed game");
        pause_menu.SetActive(false);
        is_menu_visible = false;
        Time.timeScale = 1f;
        is_game_paused = false;
    }

    private void Pause() {
        Debug.Log("Paused game");
        is_menu_visible = !is_menu_visible;
        pause_menu.SetActive(is_menu_visible);
        Time.timeScale = 0f;
        is_game_paused = is_menu_visible;
    }

    public void LoadHome() {
        pause_menu.SetActive(false);
        is_menu_visible = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home Screen");
        ScoreTracker.player_score = 0;
    }
}
