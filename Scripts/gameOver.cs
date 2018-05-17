namespace gameOverController
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class gameOver : MonoBehaviour
    {
        public Text back;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        public void Back()
        {
            if (back)
            {
                SceneManager.LoadScene("MainScene");
            }
        }
    }
}