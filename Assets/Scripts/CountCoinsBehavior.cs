using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CountCoinsBehavior : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsTextMeshProUGUI;

    [SerializeField] private int _rewardAmount;

    [SerializeField] private int _currentRewardAmount;
    // Start is called before the first frame update

   
    public void IncreaseAmountCointOrRubin()
    {
        StartCoroutine(Increase());
    }

    private IEnumerator Increase()
    {
       
            for (int i = _currentRewardAmount; i < _rewardAmount + _currentRewardAmount+1; i++)
            {
               var amountCoins =  i;
                _coinsTextMeshProUGUI.text = amountCoins.ToString();
                yield return new WaitForSeconds(0.0001f);
            }  
            
        
            
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}