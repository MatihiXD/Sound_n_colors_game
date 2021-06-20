using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject flute;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            flute.SetActive(true);
            KeyItems.instance.Addflute();
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
