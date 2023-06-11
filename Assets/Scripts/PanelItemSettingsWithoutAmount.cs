
using UnityEngine;
[CreateAssetMenu(fileName = "PanelItem", menuName = "ScriptableObject/PanelItem")]
public class PanelItemSettingsWithoutAmount : ScriptableObject
{
    public string Name => _name;
    public string Description => _description;
    public Sprite MainIcon  => _mainIcon;
    public Sprite Icon  => _icon;
    public Sprite Tick  => _tick;


    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _mainIcon;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Sprite _tick;
   // [SerializeField] private 
    
   
  
}
