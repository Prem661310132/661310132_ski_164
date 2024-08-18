using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;
    private bool isPlayerColliding = false;
    private float originalForcePower;
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        player player = collision.gameObject.GetComponent<player>();
        
        {
            originalForcePower = player.forcePower;

            player.forcePower = 8f;

            player.HP -= 15;
            MainUI.instance.ShowNotiText("Ahh! -15\nHP: " + player.HP);

            
            Rigidbody rb = player.GetComponent<Rigidbody>();
            {
                Vector3 pushDirection = collision.contacts[0].normal;
                
                float forcePower = player.forcePower;
                rb.AddForce(-pushDirection * forcePower);
            }

            if (player.HP <= 0)
            {
                player.HP = 0;
                MainUI.instance.ShowNotiText("You deer");
            }
            isPlayerColliding = true;
        }
    }
  

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(217, 118, 46, 255);

        player player = collision.gameObject.GetComponent<player>();
        if (player != null)
        {
            
            player.forcePower = originalForcePower;
        }

        isPlayerColliding = false;
    }
}