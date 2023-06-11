using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using Random = System.Random;

public class CoinsBehaviour : MonoBehaviour
{

    [SerializeField] 
    private GameObject _prefab;

    [SerializeField] private Transform _position;
    private GameObject _gameObject;

    [SerializeField]
    private int _amountCoins;

    private List<GameObject> _list = new List<GameObject>();

    [UsedImplicitly]
    public void CoinBehaviour()
    {
       StartCoroutine(Instantiate());
       
    }

    private IEnumerator Instantiate()
    {
        
        var amountCoins = _amountCoins;
        for (int i = 0; i < amountCoins; i++)
        {
           
            _gameObject = Instantiate(_prefab);
            _gameObject.transform.SetParent(gameObject.transform);
            if (i %2 == 0)
            {
                _gameObject.transform.localPosition = new Vector3(20f*i, 31f*i, 0f); 
            }
            else
            {
                _gameObject.transform.position = new Vector3(3f*i, 2f, 0f);
            }
            yield return new WaitForSeconds(0.1f);
        }
          
            //amountCoins--;
            
       
     
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
