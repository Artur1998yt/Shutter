using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TargetSensor : MonoBehaviour
{
    public AudioClip target;
    public float distanse;
    public UnityEvent edit, reEdit, busted;
    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, distanse))
        {
            if (hit.collider.tag == "Player")
            {
                edit.Invoke();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            busted.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            reEdit.Invoke();
        }
    }
}
