using UnityEngine;


public class Collectables : MonoBehaviour
{
    private int scoreworthy = 10;
    public GameManager gamemanager;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            collect();
        
            
       
    }

    private void collect()
    {
        gamemanager.Addscore(scoreworthy);
        Destroy(this.gameObject);

    }

    private void Update()
    {
       transform.Rotate(0, 10, 0);
    }
}
