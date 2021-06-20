using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int arme1 = 0;

    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            print("more-than-1-instance-of-Inv");
            return;
        }
        instance = this;
    }

    public void Addwepon(int arme)
    {
        print("test");
        arme1 += arme;  
    }
}