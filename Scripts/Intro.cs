namespace intro
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]

    public class Intro : MonoBehaviour
    {
        public AudioSource intro;

        KeyCode v = KeyCode.V;

        public GameObject introAudio;

        void Awake()
        {
            intro = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetKey(v) && introAudio.gameObject.tag == "intro")
            {
                intro.Play();
            }
        }
    }
}