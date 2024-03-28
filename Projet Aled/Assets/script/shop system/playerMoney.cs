using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    [field: SerializeField] public TextMeshProUGUI MoneyText { get; set; }
    [field: SerializeField] public float AmountMoney { get; set; }
}