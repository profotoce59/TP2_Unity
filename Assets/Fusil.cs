using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusil : MonoBehaviour
{
    [SerializeField] public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward*1000);
        }
    }
}
