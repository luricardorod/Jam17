using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementLevel : MonoBehaviour
{
    public GameObject[] goEnemies;
    public Vector2 Vect2TouchAttack;
    // Use this for initialization
    void Start ()
    {
        goEnemies = GameObject.FindGameObjectsWithTag("enemie");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0)
        {
            Touch tTouch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (tTouch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    break;
                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    break;
                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    Vect2TouchAttack = tTouch.position;

                    foreach (GameObject enemy in goEnemies)
                    {
                        //if (enemy.getLife() > 0)
                            //enemy.GetDamage(Vect2TouchAttack);
                    }
                    break;
            }
        }
        /*
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Vect2TouchAttack = Input.mousePosition;
            Debug.Log("Click pressed (left or rigth).");

            foreach (GameObject enemy in enemies)
            {
                //if (enemy.getLife() > 0)
                //Ejecutar funcion de hacer daño
                //enemy.GetDamage(Vect2TouchAttack);
            }
        }
        */
    }
}