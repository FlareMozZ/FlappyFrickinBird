using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3.5f;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawnpipe();
            timer = 0;
        }
        
    }
    
    void Spawnpipe()
    {
        float lowestpoint= transform.position.y - heightoffset;
        float highestpoint= transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
