using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject Player;
    private Vector3 offset = new Vector3(0f, 1f, -1f);

    private GameObject Background;
    private GameObject Bgplatforms;

    void Awake()
    {
        Player = GameObject.Find("Player");
        Background = GameObject.Find("Background");
        Bgplatforms = GameObject.Find("Bgplatforms");
    }

    void LateUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,0)+offset;
        Background.transform.position = new Vector3(transform.position.x, transform.position.y, Background.transform.position.z);
        Bgplatforms.transform.position = new Vector3(transform.position.x * 0.5f, transform.position.y * 0.5f, Bgplatforms.transform.position.z);
    }
}
