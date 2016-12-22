using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            transform.Translate(Vector3.up * 1);
            transform.Rotate(Vector3.right * 45);
            transform.Translate(Vector3.left * 1);
        }
    }

}
