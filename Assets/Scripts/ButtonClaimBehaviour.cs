using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClaimBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _button;

    [SerializeField] private Image _image;

    [UsedImplicitly]
    public void OnClick()
    {
        _button.SetActive(false);
        _image.enabled = true;
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
