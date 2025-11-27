using UnityEngine;

public class Coin : MonoBehaviour
{
    private int value;  // random
    [SerializeField] private AudioClip pickupSound;
    private bool hasTriggered;

    private CoinManager coinManager;

    private void Start()
    {
        coinManager = CoinManager.instance;

        // Random value between 1 and 5 foe the coin
        value = Random.Range(1, 6);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;

            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            coinManager.ChangeCoins(value);

            Destroy(gameObject);
        }
    }
}
