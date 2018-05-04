namespace MenuPrincipal
{
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class CreditsMenu : MenuPrincipal
    {
        public MenuPrincipal menu;

        public Text BackToMenu;

        void Awake()
        {
            menu = GetComponent<MenuPrincipal>();
        }

        public void Back()
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}