using UnityEngine;
using System.Collections;

public class EBullet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10);

    }

}