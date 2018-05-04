namespace MenuPrincipal
{
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class MenuPrincipal : MonoBehaviour
    {
        public Text NewGame;

        public Text Credits;

        public Text Exit;
	
        CreditsMenu MenuCreditos;

        void Awake()
        {
            MenuCreditos = GetComponent<CreditsMenu>();
        }

        public void OnPlay()
        {
            SceneManager.LoadScene("TheFallOfZombunny");
        }

        public void OnCredits()
        {
            SceneManager.LoadScene("CreditsMenu");
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}