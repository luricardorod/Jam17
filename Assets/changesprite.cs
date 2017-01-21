using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changesprite : MonoBehaviour {

    public Sprite RedCircle;
    public Sprite BlueCircle;

    float timer = 1f;
    float delay = 1f;

    private void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = RedCircle;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            if(this.gameObject.GetComponent<SpriteRenderer>().sprite==RedCircle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueCircle;
                timer = delay;
                return;
            }
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == BlueCircle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RedCircle;
                timer = delay;
                return;
            }
        }
    }
}