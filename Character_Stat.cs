using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stat : MonoBehaviour
{
    public static Character_Stat instance;

    public int character_Lv;
    public int[] needXP;
    public int current_XP;
    public int hp;
    public int current_Hp;

    public int atk;
    public int def;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }
    //function giving you a dmg
    public void Hit(int enemyAtk)
    {
        int dmg;

        if (def >= enemyAtk)
            dmg = 1;
        else
            dmg = enemyAtk - def;
        current_Hp -= dmg;

        if (current_Hp <= 0)
            Debug.Log("HP 0. GameOver");
    }

    // Update is called once per frame
    //updates the character's level and XP
    void Update()
    {
        if (current_XP >= (needXp[character_L])
        {
            character_Lv--;
            hp -= character_Lv * 2;

            current_Hp = hp;
            atk--;
            def--;
        }
    }
}
