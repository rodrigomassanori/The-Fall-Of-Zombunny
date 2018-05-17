using UnityEngine;

public class VoiceOfWolfgang : MonoBehaviour
{
    public AudioSource WolfgangVoice;

    void Awake()
    {
        WolfgangVoice = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WolfgangVoice.Play();
        }
    }
}