using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate=2;
    public float timer = -4;
    public float heightOfSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate){
            timer += Time.deltaTime;
        }
        else{
            spawnpipe();
            timer=-4;
        }
    }
    void spawnpipe(){
        float lowestPoint = transform.position.y - heightOfSet;
        float highestPoint = transform.position.y + heightOfSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
        // Instantiate(pipe, transform.position,transform.rotation);
    }
}
