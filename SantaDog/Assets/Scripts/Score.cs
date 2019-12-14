using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //public bool isGame;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        //isGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        score += 100 * Time.deltaTime;
        this.GetComponent<TextMeshProUGUI>().text = "" + string.Format("{0:0,0}", score);
    }
}
