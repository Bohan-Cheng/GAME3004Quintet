using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float bulletSpeed = 30;
    public float lifeTime = 3;

    private void Start()
    {
        Vector3 rotation = transform.rotation.eulerAngles;

        transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            print("hit " + other.name + "!");
            Destroy(gameObject);
        }
    }
}
