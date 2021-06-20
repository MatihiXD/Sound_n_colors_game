using UnityEngine;

public class spider_weakness : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            if (KeyItems.instance.guitar != 0)
                Destroy(objectToDestroy);
        }
    }
}
