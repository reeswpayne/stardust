using UnityEngine;
using System.Collections;

public class Sagittarius : MonoBehaviour {

    // For flipping the sprite
    bool facingRight = true;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        while (true) { 
            transform.Translate(Vector3.left * 1 / 10);
            Flip();
            transform.Translate(Vector3.right * 1 / 10);
            Flip();
            /// more arrows
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
