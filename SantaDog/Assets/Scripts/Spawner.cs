using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool onChimneyCooldown;
    public float chimneyCooldown;
    public bool onObtacleCooldown;
    public float obtacleCooldown;

    public GameObject chimney;
    public GameObject obtacle;

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
        GameObject tempObject = Instantiate(chimney, new Vector3(12, -5.2f, 0), Quaternion.identity);
        yield return new WaitForSeconds(chimneyCooldown);
        onChimneyCooldown = false;
    }

    IEnumerator SpawnObtacle()
    {
        onObtacleCooldown = true;
        GameObject tempObject = Instantiate(obtacle, new Vector3(12, Random.Range(0, 6) - 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(obtacleCooldown);
        onObtacleCooldown = false;
    }
}
