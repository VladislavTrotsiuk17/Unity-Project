using UnityEngine;

public class UIBallCollorChange : MonoBehaviour
{  
    [SerializeField] private Material materialRenderer;
    [SerializeField] private Color[] colors;

    public int currentColorIndex = 0;

    private void Update()
    {
        SetColor(currentColorIndex);
    }
    private void SetColor(int colorIndex)
    {
        if (materialRenderer != null)
        {
            materialRenderer.color = colors[colorIndex];
        }
    }

    public void LeftButton()
    {
        if (currentColorIndex > 0) 
        {
            Debug.Log("-");
            currentColorIndex--; 
        }
        
    }
    public void RightButton()
    {
        if (currentColorIndex < colors.Length -1)
        {
            Debug.Log("+");
            currentColorIndex++;
        }

    }
}
