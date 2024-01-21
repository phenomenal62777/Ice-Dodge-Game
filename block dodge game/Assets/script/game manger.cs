using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class gamemanger : MonoBehaviour
{
    public GameObject block;
    public Transform spawnpoint;
    public float maxx;
    int score = 0;
    public TextMeshProUGUI textscore;
    public GameObject tabtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startspawing();
            tabtext.SetActive(false);

        }
    }

    private void startspawing()
    {
        InvokeRepeating("spawning", 1f, 15f);
    }


    private void spawning()
    {
        Vector3 spawpos = spawnpoint.position;
        spawpos.x = Random.Range(-maxx, maxx);
        Instantiate(block, spawpos, Quaternion.identity);
        score++;
        textscore.text = score.ToString();
    }
}
