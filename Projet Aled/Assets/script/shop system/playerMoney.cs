using UnityEngine;

/// <summary>
/// manages the player money
/// </summary>
public class PlayerMoney : MonoBehaviour
{
    /// <summary>
    /// ammount of player's money
    /// </summary>
    [field : SerializeField] public int AmountMoney {  get; private set; }

    private DisplayMoney _displayMoney;

    private void Start()
    {
        _displayMoney = GetComponent<DisplayMoney>();
        EditMoneyAmount(0);
    }

    /// <summary>
    /// change the ammount of player money and displays it
    /// </summary>
    /// <param name="value">ammount of money to add</param>
    public void EditMoneyAmount(int value)
    {
        AmountMoney += value;
        _displayMoney.EditText(AmountMoney.ToString());
    }
}