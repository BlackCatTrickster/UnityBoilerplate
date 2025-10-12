using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCounter.instance.AddCoins(coinValue);
            Destroy(gameObject); // Remove the coin
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
    }
}
