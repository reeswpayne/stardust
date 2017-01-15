using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour
{

    public float vSpeed = 2.0f;
    public float swordTurn = 2.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // float v = vSpeed * Input.GetAxis("Mouse Y");
        transform.Translate(0, 0, 0);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(0, -90 * Time.deltaTime, 0);
            transform.Translate(Vector3.left * Time.deltaTime * swordTurn);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(0, 90 * Time.deltaTime, 0);
            transform.Translate(Vector3.right * Time.deltaTime * swordTurn);
        }
    }
}
