using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// buy new shell if player have enough money
/// </summary>
public class BuyShell : MonoBehaviour
{
    /// <summary>
    /// player money
    /// </summary>
    private PlayerMoney _playerMoney;

    /// <summary>
    /// shell count of the player
    /// </summary>
    private ShellCount _shellCount;

    /// <summary>
    /// error text
    /// </summary>
    [SerializeField] private GameObject _errorText;

    private void Start()
    {
        _playerMoney = GetComponent<PlayerMoney>();
        _shellCount = GetComponent<ShellCount>();
    }

    /// <summary>
    /// try to buy shell 
    /// </summary>
    /// <param name="callbackContext"></param>
    public void OnBuy(InputAction.CallbackContext callbackContext)
    {
        //check if player start to press the button
        if (callbackContext.started)
        {
            //check if player have enough money, buy a shell if yes, show text error else
            if (_playerMoney.AmountMoney >= 50)
            {
                _playerMoney.EditMoneyAmount(-50);
                _shellCount.EditShellCount(1);
            }
            else
            {
                _errorText.SetActive(true);
            }
        }
    }
}