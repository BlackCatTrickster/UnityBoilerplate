using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance; // Singleton for easy access
    public TextMeshProUGUI coinText; // Use "Text" instead if using Legacy Text
    private int coinCount = 0;
    public int coinsToWin = 5;
    void Awake()
    {
        // Set up singleton
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateCoinDisplay();
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        UpdateCoinDisplay();

        if (coinCount >= coinsToWin)
        {
            WinGame();
        }
    }

    void UpdateCoinDisplay()
    {
        coinText.text = "Coins: " + coinCount + "/" + coinsToWin;
        // Or use: coinText.text = $"Coins: {coinCount}";
    }

    void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
    public int GetCoinCount()
    {
        return coinCount;
    }
}
