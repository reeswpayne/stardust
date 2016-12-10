using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Variables
    public GameObject bullet;
    float timer = 120;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += 1;
        if (timer >= 120)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
    }
}
