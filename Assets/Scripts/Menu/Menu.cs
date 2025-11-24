using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pause_panel;
    private bool is_paused = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            is_paused = !is_paused;
            PauseGame();
        }
        
    }

    public void PauseGame()
    {
        if (is_paused)
        {
            Time.timeScale = 0;
            pause_panel.SetActive(true);
            
        } else
        {
            Time.timeScale = 1;
            pause_panel.SetActive(false);
        }


    }
}
