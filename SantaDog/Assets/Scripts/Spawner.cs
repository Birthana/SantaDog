using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool onChimneyCooldown;
    public float chimneyCooldown;
    public bool onObtacleCooldown;
    public float obtacleCooldown;

    public GameObject[] chimneys;
    public GameObject[] obtacles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!onChimneyCooldown)
        {
            StartCoroutine(SpawnChimney());
        }
        if (!onObtacleCooldown)
        {
            StartCoroutine(SpawnObtacle());
        }
    }

    IEnumerator SpawnChimney()
    {
        onChimneyCooldown = true;
        GameObject tempObject = Instantiate(chimneys[Random.Range(0, chimneys.Length)], new Vector3(14.5f, -6.75f, 0), Quaternion.identity);
        yield return new WaitForSeconds(chimneyCooldown);
        onChimneyCooldown = false;
    }

    IEnumerator SpawnObtacle()
    {
        onObtacleCooldown = true;
        GameObject tempObject = Instantiate(obtacles[Random.Range(0, obtacles.Length)], new Vector3(14.5f, Random.Range(0, 7) - 2, 0), Quaternion.identity);
        yield return new WaitForSeconds(obtacleCooldown);
        onObtacleCooldown = false;
    }
}
