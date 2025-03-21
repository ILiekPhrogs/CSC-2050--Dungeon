using UnityEngine;

public class Fight
{
    private Inhabitant attacker;
    private Inhabitant defender;

    public Fight()
    {
        int roll = Random.Range(0, 20) + 1;
        if (roll <= 10)
        {
            Debug.Log("Monster goes first");
        }
        else
        {
            Debug.Log("Player goes first");
        }

    }

    public void startFight()
    {
       while(true)
       {
           int attackRoll = Random.Range(0,20);
           if(attackRoll >= defender.getAC())
           {
               int damage = Random.Range(0,10);
               defender.takeDamage(damage);

               if(defender.isDead())
               {
                   Debug.Log(attacker.getName() + " has won.");
                   break;
               }
           }

           else 
           {
               Debug.Log(attacker.getName() + " missed." );
           }

           Inhabitant temp = attacker;
           attacker = defender;
           defender = temp;
       }
        //should have the attacker and defender fight each until one of them dies.
        //the attacker and defender should alternate between each fight round and
        //the one who goes first was determined in the constructor.
        Debug.Log("Game Over.");
    }
}