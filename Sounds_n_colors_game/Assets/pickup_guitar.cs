using UnityEngine;

public class pickup_guitar : MonoBehaviour
{
    public GameObject guitar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            guitar.SetActive(true);
            KeyItems.instance.Addguitar();
            Destroy(gameObject);
        }
    }
}
