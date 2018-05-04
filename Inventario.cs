namespace inventario
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class Inventario : MonoBehaviour
    {
        public GameObject[] Ch;

        public Text CountChains;

        public Text Chains;

        public Text SetFreeNatascha;

        public AudioSource HellephantDeath2;

        public AudioClip WolfGangSound;

        int Chain;

        void Start()
        {
            Chain = 0;

            CorrentesColetadas();

            SetFreeNatascha.text = "";
        }

        void Update()
        {
            Resetar();
        }

        void Resetar()
        {
            if (Chain == 8)
            {
                SceneManager.GetSceneByName("MainScene");
            }
        }

        void OnTriggerEnter(Collider ch)
        {
            if (ch.tag == "Chain")
            {
                ch.gameObject.SetActive(false);

                Chain++;

                Chains.text = "Chains: " + Chain.ToString();

                HellephantDeath2.Play();

                CorrentesColetadas();
            }
        }

        void CorrentesColetadas()
        {
            CountChains.text = "Collect 8 chains! ";

            if (Chain == 8)
            {
                SetFreeNatascha.text = "You saved Natascha!";

                SceneManager.LoadScene("MainScene");
            }
        }
    }
}