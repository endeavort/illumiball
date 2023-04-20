using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public string targetTag;

    bool isHolding;

    public bool IsHolding()
    {
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        isHolding = true;
    }
    void OnTriggerExit(Collider other)
    {
        isHolding = false;
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        if(other.gameObject.tag == targetTag)
        {
            r.velocity *= 0.9f;
            r.AddForce(direction * -20.0f, ForceMode.Acceleration);
        }
        else
        {
            r.AddForce(direction * 80.0f, ForceMode.Acceleration);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
