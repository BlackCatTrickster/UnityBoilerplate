using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] 
    int coinsCollected = 0;
    // increase coinsCollected by 1
    public TextMeshProUGUI coinText;
    public void CollectCoin()
    {
        coinsCollected++;
    }
    public int GetCoinsCollected()
    {
        return coinsCollected;
        
    }
}
