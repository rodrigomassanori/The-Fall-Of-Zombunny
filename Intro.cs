namespace intro
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]

    public class Intro : MonoBehaviour
    {
        AudioSource intro;

        KeyCode x = KeyCode.X;

        void Awake()
        {
            intro = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetKeyDown(x))
            {
                intro.Play();
            }
        }
    }
}