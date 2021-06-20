using UnityEngine;

public class KeyItems : MonoBehaviour
{
    public int flute;
    public int guitar;
    public int trombone;

    public static KeyItems instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one insatnce of KeyItems in scene.");
            return;
        }
        instance = this;
    }

    public void Addflute()
    {
        flute += 1;
    }

    public void Addguitar()
    {
        guitar += 1;
    }

    public void Addtrombone()
    {
        trombone += 1;
    }
}
