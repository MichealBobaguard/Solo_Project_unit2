using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioClip SoundEffect;     // which sounf it is
    public float volume = 1f;         // Volume

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // If any WASD key is pressed down start playing a sound effect
        if (Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.D))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.loop = true;
                audioSource.clip = SoundEffect;
                audioSource.volume = volume;
                audioSource.Play();
            }
        }
        // If all WASD keys are released it stops playing the sound effect hopefully
        else if (!Input.GetKey(KeyCode.W) &&
                 !Input.GetKey(KeyCode.A) &&
                 !Input.GetKey(KeyCode.S) &&
                 !Input.GetKey(KeyCode.D))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }


}
