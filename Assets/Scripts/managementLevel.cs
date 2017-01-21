using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementLevel : MonoBehaviour
{
    GameObject[] goEnemies;
    public GameObject goLevelsInfo;
    Vector2 Vect2TouchAttack;
    public GameObject goEnemyStatic;
    private bool flag = false;

    // Use this for initialization
    void Start ()
    {
        CreateLevel(1);
    }

    // Update is called once per frame
    void Update ()
    {       
        
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            goEnemies = GameObject.FindGameObjectsWithTag("enemy");
            Vect2TouchAttack = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Click pressed (left or rigth).");

            this.GetComponent<Animator>().SetBool("bTouch", true);
            this.transform.position = Vect2TouchAttack;


            Debug.Log(goEnemies.Length);
            foreach (GameObject enemy in goEnemies)
            {
                enemy.GetComponent<Scr_Enemy>().DoDamage(Vect2TouchAttack);
                //if (enemy.getLife() > 0)
                //Ejecutar funcion de hacer daño
                //enemy.GetDamage(Vect2TouchAttack);
            }

        }
        
    }

    void CreateLevel(int nevel)
    {
        levels levelsInfo = goLevelsInfo.GetComponent<levels>();
        int numberOfEnemies = levelsInfo.levelsInfo[nevel].iNumberEnemies;
        for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject newEnemy = Instantiate(goEnemyStatic, new Vector3(levelsInfo.levelsInfo[nevel].enemies[i].vector2Position.x/30, levelsInfo.levelsInfo[nevel].enemies[i].vector2Position.y/30, 0), Quaternion.identity);
            newEnemy.GetComponent<Scr_Enemy>().EnemyHP = levelsInfo.levelsInfo[nevel].enemies[i].life;
        }
    }
}