using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeathMatch : MonoBehaviour
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude2GO = dude2GO;
        this.dude2GO = dude2GO;
    }

    public IEnumerator fight()
    {
        //goes back and forth having our inhabitant try to attack each other
        //a successful attack means that a D20 is at least as high as the target's AC
        //upon successful attack, the target's HP reduce by the attacker's Attack
        //an unsuccessful attack results in no change in HP
        //go back and forth like this until an inhabitant dies
        //Display initial stats
        UpdateStats();

        while (dude1.hp > 0 && dude2.hp > 0)
        {
            //I researched the yield return WaitForSeconds and Ienumerator as a solution to prevent
            //the fight from taking place in an instant
            yield return new WaitForSeconds(2f);

            // Dude 1 attacks Dude 2
            int attackRoll1 = dude1.RollD20();
            int damage1 = 0;

            if (attackRoll1 >= dude2.ac)
            {
                damage1 = dude1.RollAttack();
                dude2.hp = dude2.hp - damage1;
                damage1 = 0;
                attackRoll1 = 0;
            }

            // Dude 2 attacks Dude 1
            int attackRoll2 = dude2.RollD20();
            int damage2 = 0;

            if (attackRoll2 >= dude1.ac)
            {
                damage2 = dude2.RollAttack();
                dude1.hp = dude1.hp - damage2;
                damage2 = 0;
                attackRoll2 = 0;

                // Display stats after attack
                UpdateStats();
            }

            DisplayEnding();
        }
    }

    public void UpdateStats()
    {
        string dude1Stats = dude1.name + " / " + dude1.ac + " / " + dude1.hp + " / " + dude1.damage;
        string dude2Stats = dude2.name + " / " + dude2.ac + " / " + dude2.hp + " / " + dude2.damage;

        dude1GO.GetComponent<TextMeshPro>().SetText(dude1Stats);
        dude2GO.GetComponent<TextMeshPro>().SetText(dude2Stats);
    }

    private void DisplayEnding()
    {
        if(dude1.hp > dude2.hp)
        {
            print(dude1.name + " wins!!!");
        }
        else
        {
            print(dude2.name + " wins!!!");
        }
    }

}
