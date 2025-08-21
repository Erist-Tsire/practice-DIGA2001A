using UnityEngine;

public class testingscript : MonoBehaviour
{
    public PotionData potionData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Potion: " + potionData.potionName + " heals for " + potionData.healAmount);
    }
    
}
