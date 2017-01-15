using UnityEngine;
using System.Collections;

public class EBullet : MonoBehaviour
{
    public Transform target;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(Vector3.left * Time.deltaTime * 10);

        }
    }
}