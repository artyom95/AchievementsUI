
using TMPro;
using UnityEngine;

using Image = UnityEngine.UI.Image;

public class PanelsWithoutAmount : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _name;
    [SerializeField]
    private TextMeshProUGUI _description;
    [SerializeField]
    private Image _mainIcon;
    [SerializeField]
    private Image _icon;
   
    private Sprite _tick;

    private PanelItemSettingsWithoutAmount _panelItemSettingsWithoutAmount;

    public void Initialize(PanelItemSettingsWithoutAmount panelItemSettingsWithoutAmount)
    {
        _panelItemSettingsWithoutAmount = panelItemSettingsWithoutAmount;
        _name.text = panelItemSettingsWithoutAmount.Name.ToString();
        _description.text = panelItemSettingsWithoutAmount.Description;
        _mainIcon.sprite = panelItemSettingsWithoutAmount.MainIcon;
        _icon.sprite = panelItemSettingsWithoutAmount.Icon;
        _tick = panelItemSettingsWithoutAmount.Tick;
    }
}
