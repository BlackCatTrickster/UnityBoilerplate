using UnityEngine;

public class Collectible : MonoBehaviour
{
    private PlatformManager manager;

    public void Start()
    {
        manager = FindObjectOfType<PlatformManager> ();
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.CollectCoin();
        Debug.Log("Coin Collected");
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
    }
}
