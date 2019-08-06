using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    public TextMeshProUGUI kCountText;
    public int kCount = 0;

    private void Start()
    {
        kCount = 0;
    }

    private void Update()
    {
        kCountText.text = kCount.ToString() + " kills";
    }
}
