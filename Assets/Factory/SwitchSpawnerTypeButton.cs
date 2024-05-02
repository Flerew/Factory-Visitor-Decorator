using Assets.Factory;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SwitchSpawnerTypeButton : MonoBehaviour
{
    private Button _button;
    private SpawnerMediator _mediator;

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnSwitchClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnSwitchClick);
    }

    public void Initialize(SpawnerMediator mediator) => _mediator = mediator;

    private void OnSwitchClick() => _mediator.SwitchSpawnerType();
}
