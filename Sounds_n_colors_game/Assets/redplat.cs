using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redplat : MonoBehaviour
{
    public GameObject on;
    public GameObject on2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        on2.SetActive(true);
        on.SetActive(true);
    }

}
