using UnityEngine;
using UnityEngine.InputSystem;

public class BuyShell : MonoBehaviour
{
    private PlayerMoney _playerMoney;
    private ShellCount _shellCount;
    [SerializeField] private GameObject _errorText;

    private void Start()
    {
        _playerMoney = GetComponent<PlayerMoney>();
        _playerMoney.MoneyText.text = _playerMoney.AmountMoney.ToString();
        _shellCount = GetComponent<ShellCount>();
    }

    public void OnBuy(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            if (_playerMoney.AmountMoney >= 50)
            {
                EditMoneyAmount(-50);
                _shellCount.TonkShellCount++;
                _shellCount.ShellCountText.text = _shellCount.TonkShellCount.ToString();
            }
            else
            {
                _errorText.SetActive(true);
            }
        }
    }

    public void EditMoneyAmount(int value)
    {
        _playerMoney.AmountMoney += value;
        _playerMoney.MoneyText.text = _playerMoney.AmountMoney.ToString();
    }
}
