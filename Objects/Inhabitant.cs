using UnityEngine;

public abstract class Inhabitant
{
    protected int currHp;
    protected int maxHp;
    protected int ac;
    protected string name;

    public bool isDead()
    {
        return this.currHp <= 0;
    }

    public void takeDamage(int damage)
    {
        this.currHp = this.currHp - damage;
    }

    public int getAC()
    {
        return this.ac;
    }
    public string getName()
    {
        return this.name;
    }
    public int getmaxHp()
    {
        return this.maxHp;
    }

    public int getCurrHp()
    {
        return this.currHp;
    }
   


    public Inhabitant(string name)
    {
        this.name = name;
        this.maxHp = Random.Range(30, 50);
        this.currHp = this.maxHp;
        this.ac = Random.Range(10, 20);
    }
}