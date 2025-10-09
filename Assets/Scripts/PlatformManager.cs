using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] 
    int coinsCollected = 0;
    // increase coinsCollected by 1
    public void CollectCoin()
    {
        coinsCollected++;
 UnityEngine.Debug.Log("Coins Collected: " + coinsCollected);
    }
    public int GetCoinsCollected()
    {
        return coinsCollected;
        
    }
}
