using UnityEngine;

public class ColorVariant : MonoBehaviour
{
    // Todo:
    // - Make rug log to console on click
    // - log colour on click
    // - change colour on click (should cycle through rainbow)
    // - add variable to change which colour array gets used on object (int, string or enum to select array?)


    // public List<GameObject> prefabList = new List<GameObject>();
    // [SerializeField] public GameObject DayVariant;
    // [SerializeField] public GameObject EveningVariant;
    // [SerializeField] public GameObject NightVariant;

    // void Start()
    // {
    //     prefabList.Add(Prefab1);
    //     prefabList.Add(Prefab2);
    //     prefabList.Add(Prefab3);
        
    //     int prefabIndex = UnityEngine.Random.Range(0,prefabList.Count-1);
    //     Instantiate(prefabList[prefabIndex]);

    // }

    public int currentColorList = 0;
    public int currentColor = 0;
    
    SpriteRenderer m_SpriteRenderer;
    static Color[] lightColorList = 
    {
        new Color(1f, 0.8f, 0.9f), // Rose
        new Color(1f, 0.8f, 0.8f), // Red
        new Color(1f, 0.9f, 0.8f), // Orange
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
        new Color(0.8f, 0.6f, 0.4f), // Orange
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

    Color[] colorList;

    void Start()
    {
        switch(currentColorList) 
        {
        case 1:
            colorList = mediumColorList;
            break;
        // case 2:
        //     colorList = drakColorList;
        //     break;
        default:
            colorList = lightColorList;
            break;
        }

        //Fetch the SpriteRenderer from the GameObject
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //Set the GameObject's Color quickly to a set Color (blue)
        m_SpriteRenderer.color = colorList[currentColor];
    }

    void OnMouseDown(){
        if (currentColor < colorList.Length - 1)
        {
            currentColor++;
            m_SpriteRenderer.color = colorList[currentColor];
        } else
        {
            currentColor = 0;
            m_SpriteRenderer.color = colorList[currentColor];
        }
        Debug.Log("Sprite Clicked. Colour: " + currentColor.ToString());
    }
}
