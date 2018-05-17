using UnityEngine;
using UnityEngine.UI;

public class Voices : MonoBehaviour
{
    AudioSource voiceQuest;

    KeyCode q = KeyCode.Q;

    public Text mission;

    void Awake()
    {
        voiceQuest = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(q))
        {
            mission.text = "Help me and find 8 chains to save me! ";

            voiceQuest.Play();
        }
    }
}