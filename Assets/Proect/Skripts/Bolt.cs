using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    public float speed = 10;
    public GameObject blood;
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 5.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(blood, transform.position, Quaternion.identity);
    }

}
