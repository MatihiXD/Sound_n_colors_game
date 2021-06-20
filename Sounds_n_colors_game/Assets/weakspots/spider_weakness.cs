using UnityEngine;

public class spider_weakness : MonoBehaviour
{
    public GameObject objectToDestroy;
    public AudioSource source;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            if (KeyItems.instance.guitar != 0) {
                source.Play();
                objectToDestroy.SetActive(false);
//                Destroy(objectToDestroy);
            }
        }
    }
}
