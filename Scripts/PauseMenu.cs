namespace MenuPrincipal
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using PlayerController;

    public class PauseMenu : MenuPrincipal
    {
        MenuPrincipal menu;

        Mark Player;

        bool IsPaused;

        bool IsVisible;

        KeyCode z = KeyCode.Z;

        void Start()
        {
            Player = GetComponent<Mark>();

            menu = GetComponent<MenuPrincipal>();
        }

        void Update()
        {
            if (Input.GetKeyDown(z))
            {
                IsPaused = true;

                IsVisible = true;
            }
        }

        void OnGUI()
        {
            if (IsPaused && IsVisible)
            {
                GUI.Label(new Rect(Screen.width / 500, 
                Screen.height / 900, 300, 90), "Game is Paused");

                Player.enabled = false;

                Time.timeScale = 0f;

                if (GUI.Button(new Rect(Screen.width / 10, Screen.height / 10, 160, 60), 
                "Click to Return to Play"))
                {
                    IsPaused = false;

                    IsVisible = false;

                    Time.timeScale = 1.2f;

                    Player.enabled = true;
                }

                if (GUI.Button(new Rect(Screen.width / 10, Screen.height / 10 + 70, 160, 60),
                "Back to Menu"))
                {
                    SceneManager.LoadScene("MainScene");
                }
            }
        }
    }
}