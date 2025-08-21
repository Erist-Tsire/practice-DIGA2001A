using UnityEngine;
using MyGame.Character;

public class Testing : MonoBehaviour
{
    public Hero myHero;
    public Enemy myEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myHero.PrintHealth();
        myEnemy.PrintDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
