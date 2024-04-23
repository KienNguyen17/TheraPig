using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool hasRun=false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene() {
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadScene(int index) {
        if (!hasRun) {
            SceneManager.LoadSceneAsync(index);
            hasRun = true;
        }
       
    }
}
