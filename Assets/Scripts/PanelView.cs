using System;
using System.Collections;

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;

    [SerializeField] private TextMeshProUGUI _description;

    [SerializeField] private TextMeshProUGUI _amountReward = null;

    [SerializeField] private UnityEngine.UI.Image _mainImage;

    [SerializeField] private UnityEngine.UI.Image _spriteReward;

    [SerializeField] private PanelItemSettingsWithoutAmount _panelItemSettingsWithoutAmount;
    
    [SerializeField] private PanelItemSettingsWithAmount _panelItemSettingsWithAmount;

    private void Awake()
    {
        if (_amountReward != null)
        {
            _name.text = _panelItemSettingsWithAmount.Name.ToString();
            _mainImage.sprite = _panelItemSettingsWithAmount.MainIcon;
            _description.text = _panelItemSettingsWithAmount.Description.ToString();
            _spriteReward.sprite = _panelItemSettingsWithAmount.Icon;
            _amountReward.text = _panelItemSettingsWithAmount.AmountReward.ToString();
            
        }
        else
        {
            _name.text = _panelItemSettingsWithoutAmount.Name.ToString();
            _mainImage.sprite = _panelItemSettingsWithoutAmount.MainIcon;
            _description.text = _panelItemSettingsWithoutAmount.Description.ToString();
            _spriteReward.sprite = _panelItemSettingsWithoutAmount.Icon;
        }
    }
}
