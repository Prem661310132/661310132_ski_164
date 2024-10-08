using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] public float forcePower;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float xInput;
    [SerializeField] private int hp;
    [SerializeField] private int score;
    public int HP { get { return hp; } set { hp = value; } }
    public int Score { get { return score; } set { score = value; } }
    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftorRight();
    }



    private void MoveLeftorRight()
    {
        xInput = Input.GetAxis("Horizontal");
        rb.AddForce(xInput * Vector3.right * forcePower);
    }


}
