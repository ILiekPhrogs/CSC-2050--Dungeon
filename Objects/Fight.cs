using UnityEngine;

public class Fight
{
    private Inhabitant attacker;
    private Inhabitant defender;
 
    private Monster theMonster;

    public Fight(Monster m)
    {
        this.theMonster = m;

        int roll = Random.Range(0, 20) + 1;
        if (roll <= 10)
        {
            Debug.Log("Monster goes first");
            this.attacker = m;
            this.defender = Core.thePlayer;
        }
        else
        {
            Debug.Log("Player goes first");
            this.attacker = Core.thePlayer;
            this.defender = m;
        }

    }

    public void startFight(GameObject playerGO, GameObject monsterGO)
    {
       while(true)
       {
           int attackRoll = Random.Range(0,20) + 1;
               if(attackRoll >= this.defender.getAC())
               {
                   int damage = Random.Range(0,10);
                   this.defender.takeDamage(damage);

                   if(this.defender.isDead())
                   {
                       Debug.Log(this.attacker.getName() + " has won." + this.defender.getName() + " takes an L.");
                       if(this.defender is Player)
                       {
                           playerGO.SetActive(false);
                       }
                       else
                       {
                           GameObject.Destroy(monsterGO);
                       }
                        
                       break;
                   }
               }

               else 
               {
                   Debug.Log(this.attacker.getName() + " missed " + this.defender.getName());
               }

           Inhabitant temp = this.attacker;
           this.attacker = this.defender;
           this.defender = temp;
       }
        //should have the attacker and defender fight each until one of them dies.
        //the attacker and defender should alternate between each fight round and
        //the one who goes first was determined in the constructor.
        Debug.Log("Game Over.");
    }
}