using UnityEngine;

public class SoundOnHit : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip hitSound;
    public AudioClip crashSound;

    void Start () {
      audioSource = this.GetComponent<AudioSource>();
      audioSource.clip = hitSound;
    }
	
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.tag == "Coin")
            audioSource.PlayOneShot(hitSound);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = hitSound;
        if (collision.gameObject.tag == "Obstacle")
            audioSource.PlayOneShot(crashSound);
    }
}