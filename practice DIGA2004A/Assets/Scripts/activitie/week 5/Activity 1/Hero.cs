using UnityEngine;

namespace MyGame.Character
{
    // This namespace is used to organize character-related scripts
    public class Hero : MonoBehaviour
    {
        public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
            
        } 
         
        public  void PrintHealth()
        {
            Debug.Log("Player health" + health);
        }
    // Update is called once per frame
        void Update()
        {
        
        }
    }   

}

