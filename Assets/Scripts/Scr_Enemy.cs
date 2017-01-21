using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemy : MonoBehaviour
{

    public Sprite Light5, Light4, Light3, Light2, Light1;
    public int EnemyHP = 5;
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
        gameObject.GetComponent<Animator>().SetInteger("iEnemyHp", EnemyHP);
        if (EnemyHP <= 0)Invoke("vAutoDestroy", 0.5f/*anim.clip.length*/);        
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
            EnemyHP -= (int)Mathf.Ceil((1 - (fDistancia / fRadio)) * 5.0f);
            Debug.Log((1 - (fDistancia / fRadio)) * 5.0f);
            Debug.Log((1 - (fDistancia / fRadio)));
            Debug.Log((int)Mathf.Ceil((1 - (fDistancia / fRadio)) * 5.0f));

            vChangeSprite();
        }
    }
}