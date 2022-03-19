using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        //hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        //heroine.PrintStatsInfo();

        Character hero2 = hero;
        hero2.name = "Sir Krane";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 200;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
