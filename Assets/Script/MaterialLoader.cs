using UnityEngine;

public class MaterialLoader : MonoBehaviour
{
    public Material[] loadedBodyMaterials;
    public Material[] loadedHatMaterials;
    public Material[] loadedDotMaterials;


    private string bodyMaterialsPath = "CharacterMaterials/Body";
 
    private string hatMaterialsPath = "CharacterMaterials/Hats";

    private string dotMaterialPath = "CharacterMaterials/Dots";

    void Awake()
    {
        loadedBodyMaterials = Resources.LoadAll<Material>(bodyMaterialsPath);
        loadedHatMaterials = Resources.LoadAll<Material>(hatMaterialsPath);
        loadedDotMaterials = Resources.LoadAll<Material>(dotMaterialPath);
    }
}



