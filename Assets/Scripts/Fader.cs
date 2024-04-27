using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Fader : MonoBehaviour
{
    SpriteRenderer renderer;
    bool isFading = false;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    [YarnCommand("fade")]
    public IEnumerator FadeIn() {
        isFading = true;
        for (float i=0; i<=1; i+=0.01f) {
            renderer.color = new Color(0,0,0,i);
            yield return new WaitForSeconds(0.03f);
        }
        for (float i=1; i>=0; i-=0.01f) {
            renderer.color = new Color(0,0,0,i);
            yield return new WaitForSeconds(0.03f);
        }
        isFading = false;
    }
}
