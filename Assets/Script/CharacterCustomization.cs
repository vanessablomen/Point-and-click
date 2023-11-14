using UnityEngine;
using TMPro;

public class CharacterCustomization : MonoBehaviour
{
    [SerializeField] private Renderer bodyRenderer;
    [SerializeField] private Renderer hatRenderer;
    [SerializeField] private Renderer dotRenderer;  

    [SerializeField] private Material[] bodyMaterials;
    [SerializeField] private Material[] hatMaterials;
    [SerializeField] private Material[] dotMaterials;

    private int bodyID;
    private int hatID;
    private int dotID;


    [SerializeField] private MaterialLoader materialLoader;

    void Start()


    {
        if (materialLoader != null)
        {
            bodyMaterials = materialLoader.loadedBodyMaterials;
            hatMaterials = materialLoader.loadedHatMaterials;
            dotMaterials = materialLoader.loadedDotMaterials;
        }

        SetItem(bodyRenderer, bodyMaterials, bodyID);
        SetItem(hatRenderer, hatMaterials, hatID);
        SetItem(dotRenderer, dotMaterials, dotID);



    }


    public void SelectBody(bool isForward)
    {
        bodyID = ChangeSelection(bodyID, isForward);
        SetItem(bodyRenderer, bodyMaterials, bodyID);
    }

    public void SelectHat(bool isForward)
    {
        hatID = ChangeSelection(hatID, isForward);
        SetItem(hatRenderer, hatMaterials, hatID);
    }

    public void SelectDots(bool isForward)
    {
        dotID = ChangeSelection(dotID, isForward);
        SetItem(dotRenderer, dotMaterials, dotID);
    }

    private int ChangeSelection(int currentIndex, bool isForward)
    {
        int arrayLength = 5;

        if (isForward)
        {
            currentIndex = (currentIndex + 1) % arrayLength;
        }
        else
        {
            currentIndex = (currentIndex - 1 + arrayLength) % arrayLength;
        }

        return currentIndex;
    }

    private void SetItem(Renderer renderer, Material[] materials, int id)
    {
        if (materials == null || materials.Length == 0 || id < 0 || id >= materials.Length) return;

        renderer.material = materials[id];
    }

    private void UpdateMaterialDisplay()
    {
        if (bodyMaterials != null && bodyMaterials.Length > 0)
            SetItem(bodyRenderer, bodyMaterials, bodyID);

        if (hatMaterials != null && hatMaterials.Length > 0)
            SetItem(hatRenderer, hatMaterials, hatID);
          
        if (dotMaterials != null && dotMaterials.Length > 0)  
            SetItem(dotRenderer, dotMaterials, dotID);
    }
}


