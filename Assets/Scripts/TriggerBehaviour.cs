using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    [SerializeField] private CountCoinsBehavior _countCoinsBehavior;
    private bool _areNotFirstCoinDestroyed;
    private bool _areNotFirstRubinDestroyed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin") )
        {
           
            Destroy(other.gameObject);
            if (!_areNotFirstCoinDestroyed)
            {
                _areNotFirstCoinDestroyed = true;
                _countCoinsBehavior.IncreaseAmountCointOrRubin();
            }
           
        }

        if  (other.CompareTag("Rubin"))
        {
            Destroy(other.gameObject);
            if (!_areNotFirstRubinDestroyed)
            {
                _areNotFirstRubinDestroyed = true;
                _countCoinsBehavior.IncreaseAmountCointOrRubin();
            }
        }

       
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
