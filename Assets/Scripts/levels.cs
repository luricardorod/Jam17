﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour
{
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
        levelsInfo = new level[10];

        levelsInfo[0].iNumberBombs = 1;
        levelsInfo[0].iNumberEnemies = 1;
        levelsInfo[0].enemies = new enemy[levelsInfo[0].iNumberEnemies];
        levelsInfo[0].enemies[0].life = 5;
        levelsInfo[0].enemies[0].vector2Position.x = 0;
        levelsInfo[0].enemies[0].vector2Position.y = 0;

        levelsInfo[1].iNumberBombs = 1;
        levelsInfo[1].iNumberEnemies = 5;
        levelsInfo[1].enemies = new enemy[levelsInfo[1].iNumberEnemies];
        levelsInfo[1].enemies[0].life = 5;
        levelsInfo[1].enemies[0].vector2Position.x = 0;
        levelsInfo[1].enemies[0].vector2Position.y = 0;
        levelsInfo[1].enemies[1].life = 4;
        levelsInfo[1].enemies[1].vector2Position.x = 30;
        levelsInfo[1].enemies[1].vector2Position.y = 0;
        levelsInfo[1].enemies[2].life = 3;
        levelsInfo[1].enemies[2].vector2Position.x = 60;
        levelsInfo[1].enemies[2].vector2Position.y = 0;
        levelsInfo[1].enemies[3].life = 2;
        levelsInfo[1].enemies[3].vector2Position.x = 90;
        levelsInfo[1].enemies[3].vector2Position.y = 0;
        levelsInfo[1].enemies[4].life = 1;
        levelsInfo[1].enemies[4].vector2Position.x = 120;
        levelsInfo[1].enemies[4].vector2Position.y = 0;

        levelsInfo[2].iNumberBombs = 2;
        levelsInfo[2].iNumberEnemies = 5;
        levelsInfo[2].enemies = new enemy[levelsInfo[2].iNumberEnemies];
        levelsInfo[2].enemies[0].life = 5;
        levelsInfo[2].enemies[0].vector2Position.x = 0;
        levelsInfo[2].enemies[0].vector2Position.y = 0;
        levelsInfo[2].enemies[1].life = 4;
        levelsInfo[2].enemies[1].vector2Position.x = 30;
        levelsInfo[2].enemies[1].vector2Position.y = 0;
        levelsInfo[2].enemies[2].life = 3;
        levelsInfo[2].enemies[2].vector2Position.x = 60;
        levelsInfo[2].enemies[2].vector2Position.y = 0;
        levelsInfo[2].enemies[3].life = 2;
        levelsInfo[2].enemies[3].vector2Position.x = 90;
        levelsInfo[2].enemies[3].vector2Position.y = 0;
        levelsInfo[2].enemies[4].life = 5;
        levelsInfo[2].enemies[4].vector2Position.x = 120;
        levelsInfo[2].enemies[4].vector2Position.y = 0;

        levelsInfo[3].iNumberBombs = 2;
        levelsInfo[3].iNumberEnemies = 5;
        levelsInfo[3].enemies = new enemy[levelsInfo[3].iNumberEnemies];
        levelsInfo[3].enemies[0].life = 5;
        levelsInfo[3].enemies[0].vector2Position.x = -60;
        levelsInfo[3].enemies[0].vector2Position.y = 60;
        levelsInfo[3].enemies[1].life = 4;
        levelsInfo[3].enemies[1].vector2Position.x = -30;
        levelsInfo[3].enemies[1].vector2Position.y = 30;
        levelsInfo[3].enemies[2].life = 5;
        levelsInfo[3].enemies[2].vector2Position.x = 0;
        levelsInfo[3].enemies[2].vector2Position.y = 0;
        levelsInfo[3].enemies[3].life = 4;
        levelsInfo[3].enemies[3].vector2Position.x = 30;
        levelsInfo[3].enemies[3].vector2Position.y = -30;
        levelsInfo[3].enemies[4].life = 5;
        levelsInfo[3].enemies[4].vector2Position.x = 60;
        levelsInfo[3].enemies[4].vector2Position.y = -60;

        levelsInfo[4].iNumberBombs = 2;
        levelsInfo[4].iNumberEnemies = 9;
        levelsInfo[4].enemies = new enemy[levelsInfo[4].iNumberEnemies];
        levelsInfo[4].enemies[0].life = 1;
        levelsInfo[4].enemies[0].vector2Position.x = -30;
        levelsInfo[4].enemies[0].vector2Position.y = 30;
        levelsInfo[4].enemies[1].life = 2;
        levelsInfo[4].enemies[1].vector2Position.x = 0;
        levelsInfo[4].enemies[1].vector2Position.y = 30;
        levelsInfo[4].enemies[2].life = 1;
        levelsInfo[4].enemies[2].vector2Position.x = 30;
        levelsInfo[4].enemies[2].vector2Position.y = 30;
        levelsInfo[4].enemies[3].life = 2;
        levelsInfo[4].enemies[3].vector2Position.x = -30;
        levelsInfo[4].enemies[3].vector2Position.y = 0;
        levelsInfo[4].enemies[4].life = 5;
        levelsInfo[4].enemies[4].vector2Position.x = 0;
        levelsInfo[4].enemies[4].vector2Position.y = 0;
        levelsInfo[4].enemies[5].life = 5;
        levelsInfo[4].enemies[5].vector2Position.x = 30;
        levelsInfo[4].enemies[5].vector2Position.y = 0;
        levelsInfo[4].enemies[6].life = 5;
        levelsInfo[4].enemies[6].vector2Position.x = -30;
        levelsInfo[4].enemies[6].vector2Position.y = -30;
        levelsInfo[4].enemies[7].life = 5;
        levelsInfo[4].enemies[7].vector2Position.x = 0;
        levelsInfo[4].enemies[7].vector2Position.y = -30;
        levelsInfo[4].enemies[8].life = 5;
        levelsInfo[4].enemies[8].vector2Position.x = 30;
        levelsInfo[4].enemies[8].vector2Position.y = -30;

        levelsInfo[5].iNumberBombs = 2;
        levelsInfo[5].iNumberEnemies = 9;
        levelsInfo[5].enemies = new enemy[levelsInfo[5].iNumberEnemies];
        levelsInfo[5].enemies[0].life = 1;
        levelsInfo[5].enemies[0].vector2Position.x = -90;
        levelsInfo[5].enemies[0].vector2Position.y = -90;
        levelsInfo[5].enemies[1].life = 5;
        levelsInfo[5].enemies[1].vector2Position.x = -60;
        levelsInfo[5].enemies[1].vector2Position.y = -60;
        levelsInfo[5].enemies[2].life = 1;
        levelsInfo[5].enemies[2].vector2Position.x = 90;
        levelsInfo[5].enemies[2].vector2Position.y = 90;
        levelsInfo[5].enemies[3].life = 5;
        levelsInfo[5].enemies[3].vector2Position.x = 60;
        levelsInfo[5].enemies[3].vector2Position.y = 60;
        levelsInfo[5].enemies[4].life = 3;
        levelsInfo[5].enemies[4].vector2Position.x = -60;
        levelsInfo[5].enemies[4].vector2Position.y = 0;
        levelsInfo[5].enemies[5].life = 3;
        levelsInfo[5].enemies[5].vector2Position.x = 60;
        levelsInfo[5].enemies[5].vector2Position.y = 0;
        levelsInfo[5].enemies[6].life = 3;
        levelsInfo[5].enemies[6].vector2Position.x = 0;
        levelsInfo[5].enemies[6].vector2Position.y = -60;
        levelsInfo[5].enemies[7].life = 3;
        levelsInfo[5].enemies[7].vector2Position.x = 0;
        levelsInfo[5].enemies[7].vector2Position.y = 60;
        levelsInfo[5].enemies[8].life = 4;
        levelsInfo[5].enemies[8].vector2Position.x = 0;
        levelsInfo[5].enemies[8].vector2Position.y = 0;

        levelsInfo[6].iNumberBombs = 2;
        levelsInfo[6].iNumberEnemies = 14;
        levelsInfo[6].enemies = new enemy[levelsInfo[6].iNumberEnemies];
        levelsInfo[6].enemies[0].life = 5;
        levelsInfo[6].enemies[0].vector2Position.x = -90;
        levelsInfo[6].enemies[0].vector2Position.y = -30;
        levelsInfo[6].enemies[1].life = 3;
        levelsInfo[6].enemies[1].vector2Position.x = -30;
        levelsInfo[6].enemies[1].vector2Position.y = -30;
        levelsInfo[6].enemies[2].life = 5;
        levelsInfo[6].enemies[2].vector2Position.x = 90;
        levelsInfo[6].enemies[2].vector2Position.y = 30;
        levelsInfo[6].enemies[3].life = 1;
        levelsInfo[6].enemies[3].vector2Position.x = 0;
        levelsInfo[6].enemies[3].vector2Position.y = 60;
        levelsInfo[6].enemies[4].life = 3;
        levelsInfo[6].enemies[4].vector2Position.x = -60;
        levelsInfo[6].enemies[4].vector2Position.y = 0;
        levelsInfo[6].enemies[5].life = 3;
        levelsInfo[6].enemies[5].vector2Position.x = 60;
        levelsInfo[6].enemies[5].vector2Position.y = 0;
        levelsInfo[6].enemies[6].life = 1;
        levelsInfo[6].enemies[6].vector2Position.x = 0;
        levelsInfo[6].enemies[6].vector2Position.y = -60;
        levelsInfo[6].enemies[7].life = 2;
        levelsInfo[6].enemies[7].vector2Position.x = 0;
        levelsInfo[6].enemies[7].vector2Position.y = -30;
        levelsInfo[6].enemies[8].life = 3;
        levelsInfo[6].enemies[8].vector2Position.x = 30;
        levelsInfo[6].enemies[8].vector2Position.y = -30;
        levelsInfo[6].enemies[9].life = 3;
        levelsInfo[6].enemies[9].vector2Position.x = 90;
        levelsInfo[6].enemies[9].vector2Position.y = -30;
        levelsInfo[6].enemies[10].life = 3;
        levelsInfo[6].enemies[10].vector2Position.x = 30;
        levelsInfo[6].enemies[10].vector2Position.y = 30;
        levelsInfo[6].enemies[11].life = 2;
        levelsInfo[6].enemies[11].vector2Position.x = 0;
        levelsInfo[6].enemies[11].vector2Position.y = 30;
        levelsInfo[6].enemies[12].life = 3;
        levelsInfo[6].enemies[12].vector2Position.x = -30;
        levelsInfo[6].enemies[12].vector2Position.y = 30;
        levelsInfo[6].enemies[13].life = 3;
        levelsInfo[6].enemies[13].vector2Position.x = -90;
        levelsInfo[6].enemies[13].vector2Position.y = 30;

        levelsInfo[7].iNumberBombs = 3;
        levelsInfo[7].iNumberEnemies = 19;
        levelsInfo[7].enemies = new enemy[levelsInfo[7].iNumberEnemies];
        levelsInfo[7].enemies[0].life = 5;
        levelsInfo[7].enemies[0].vector2Position.x = -60;
        levelsInfo[7].enemies[0].vector2Position.y = 60;
        levelsInfo[7].enemies[1].life = 4;
        levelsInfo[7].enemies[1].vector2Position.x = -30;
        levelsInfo[7].enemies[1].vector2Position.y = 60;
        levelsInfo[7].enemies[2].life = 5;
        levelsInfo[7].enemies[2].vector2Position.x = 0;
        levelsInfo[7].enemies[2].vector2Position.y = 60;
        levelsInfo[7].enemies[3].life = 4;
        levelsInfo[7].enemies[3].vector2Position.x = 30;
        levelsInfo[7].enemies[3].vector2Position.y = 60;
        levelsInfo[7].enemies[4].life = 5;
        levelsInfo[7].enemies[4].vector2Position.x = 60;
        levelsInfo[7].enemies[4].vector2Position.y = 60;
        levelsInfo[7].enemies[5].life = 4;
        levelsInfo[7].enemies[5].vector2Position.x = -60;
        levelsInfo[7].enemies[5].vector2Position.y = 30;
        levelsInfo[7].enemies[6].life = 4;
        levelsInfo[7].enemies[6].vector2Position.x = 60;
        levelsInfo[7].enemies[6].vector2Position.y = 30;
        levelsInfo[7].enemies[7].life = 4;
        levelsInfo[7].enemies[7].vector2Position.x = 0;
        levelsInfo[7].enemies[7].vector2Position.y = 30;
        levelsInfo[7].enemies[8].life = 3;
        levelsInfo[7].enemies[8].vector2Position.x = -60;
        levelsInfo[7].enemies[8].vector2Position.y = 0;
        levelsInfo[7].enemies[9].life = 3;
        levelsInfo[7].enemies[9].vector2Position.x = 0;
        levelsInfo[7].enemies[9].vector2Position.y = 0;
        levelsInfo[7].enemies[10].life = 3;
        levelsInfo[7].enemies[10].vector2Position.x = 60;
        levelsInfo[7].enemies[10].vector2Position.y = 0;
        levelsInfo[7].enemies[11].life = 4;
        levelsInfo[7].enemies[11].vector2Position.x = -60;
        levelsInfo[7].enemies[11].vector2Position.y = -30;
        levelsInfo[7].enemies[12].life = 4;
        levelsInfo[7].enemies[12].vector2Position.x = 0;
        levelsInfo[7].enemies[12].vector2Position.y = -30;
        levelsInfo[7].enemies[13].life = 4;
        levelsInfo[7].enemies[13].vector2Position.x = 60;
        levelsInfo[7].enemies[13].vector2Position.y = -30;
        levelsInfo[7].enemies[14].life = 5;
        levelsInfo[7].enemies[14].vector2Position.x = -60;
        levelsInfo[7].enemies[14].vector2Position.y = -60;
        levelsInfo[7].enemies[15].life = 4;
        levelsInfo[7].enemies[15].vector2Position.x = -30;
        levelsInfo[7].enemies[15].vector2Position.y = -60;
        levelsInfo[7].enemies[16].life = 4;
        levelsInfo[7].enemies[16].vector2Position.x = 0;
        levelsInfo[7].enemies[16].vector2Position.y = -60;
        levelsInfo[7].enemies[17].life = 4;
        levelsInfo[7].enemies[17].vector2Position.x = 30;
        levelsInfo[7].enemies[17].vector2Position.y = -60;
        levelsInfo[7].enemies[18].life = 5;
        levelsInfo[7].enemies[18].vector2Position.x = 60;
        levelsInfo[7].enemies[18].vector2Position.y = 60;

        levelsInfo[8].iNumberBombs = 2;
        levelsInfo[8].iNumberEnemies = 10;
        levelsInfo[8].enemies = new enemy[levelsInfo[8].iNumberEnemies];
        levelsInfo[8].enemies[0].life = 1;
        levelsInfo[8].enemies[0].vector2Position.x = -90;
        levelsInfo[8].enemies[0].vector2Position.y = 90;
        levelsInfo[8].enemies[1].life = 2;
        levelsInfo[8].enemies[1].vector2Position.x = -30;
        levelsInfo[8].enemies[1].vector2Position.y = 90;
        levelsInfo[8].enemies[2].life = 3;
        levelsInfo[8].enemies[2].vector2Position.x = 30;
        levelsInfo[8].enemies[2].vector2Position.y = 90;
        levelsInfo[8].enemies[3].life = 2;
        levelsInfo[8].enemies[3].vector2Position.x = 90;
        levelsInfo[8].enemies[3].vector2Position.y = 90;
        levelsInfo[8].enemies[4].life = 2;
        levelsInfo[8].enemies[4].vector2Position.x = -90;
        levelsInfo[8].enemies[4].vector2Position.y = 30;
        levelsInfo[8].enemies[5].life = 3;
        levelsInfo[8].enemies[5].vector2Position.x = -30;
        levelsInfo[8].enemies[5].vector2Position.y = 30;
        levelsInfo[8].enemies[6].life = 5;
        levelsInfo[8].enemies[6].vector2Position.x = 30;
        levelsInfo[8].enemies[6].vector2Position.y = 30;
        levelsInfo[8].enemies[7].life = 3;
        levelsInfo[8].enemies[7].vector2Position.x = -90;
        levelsInfo[8].enemies[7].vector2Position.y = -30;
        levelsInfo[8].enemies[8].life = 5;
        levelsInfo[8].enemies[8].vector2Position.x = -30;
        levelsInfo[8].enemies[8].vector2Position.y = -30;
        levelsInfo[8].enemies[9].life = 2;
        levelsInfo[8].enemies[9].vector2Position.x = -90;
        levelsInfo[8].enemies[9].vector2Position.y = -90;

        levelsInfo[9].iNumberBombs = 2;
        levelsInfo[9].iNumberEnemies = 16;
        levelsInfo[9].enemies = new enemy[levelsInfo[9].iNumberEnemies];
        levelsInfo[9].enemies[0].life = 4;
        levelsInfo[9].enemies[0].vector2Position.x = -90;
        levelsInfo[9].enemies[0].vector2Position.y = 30;
        levelsInfo[9].enemies[1].life = 5;
        levelsInfo[9].enemies[1].vector2Position.x = -90;
        levelsInfo[9].enemies[1].vector2Position.y = 0;
        levelsInfo[9].enemies[2].life = 4;
        levelsInfo[9].enemies[2].vector2Position.x = -90;
        levelsInfo[9].enemies[2].vector2Position.y = -30;
        levelsInfo[9].enemies[3].life = 4;
        levelsInfo[9].enemies[3].vector2Position.x = -60;
        levelsInfo[9].enemies[3].vector2Position.y = 0;
        levelsInfo[9].enemies[4].life = 4;
        levelsInfo[9].enemies[4].vector2Position.x = -30;
        levelsInfo[9].enemies[4].vector2Position.y = 30;
        levelsInfo[9].enemies[5].life = 4;
        levelsInfo[9].enemies[5].vector2Position.x = -30;
        levelsInfo[9].enemies[5].vector2Position.y = 0;
        levelsInfo[9].enemies[6].life = 4;
        levelsInfo[9].enemies[6].vector2Position.x = -30;
        levelsInfo[9].enemies[6].vector2Position.y = -30;
        levelsInfo[9].enemies[7].life = 3;
        levelsInfo[9].enemies[7].vector2Position.x = 0;
        levelsInfo[9].enemies[7].vector2Position.y = 60;
        levelsInfo[9].enemies[8].life = 3;
        levelsInfo[9].enemies[8].vector2Position.x = 0;
        levelsInfo[9].enemies[8].vector2Position.y = 30;
        levelsInfo[9].enemies[9].life = 3;
        levelsInfo[9].enemies[9].vector2Position.x = 0;
        levelsInfo[9].enemies[9].vector2Position.y = 0;
        levelsInfo[9].enemies[10].life = 3;
        levelsInfo[9].enemies[10].vector2Position.x = 0;
        levelsInfo[9].enemies[10].vector2Position.y = -30;
        levelsInfo[9].enemies[11].life = 3;
        levelsInfo[9].enemies[11].vector2Position.x = 0;
        levelsInfo[9].enemies[11].vector2Position.y = -60;
        levelsInfo[9].enemies[12].life = 2;
        levelsInfo[9].enemies[12].vector2Position.x = 30;
        levelsInfo[9].enemies[12].vector2Position.y = 30;
        levelsInfo[9].enemies[13].life = 2;
        levelsInfo[9].enemies[13].vector2Position.x = 30;
        levelsInfo[9].enemies[13].vector2Position.y = 0;
        levelsInfo[9].enemies[14].life = 2;
        levelsInfo[9].enemies[14].vector2Position.x = 30;
        levelsInfo[9].enemies[14].vector2Position.y = -30;
        levelsInfo[9].enemies[15].life = 1;
        levelsInfo[9].enemies[15].vector2Position.x = 60;
        levelsInfo[9].enemies[15].vector2Position.y = 0;

    }


}