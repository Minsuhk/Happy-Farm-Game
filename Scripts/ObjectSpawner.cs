using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    // List of prefabs to have different objects randomly spawn
    public GameObject[] fruit_prefab;
    public float spawn_rate = 0.5f;

    // Left and right boandaries for the screen
    public float min_x;//adjust values within unity
    public float max_x;//adjust values within unity
    private float timer;//adjust values within unity

    // Start is called before the first frame update
    void Start()
    {
        SpawnFruit();
    }

    // Update is called once per frame
    void Update()
    {
        // Will only spawn fruits when the timer is running
        if(timer < spawn_rate) {
            timer += Time.deltaTime;
        } else {
            SpawnFruit();
            timer = 0;
        }
    }

    void SpawnFruit() {
        Instantiate(fruit_prefab[Random.Range(0, fruit_prefab.Length)], new Vector3(Random.Range(min_x, max_x), transform.position.y, 0), transform.rotation);
    }
}
