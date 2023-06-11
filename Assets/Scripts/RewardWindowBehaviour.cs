using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RewardWindowBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _windowGameObject;

    [SerializeField] private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        //_animator = _windowGameObject.GetComponent<Animator>();
    }

    [UsedImplicitly]
    public void ClaimReward()
    {
        _windowGameObject.SetActive(true);
        _animator.enabled = true;
    }

    [UsedImplicitly]
    public void ClosePanel()
    {
        _windowGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}