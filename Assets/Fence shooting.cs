using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fenceshooting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.up * 100f, Color.red, 1f);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.up, out hit, 100f))
            {
                Debug.Log("Hit!");

                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    hit.transform.gameObject.GetComponent<Enemy>().TakeDamage(5);
                }
            }
        }
    }

}
