using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : MonoBehaviour
{
    [SerializeField] GameObject BarrierPrefab;
    private float lastTime = 0;
    private float spawnTime;

    void Update()
    {
        spawnTime = 5f / (Time.time*0.1f + 2.5f);
        if (Time.time - lastTime > spawnTime)
        {
            lastTime = Time.time;
            Vector3 spawnPos = new Vector3(8f, Random.Range(-5,5), 0f);
            GameObject barrierInstance = Instantiate(BarrierPrefab, spawnPos, Quaternion.identity);
            barrierInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(-2.5f, 0f);
        }
    }
}
