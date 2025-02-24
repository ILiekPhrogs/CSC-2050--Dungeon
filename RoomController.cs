using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject northDoor;
    public GameObject southDoor;
    public GameObject eastDoor;
    public GameObject westDoor;

    public int numberOfExits = 4;
    private Dice exit;
  
    void Start()
    {
	exit = new Dice(4);
        UpdateDoors();
    }

    private void UpdateDoors()
    {
        northDoor.SetActive(false);
        southDoor.SetActive(false);
        eastDoor.SetActive(false);
        westDoor.SetActive(false);

        GameObject[] doors = { northDoor, southDoor, eastDoor, westDoor };
        int[] currentDoors = new int[4]; 
        int count = 0;

       
        while (count < numberOfExits)
        {
            int roll = exit.Roll() - 1; 

       }
   }
}
    

