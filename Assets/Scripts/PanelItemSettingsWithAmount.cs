using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PanelItemSettingsWithAmount", menuName = "scriptableObjects/PanelItem")]
public class PanelItemSettingsWithAmount : ScriptableObject
{
    public string Name => _name;
    public string Description => _description;
    public string AmountReward => _amountReward;
    public Sprite MainIcon  => _mainIcon;
    public Sprite Icon  => _icon;
    public Sprite Tick  => _tick;

    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _mainIcon;
    [SerializeField] private Sprite _icon;
    [SerializeField] private string _amountReward;
    [SerializeField] private Sprite _tick;
   // [SerializeField] private 
    
   
}
