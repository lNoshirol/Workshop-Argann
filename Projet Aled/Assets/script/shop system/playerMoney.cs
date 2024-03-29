using UnityEngine;
using TMPro;

/// <summary>
/// manages the player money
/// </summary>
public class PlayerMoney : MonoBehaviour
{
    /// <summary>
    /// text to display player money
    /// </summary>
    [field: SerializeField] public TextMeshProUGUI MoneyText { get; set; }
    /// <summary>
    /// ammount of player's money
    /// </summary>
    [field: SerializeField] public float AmountMoney { get; set; }
}