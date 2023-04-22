using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterTriggerScript : MonoBehaviour
{
    public bool enableFights = true;
    public float chanceToGetIntoFight = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if(this.enableFights == true)
        {
            int chanceToFight = Random.Range(1, 100);
            if (chanceToFight <= this.chanceToGetIntoFight)
            {
                SceneManager.LoadScene("FightScene");
            }
            else
            {
                print("No monsters found");
            }
        }
    }
}
