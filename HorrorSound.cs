namespace soundsHorror
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]

    public class HorrorSound : MonoBehaviour
    {
        AudioSource soundHorror;

        void Awake()
        {
            soundHorror = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Inimigo"))
            {
                soundHorror.Play();

                soundHorror.loop = true;
            }
        }
    }
}