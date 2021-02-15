using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesSpawnerScript : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipesPair;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipespair = Instantiate(pipesPair);
            newpipespair.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            timer = 0;
            Destroy(newpipespair, 15);
        }

        timer += Time.deltaTime;
        
    }
}
