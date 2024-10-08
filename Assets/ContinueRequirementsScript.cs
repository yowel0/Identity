using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueRequirementsScript : MonoBehaviour
{
    public List<GameObject> requirements = new List<GameObject>();
    public GameObject player;

    [Space]
    public GameObject restartScreen;
    public Sprite screenSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if(isActiveInScene() == true){
            print("trueue");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            GameObject inst = Instantiate(restartScreen, GameObject.Find("Canvas").transform);
            inst.GetComponent<Image>().sprite = screenSprite;
        }
    }

    bool isActiveInScene(){
        if (player.transform.childCount == 0){
            return false;
        }
        int matches = 0;
        foreach (Transform child in player.transform){
            foreach (GameObject requirement in requirements){
                if (child.name == requirement.name + "(Clone)"){
                    matches++;
                }
            }
        }
        if (matches == requirements.Count){
            return true;
        }
        else{
            return false;
        }
    }
}
