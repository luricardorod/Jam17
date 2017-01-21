using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour {
    public level[] levelsInfo;
 
    public struct enemy
    {
        public Vector2 vector2Position;
        public int life;
    }
    public struct level
    {
        public enemy[] enemies;
        public int iNumberEnemies;
        public int iNumberBombs;
    }
    void Start()
    {
        levelsInfo = new level[5];
        levelsInfo[0].iNumberBombs = 2;
        levelsInfo[0].iNumberEnemies = 5;
        levelsInfo[0].enemies = new enemy[levelsInfo[0].iNumberEnemies];
        levelsInfo[0].enemies[0].life = 5;
        levelsInfo[0].enemies[0].vector2Position.x = -60;
        levelsInfo[0].enemies[0].vector2Position.y = 60;
        levelsInfo[0].enemies[1].life = 4;
        levelsInfo[0].enemies[1].vector2Position.x = -30;
        levelsInfo[0].enemies[1].vector2Position.y = 30;
        levelsInfo[0].enemies[2].life = 5;
        levelsInfo[0].enemies[2].vector2Position.x = 0;
        levelsInfo[0].enemies[2].vector2Position.y = 0;
        levelsInfo[0].enemies[3].life = 4;
        levelsInfo[0].enemies[3].vector2Position.x = 30;
        levelsInfo[0].enemies[3].vector2Position.y = -30;
        levelsInfo[0].enemies[4].life = 5;
        levelsInfo[0].enemies[4].vector2Position.x = 60;
        levelsInfo[0].enemies[4].vector2Position.y = -60;

        levelsInfo[1].iNumberBombs = 2;
        levelsInfo[1].iNumberEnemies = 1;
        levelsInfo[1].enemies = new enemy[levelsInfo[1].iNumberEnemies];
        levelsInfo[1].enemies[0].life = 5;
        levelsInfo[1].enemies[0].vector2Position.x = 0;
        levelsInfo[1].enemies[0].vector2Position.y = 0;
    }


}
