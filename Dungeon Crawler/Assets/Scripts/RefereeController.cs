using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefereeController : MonoBehaviour
{
    public GameObject monsterGO;
    public GameObject playerGO;
    public TextMeshPro monsterSB;
    public TextMeshPro playerSB;
    private Monster theMonster;
    private DeathMatch theMatch;
    public GameObject winnerJukeBox;

    // Start is called before the first frame update
    void Start()
    {
        this.theMonster = new Monster("Monster");
        this.updateScore();
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.playerGO, this.monsterGO, this);
        StartCoroutine(DelayBeforeFight());
    }

    public void playWinnerMusic()
    {
        this.winnerJukeBox.SetActive(false);
    }
    public void updateScore()
    {
        this.monsterSB.text = this.theMonster.getData();
        this.playerSB.text = MasterData.p.getData();
    }

    IEnumerator DelayBeforeFight()
    {
        yield return new WaitForSeconds(0.5f);
        this.theMatch.fight();

    }

}