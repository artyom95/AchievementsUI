using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemSettingsProvider", menuName = "scriptableObjects/ItemSettingsProvider")]

public class ItemSettingsProvider : ScriptableObject
{
    [SerializeField]
    private List<PanelItemSettingsWithAmount> _panelItemSettingsWithAmounts = new List<PanelItemSettingsWithAmount>();

    [SerializeField]
    private List<PanelItemSettingsWithoutAmount> _panelItemSettingsWithoutAmounts =
        new List<PanelItemSettingsWithoutAmount>();

    public List<PanelItemSettingsWithAmount> GetItems()
    {
        return _panelItemSettingsWithAmounts;
    }
    
    public List<PanelItemSettingsWithoutAmount> GetItemss()
    {
        return _panelItemSettingsWithoutAmounts;
    }
}
