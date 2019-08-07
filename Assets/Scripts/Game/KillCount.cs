using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KillCount : MonoBehaviour
{
    public static int killCount;
    public Text text;

    public void Start()
    {
        killCount = 0;
    }
    public void Update()
    {
        text.text = "KillCount:" + killCount;
    }
}
