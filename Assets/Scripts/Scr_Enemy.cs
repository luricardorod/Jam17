using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemy : MonoBehaviour
{
    public Sprite Light5, Light4, Light3, Light2, Light1;
    public int iEnemyHP = 5;
    private float fRadio = 1.42f;

    //Use this for initialization
    void Start() { vChangeSprite(); }

    //Update is called once per frame
    void Update() { }

    //Calcula la distancia entre el touch y el target
    public float iMagnitud(Vector2 Vector)
    {
        return Mathf.Sqrt((Vector.x * Vector.x) + (Vector.y * Vector.y));
    }

    public void vChangeSprite()
    {
        switch (iEnemyHP)
        {
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = Light1;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = Light2;
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = Light3;
                break;
            case 4:
                gameObject.GetComponent<SpriteRenderer>().sprite = Light4;
                break;
            case 5:
                gameObject.GetComponent<SpriteRenderer>().sprite = Light5;
                break;
            default:
                Invoke("vAutoDestroy", 0.5f/*anim.clip.length*/);
                break;
        }
    }

    void vAutoDestroy()
    {
        Object.Destroy(this.gameObject);
    }

    //Calcula el daño que va a inflingir al target
    public void DoDamage(Vector2 Touch)
    {
        Vector2 Pos = transform.position;

        float fDistancia = iMagnitud(Pos - Touch);
        Debug.Log("pos: " + Pos.x + " " + Pos.y);
        Debug.Log("touch: " + Touch.x + " " + Touch.y);
        Debug.Log("distancia: " + fDistancia);
        if (fDistancia <= fRadio)
        {
            iEnemyHP -= (int)Mathf.Ceil((1 - (fDistancia / fRadio)) * 5.0f);
            Debug.Log((1 - (fDistancia / fRadio)) * 5.0f);
            Debug.Log((1 - (fDistancia / fRadio)));
            Debug.Log((int)Mathf.Ceil((1 - (fDistancia / fRadio)) * 5.0f));

            vChangeSprite();
        }
    }
}