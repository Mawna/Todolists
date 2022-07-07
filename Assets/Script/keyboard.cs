using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{

    TouchScreenKeyboard KB;

    public void OpenKeyboard()
    {
       KB = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);

    }

}
