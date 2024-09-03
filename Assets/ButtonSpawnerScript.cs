using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawnerScript : MonoBehaviour
{
    public GameObject button;
    public GameObject uiParent;
    public List<GameObject> clothes;

    // Start is called before the first frame update
    void Start()
    {
        float offset = 200;
        foreach (GameObject clothing in clothes){
            GameObject instantiatedButton = Instantiate(button,uiParent.transform);
            instantiatedButton.GetComponent<ClothingButtonScript>().Clothing = clothing;
            instantiatedButton.GetComponent<RectTransform>().localPosition = new Vector3(0,0,0);
            offset += 200;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
