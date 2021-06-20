using UnityEngine;

public class hit_hero : MonoBehaviour
{
    public GameObject player;
    public GameObject[] toReset;
    public GameObject[] weapons;
    private int index = 0;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            player.transform.position = new Vector3(36, -34, 0);
            ResetAll();
        }
    }
    void ResetAll() {
        while (index < toReset.Length) {
            if (!toReset[index].activeSelf)
                toReset[index].SetActive(true);
            index += 1;
        }
        index = 0;
        while (index < weapons.Length) {
            if (weapons[index].activeSelf)
                weapons[index].SetActive(false);
        }
        KeyItems.instance.resetItems();
    }
}
