using UnityEngine;

public class mouse_weakness : MonoBehaviour
{
    public GameObject objectToDestroy;
    public AudioSource source;
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            if (KeyItems.instance.flute != 0) {
                source.Play();
                objectToDestroy.SetActive(false);
//                Destroy(objectToDestroy);
            }
        }
    }
}
