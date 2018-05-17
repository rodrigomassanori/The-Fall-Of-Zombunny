using UnityEngine;

public class VoiceOfMark : MonoBehaviour
{
    public AudioSource MarkVoice;

    KeyCode x = KeyCode.X;

    public GameObject mark;

    void Update()
    {
        if (Input.GetKey(x) && mark.gameObject.tag == "Mark")
        {
            MarkVoice.Play();
        }
    }
}