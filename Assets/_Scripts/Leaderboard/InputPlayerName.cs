using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputPlayerName : MonoBehaviour
{
    private string currentName;
    private TMP_InputField inputField;

    private void Awake()
    {
        if (inputField == null) inputField = GetComponent<TMP_InputField>();
    }

    public void OnPlayerChangeName()
    {
        // Sets the Game's Player name as the current Input Field Value
        currentName = inputField.text;
        GlobalPlayerName.playerName = currentName;
    }
}
