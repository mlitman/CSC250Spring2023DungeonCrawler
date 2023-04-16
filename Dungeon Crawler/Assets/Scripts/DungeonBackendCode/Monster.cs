using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private String monsterName;
    private Room currentRoom;
    public float hitPoints;

    public Monster(String name)
    {
        this.monsterName = name;
    }

    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }

    public void setCurrentRoom(Room r)
    {
        if (r != null)
        {
            this.currentRoom = r;
        }
    }

    //getter (accessor) for read only access to the private field name
    public String getName()
    {
        return this.name;
    }

}