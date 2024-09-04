using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClothingButtonScript : MonoBehaviour
{

    public GameObject Clothing;
    private GameObject initializedPrefab;
    bool active = false;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        transform.GetChild(0).GetComponent<Image>().sprite = Clothing.GetComponent<SpriteRenderer>().sprite;
        // image.sprite = Clothing.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if (active == false){
            Activate();
        }
        else if (active == true){
            Deactivate();
        }
    }

    void Activate(){
        image.color = new Color (0,1,0,0.5f);
        if (Clothing.tag != null || Clothing.tag != "Accessory"){
            foreach (GameObject i in GameObject.FindGameObjectsWithTag(Clothing.tag)){
                //Destroy(i);
                foreach(ClothingButtonScript cbs in FindObjectsOfType<ClothingButtonScript>()){
                    if (cbs.Clothing.tag == Clothing.tag && cbs.Clothing != Clothing){
                        cbs.Deactivate();
                    }
                }
            }
            GameObject.FindGameObjectsWithTag(Clothing.tag);
        }
        initializedPrefab = Instantiate(Clothing, GameObject.FindWithTag("Player").transform);
        if (Clothing.tag == "Accessory" || Clothing.tag == "Glasses"){
            initializedPrefab.transform.position += new Vector3(0,0,-1.5f);
        }
        active = true;
    }

    void Deactivate(){
        image.color = new Color (1,1,1,0.05f);
        Destroy(initializedPrefab);
        active = false;
    }
}
