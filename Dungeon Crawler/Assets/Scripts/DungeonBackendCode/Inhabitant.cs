using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Inhabitant
{
    protected int hp;
    protected int ac;
    protected int damage;
    protected string name;
    private object transform;

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

    public bool isDead()
    {
        return this.hp <= 0;
    }

    public int getAC()
    {
        return this.ac;
    }

    public int getDamage()
    {
        return this.damage;
    }

    public void takeDamage(int damage)
    {
        this.hp = this.hp - damage;
    }

    /*public void Bounce()
    {
        StartCoroutine(BounceRoutine());
    }

    private IEnumerator BounceRoutine()
    {
        float startingPosition = this.transform.position.y;
        float timeToBounce = 0;
        float bounceSpeed = 10.0f;
        float bounceHeight = 5.0f;
        while (timeToBounce > 0)
        {
            timeToBounce = Time.deltaTime * bounceSpeed;
            //I found the Mathf.Lerp using a C# research tool
            float newPosition = Mathf.Lerp(startingPosition, startingPosition + bounceHeight, timeToBounce);
            this.transform.position = new Vector3(this.transform.position.x, newPosition, this.transform.position.z);
            yield return null;
        }
    }*/

}