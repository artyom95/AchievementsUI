using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectionPannels : MonoBehaviour
{

    [SerializeField] private ItemSettingsProvider _itemSettingsProvider;

    [SerializeField] private PanelsWithAmount _panelsPrefabWithAmount;

    [SerializeField] private PanelsWithoutAmount _panelPrefabWithoutAmount;

    [SerializeField] private RectTransform _panelsRoot;

   /* private void Awake()
    {
        var firstItem = _itemSettingsProvider.GetItems();
        foreach (var item in firstItem)
        {
            var itemPanel = Instantiate(_panelsPrefabWithAmount, _panelsRoot);
            itemPanel.Initialize(item);
        }
        
        var secondItem = _itemSettingsProvider.GetItemss();
        foreach (var item in secondItem)
        {
            var itemPanel = Instantiate(_panelPrefabWithoutAmount, _panelsRoot);
            itemPanel.Initialize(item);
        }
    }*/
}

