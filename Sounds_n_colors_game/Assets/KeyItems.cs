using UnityEngine;

public class KeyItems : MonoBehaviour
{
    public int flute;

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
}
