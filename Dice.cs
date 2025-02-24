
using System;

public class Dice
{
    private int sides;
    private System.Random rng; 

    public Dice(int sides)
    {
        this.sides = sides;
        this.rng = new System.Random();
    }

    public int Roll()
    {
        return this.rng.Next(1, this.sides + 1); 
    }
}
