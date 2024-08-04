using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        player player = collision.gameObject.GetComponent<player>();
        player.HP -= 15;
        mainUI.instance.ShowNotiText("Ahh! -15\nHP; "+ player.HP);


        if (player.HP < 0)
        { 
            player.HP = 0;
            mainUI.instance.ShowNotiText("You deer");

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(217,118,46,255);
    }
}
