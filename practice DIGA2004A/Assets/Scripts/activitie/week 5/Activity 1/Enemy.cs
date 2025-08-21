using UnityEngine;

namespace MyGame.Character
{
    // This namespace is used to organize character-related scripts

    public class Enemy : MonoBehaviour
    {
        public  int damage = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
         
        }

        public void PrintDamage()
        {
         Debug.Log("Enemy damage"+ damage);
        }   
    // Update is called once per frame
        void Update()
        {
            
        }
    }
}