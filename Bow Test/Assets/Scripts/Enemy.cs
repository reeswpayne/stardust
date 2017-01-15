using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    // Variables
    float timer = 0;
    float random;
    public GameObject eBullet;
    public Transform target;
    bool facingRight = true;
    int health = 2;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (target.transform.position.x > this.transform.position.x)
            {
                Flip();
            }
            if (target.transform.position.x < this.transform.position.x)
            {
                Flip();
            }
        }
        random = Random.Range(0f, 3f);
        timer += Time.deltaTime;
        if (timer > random)
        {
            Instantiate(eBullet, transform.position, transform.rotation);
            timer = 0;
        }
     
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    // Lose health
    void OnTriggerEnter(Collider o)
    {
        if (o.tag == "Bullet")
        {
            health -= 1;
            Destroy(o.gameObject);
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
