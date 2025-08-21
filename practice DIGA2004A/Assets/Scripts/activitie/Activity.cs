using UnityEngine;


public class Activity1 : MonoBehaviour
{
    public bool hasKey = true;
    public float rotationSpeed = 45f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int coinValue = 25;
        int coinsCollected = 3;
        int totalScore  = coinValue * coinsCollected;
        Debug.Log(" Total Score " + totalScore);
        
        if(hasKey == true){
            Debug.Log("Find the key first");
        }
        else{
            Debug.Log("Find key first");
        }

        int health = 100;
        int damage = 30;
      
        health -= damage;
        Debug.Log("Player Health:" + 70);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
