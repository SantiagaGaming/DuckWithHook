using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    public UnityAction JumpButtonPressed;
    private Button _button;
    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(JumpButtonPressed);
    }
    
}
