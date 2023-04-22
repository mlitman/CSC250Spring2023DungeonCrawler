using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inhabitant
{
    //was listed as protected in class
    public int hp;
    public int ac;
    public int damage;
    public string name;

    public Inhabitant(string name)
    {
        this.name = name;
        System.Random r = new System.Random();
        this.hp = r.Next(10, 21);
        this.ac = r.Next(10, 18);
        this.damage = r.Next(1, 6);
    }

    public string getData()
    {
        string s = this.name;
        s = s + " - " + this.hp + " / " + this.ac + " / " + this.damage;
        return s;
    }

    //Homework 14 the dudes can now roll D20s and attacks
    public int RollD20()
    {
        return Random.Range(1, 20);
    }

    public int RollAttack()
    {
        return Random.Range(1, this.damage);
    }

}
