using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PanelsWithAmount : MonoBehaviour
{
    private string _name;
    private string _description;
    private Sprite _mainIcon;
    private Sprite _icon;
    private string _amountReward;
    private Sprite _tick;

    private PanelItemSettingsWithAmount _panelItemSettingsWithAmount;

    public void Initialize(PanelItemSettingsWithAmount panelItemSettingsWithAmount)
    {
        _panelItemSettingsWithAmount = panelItemSettingsWithAmount;
        _name = panelItemSettingsWithAmount.Name;
        _description = panelItemSettingsWithAmount.Description;
        _mainIcon = panelItemSettingsWithAmount.MainIcon;
        _icon = panelItemSettingsWithAmount.Icon;
        _amountReward = panelItemSettingsWithAmount.AmountReward;
        _tick = panelItemSettingsWithAmount.Tick;
    }
}