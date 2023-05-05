using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Inhabitant
{
    private Room currentRoom;
    public GameObject zeropc;
    public GameObject tenpc;
    public GameObject twentypc;
    public GameObject thirtypc;
    public GameObject fourtypc;
    public GameObject fiftypc;
    public GameObject sixtypc;
    public GameObject seventypc;
    public GameObject eightypc;
    public GameObject ninetypc;
    public float healthProportion;

    public Player(string name) : base(name)
    {

    }

    void start()
    {
        this.zeropc.SetActive(true);
        this.tenpc.SetActive(true);
        this.twentypc.SetActive(true);
        this.thirtypc.SetActive(true);
        this.fourtypc.SetActive(true);
        this.fiftypc.SetActive(true);
        this.sixtypc.SetActive(true);
        this.seventypc.SetActive(true);
        this.eightypc.SetActive(true);
        this.ninetypc.SetActive(true);

    }

    //this sets the health proportion as a float between 0 and 1
    void update()
    {
        this.healthProportion += MasterData.thePlayer.hp / MasterData.thePlayer.maxHP;
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
    public string getName()
    {
        return this.name;
    }

    //here, I created a series of if statements to deactivate any squares
    //whose value is below the healthProportion
    //this will update with each frame
    public void showHealthBar()
    {
        if(this.healthProportion < 0.9)
        {
            this.ninetypc.SetActive(false);
        }
        if (this.healthProportion < 0.8)
        {
            this.eightypc.SetActive(false);
        }
        if (this.healthProportion < 0.7)
        {
            this.seventypc.SetActive(false);
        }
        if (this.healthProportion < 0.6)
        {
            this.sixtypc.SetActive(false);
        }
        if (this.healthProportion < 0.5)
        {
            this.fiftypc.SetActive(false);
        }
        if (this.healthProportion < 0.4)
        {
            this.fourtypc.SetActive(false);
        }
        if (this.healthProportion < 0.3)
        {
            this.thirtypc.SetActive(false);
        }
        if (this.healthProportion < 0.2)
        {
            this.twentypc.SetActive(false);
        }
        if (this.healthProportion < 0.1)
        {
            this.tenpc.SetActive(false);
        }
        if (this.healthProportion < 0)
        {
            this.zeropc.SetActive(false);
        }

    }
}