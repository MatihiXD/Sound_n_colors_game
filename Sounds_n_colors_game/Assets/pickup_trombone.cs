using UnityEngine;

public class pickup_trombone : MonoBehaviour
{
    public GameObject trombone;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            trombone.SetActive(true);
            KeyItems.instance.Addtrombone();
            Destroy(gameObject);
        }
    }
}
