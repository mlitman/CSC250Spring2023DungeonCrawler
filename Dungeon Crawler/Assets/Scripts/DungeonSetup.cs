using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public bool northOn, southOn, eastOn, westOn;

    void Start()
    {
        MasterData.setupDungeon();
    }

}
