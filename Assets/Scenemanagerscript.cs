using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanagerscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene (int sceneId){
        SceneManager.LoadScene (sceneId,LoadSceneMode.Single);
    }

    public void LoadNextScene (){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1,LoadSceneMode.Single);
    }

    public void RestartGaime()
    {
        SceneManager.LoadScene(0);
    }
}
