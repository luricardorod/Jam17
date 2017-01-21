using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemy : MonoBehaviour
{
    public Sprite Light5, Light4, Light3, Light2, Light1;
    public int iEnemyHP = 5;
    public int iRadio = 150;

    //Use this for initialization
    void Start() { }

    //Update is called once per frame
    void Update() { }

    //Calcula la distancia entre el touch y el target
    public float iMagnitud(Vector2 Vector)
    {
        return Mathf.Sqrt((Vector.x * Vector.x) + (Vector.y * Vector.y));
    }
    /*
     * Light5.png
     * Light4.png
     * Light3.png
     * Light2.png
     * Light1.png
     */
    public void vChangeSprite()
    {
        switch (iEnemyHP)
        {
            case 0:
                //Codigo de cambiar sprite
                //Invoke("vAutoDestroy", /*anim.clip.length*/);
                break;
            case 1:
                //Codigo de cambiar sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = Light1;
                break;
            case 2:
                //Codigo de cambiar sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = Light2;
                break;
            case 3:
                //Codigo de cambiar sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = Light3;
                break;
            case 4:
                //Codigo de cambiar sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = Light4;
                break;
            case 5:
                //Codigo de cambiar sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = Light5;
                break;
            default:
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
        if (fDistancia < iRadio)
        {
            iEnemyHP -= (int)Mathf.Ceil((1 - (fDistancia / iRadio)) * 5);
        }
        //Comprueba si el enemigo está muerto
        if (iEnemyHP <= 0)
        {

        }
        else
        {

        }
    }
}