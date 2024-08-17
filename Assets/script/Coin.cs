using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private MeshRenderer rd;
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        rd.material.color = Color.yellow;

        player player = other.gameObject.GetComponent<player>();
        
        {
            player.Score += 1;
            MainUI.instance.ShowNotiText("Score: " + player.Score);

            Destroy(gameObject);

            if (player.Score > 12)
            {
                MainUI.instance.ShowNotiText("You're Doing Really Great /n" + player.Score);
            }
        }
    }

}
