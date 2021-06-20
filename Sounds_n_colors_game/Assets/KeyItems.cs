using UnityEngine;

public class KeyItems : MonoBehaviour
{
    public int flute;
    public int guitar;
    public int trombone;
    public GameObject fluteOBJ;
    public GameObject guitarOBJ;
    public GameObject tromboneOBJ;

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

    public void resetItems()
    {
        flute = 0;
        guitar = 0;
        trombone = 0;
    }

    private void Update() {
        fluteOBJ.SetActive(false);
        guitarOBJ.SetActive(false);
        tromboneOBJ.SetActive(false);

        if (flute > 0)
            fluteOBJ.SetActive(true);
        if (guitar > 0)
            guitarOBJ.SetActive(true);
        if (trombone > 0)
            tromboneOBJ.SetActive(true);
    }
}
