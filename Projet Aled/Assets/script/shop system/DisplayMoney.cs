using TMPro;
using UnityEngine;

/// <summary>
/// display the ammount of money of the player
/// </summary>
public class DisplayMoney : MonoBehaviour
{
    /// <summary>
    /// text to display player money
    /// </summary>
    [SerializeField] private TextMeshProUGUI _moneyText;

    /// <summary>
    /// change the text _moneyText
    /// </summary>
    /// <param name="text">text content</param>
    public void EditText(string text)
    {
        _moneyText.text = text;
    }
}
