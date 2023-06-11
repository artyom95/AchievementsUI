using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ChangePanelColor : MonoBehaviour
{
    [SerializeField] private GameObject _panelObject;
    [SerializeField] private Color _changingColor;
    [SerializeField] private float _recoloringDuration;
    private Color _currentColor;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentColor = _panelObject.GetComponent<Image>().color;
    }

    [UsedImplicitly]
    public void ChangeColor()
    {
        StartCoroutine(SmoothColor());
    }

    private IEnumerator SmoothColor()
    {
        float time = 0;
        while ( time < _recoloringDuration)
        {
            
            var newColor = Color.Lerp(_currentColor, _changingColor, time/_recoloringDuration);
            _panelObject.GetComponent<Image>().color = newColor;
            time += Time.deltaTime;
            yield return null;

        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
