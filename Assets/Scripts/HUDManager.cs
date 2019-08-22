using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public Player player;
    public GameObject gameHUD;
    public GameObject deathHUD;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        gameHUD.SetActive(true);
        deathHUD.SetActive(false);
    }
    private void Update()
    {
        if (player.health <= 0)
        {
            gameHUD.SetActive(false);
            deathHUD.SetActive(true);
        }
    }
}
