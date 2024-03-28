using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspaperDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGoodEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision) {
        if(collision.GetComponent<Collider2D>().CompareTag("Newspaper")){
            isGoodEnd = true;
        }
    }

    // void OnTriggerExit2D(Collider2D collision) {
    //     if(collision.GetComponent<Collider2D>().CompareTag("Newspaper")){
    //         isGoodEnd = false;
    //     }
    // }
}
