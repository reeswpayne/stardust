using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    float timer = 0;
    float random;
    int health = 2;
    public GameObject eBullet;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0f, 3f);
        timer += Time.deltaTime;
        if (timer > random)
        {
            Instantiate(eBullet, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
