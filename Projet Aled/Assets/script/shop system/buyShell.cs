using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class buyShell : MonoBehaviour
{
    private playerMoney _playerMoney;
    private ShellCount _shellCount;
    [SerializeField] private GameObject _errorText;

    private void Start()
    {
        _playerMoney = GetComponent<playerMoney>();
        _playerMoney.moneyText.text = _playerMoney.amountMoney.ToString();
        _shellCount = GetComponent<ShellCount>();
    }

    public void OnBuy(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            if (_playerMoney.amountMoney >= 50)
            {
                EditMoneyAmount(-50);
                _shellCount.shellCount++;
                _shellCount.shellCountText.text = _shellCount.shellCount.ToString();
            }
            else
            {
                _errorText.SetActive(true);
            }
            
        }
    }

    public void EditMoneyAmount(int value)
    {
        _playerMoney.amountMoney += value;
        _playerMoney.moneyText.text = _playerMoney.amountMoney.ToString();
        
    }
}
