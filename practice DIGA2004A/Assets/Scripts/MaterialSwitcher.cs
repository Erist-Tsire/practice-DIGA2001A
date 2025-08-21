using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{
    public Material alternateMaterial;
    public Renderer rend;
    private Material originalMaterial;
    private bool usingAlternate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    private void Awake()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            originalMaterial = rend.material;
        }
    }

    public void ToggleMaterial()
    {
        if(rend == null || alternateMaterial == null) return;
        if(!usingAlternate)
        {
            rend.material = alternateMaterial;
            usingAlternate = true;
        }
        else
        {
            rend.material = originalMaterial;
            usingAlternate = false;
        }
    }
    // Update is called once per frame
   
}
