using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonURL : MonoBehaviour
{
    public void ButtonOpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
