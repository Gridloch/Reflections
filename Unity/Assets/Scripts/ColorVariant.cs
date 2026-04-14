using UnityEngine;

public class ColorVariant : MonoBehaviour
{
    // Todo:
    // - Make rug log to console on click
    // - log colour on click
    // - change colour on click (should cycle through rainbow)
    // - add variable to change which colour array gets used on object (int, string or enum to select array?)
    // - save value for switching scenes / changing page

    public int currentColorList = 0;
    public int customisationID = -1;
    
    private int currentColor = 0;
    private SpriteRenderer m_SpriteRenderer;
    static Color[] lightColorList = 
    {
        new Color(1f, 0.8f, 0.9f), // Rose
        new Color(1f, 0.8f, 0.8f), // Red
        new Color(1f, 0.85f, 0.75f), // Orange
        new Color(1f, 1f, 0.8f), // Yellow
        new Color(0.9f, 1f, 0.8f), // Lime
        new Color(0.8f, 1f, 0.8f), // Green
        new Color(0.8f, 1f, 0.9f), // Teal
        new Color(0.8f, 1f, 1f), // Cyan
        new Color(0.8f, 0.9f, 1f), // Blue
        new Color(0.8f, 0.8f, 1f), // Indigo
        new Color(0.9f, 0.8f, 1f), // Purple
        new Color(1f, 0.8f, 1f), // Magenta
    };
    static Color[] mediumColorList = 
    {
        new Color(0.8f, 0.4f, 0.6f), // Rose
        new Color(0.8f, 0.4f, 0.4f), // Red
        new Color(0.9f, 0.6f, 0.4f), // Orange
        new Color(0.8f, 0.8f, 0.4f), // Yellow
        new Color(0.6f, 0.8f, 0.4f), // Lime
        new Color(0.4f, 0.8f, 0.4f), // Green
        new Color(0.4f, 0.8f, 0.6f), // Teal
        new Color(0.4f, 0.8f, 0.8f), // Cyan
        new Color(0.4f, 0.6f, 0.8f), // Blue
        new Color(0.4f, 0.4f, 0.8f), // Indigo
        new Color(0.6f, 0.4f, 0.8f), // Purple
        new Color(0.8f, 0.4f, 0.8f), // Magenta
    };
    static Color[] darkColorList = 
    {
        new Color(0.6f, 0.2f, 0.4f), // Rose
        new Color(0.6f, 0.2f, 0.2f), // Red
        new Color(0.7f, 0.4f, 0.2f), // Orange
        new Color(0.6f, 0.6f, 0.2f), // Yellow
        new Color(0.4f, 0.6f, 0.2f), // Lime
        new Color(0.2f, 0.6f, 0.2f), // Green
        new Color(0.2f, 0.6f, 0.4f), // Teal
        new Color(0.2f, 0.6f, 0.6f), // Cyan
        new Color(0.2f, 0.4f, 0.6f), // Blue
        new Color(0.2f, 0.2f, 0.5f), // Indigo
        new Color(0.4f, 0.2f, 0.6f), // Purple
        new Color(0.6f, 0.2f, 0.6f), // Magenta
    };

    Color[] colorList;

    void Start()
    {
        // Use the correct colour list for the customisation type
        switch(currentColorList) 
        {
        case 1:
            colorList = mediumColorList;
            break;
        case 2:
            colorList = darkColorList;
            break;
        default:
            colorList = lightColorList;
            break;
        }

        // Load current colour
        switch (customisationID)
        {
            case 1:
                currentColor = SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenEntryWall;
                break;
            case 2:
                currentColor = SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenEntryRug;
                break;
            case 3:
                currentColor = SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenWall;
                break;
            case 4:
                currentColor = SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenCounter;
                break;
            default:
                currentColor = 0;
                break;
        }

        //Fetch the SpriteRenderer from the GameObject
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //Set the GameObject's Color quickly to a set Color (blue)
        m_SpriteRenderer.color = colorList[currentColor];
    }

    void OnMouseDown(){
        // Update colour
        if (currentColor < colorList.Length - 1)
        {
            currentColor++;
            m_SpriteRenderer.color = colorList[currentColor];
        } else
        {
            currentColor = 0;
            m_SpriteRenderer.color = colorList[currentColor];
        }

        // Save new colour
        switch (customisationID)
        {
            case 1:
                SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenEntryWall = currentColor;
                break;
            case 2:
                SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenEntryRug = currentColor;
                break;
            case 3:
                SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenWall = currentColor;
                break;
            case 4:
                SaveLoadManager.Instance.playerData.GetRoomCustomisation().kitchenCounter = currentColor;
                break;
        }
        SaveLoadManager.SaveJSON();
        // Debug.Log("Sprite Clicked. Colour: " + currentColor.ToString());
    }
}
