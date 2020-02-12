using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameManager gamemanagertwo;
    private int scoreworthy = -20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            reduce();
        }


        void reduce()
        {
            gamemanagertwo.subtractscore(scoreworthy);
            Destroy(this.gameObject);

        }



    }
    private void Update()
    {
        transform.Rotate(0, 10, 0);
    }

} 












   
