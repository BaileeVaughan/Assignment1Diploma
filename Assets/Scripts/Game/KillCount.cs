using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KillCount : MonoBehaviour
{
    public Text text;
    public static int killCount;

    public void Start()
    {
        killCount = 0;
    }
    public void Update()
    {
        text.text = "Kills: " + killCount;
    }
}
