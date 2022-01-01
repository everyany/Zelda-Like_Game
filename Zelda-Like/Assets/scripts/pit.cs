using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pit : MonoBehaviour
{
    public Transform teleportTarget;
    [SerializeField] private GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = teleportTarget.transform.position;
            player.transform.parent = null;
        }
    }
}
