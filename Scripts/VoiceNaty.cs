namespace natyVoice
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]

    public class VoiceNaty : MonoBehaviour
    {
        public AudioSource Naty;

        void Awake()
        {
            Naty = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Naty.Play();
            }
        }
    }
}