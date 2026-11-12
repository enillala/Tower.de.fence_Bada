using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseHealthTest : MonoBehaviour
{
    public float hhealth = 5f;

    public void TakeDamage(float damage)
    {
        hhealth -= damage;
        Debug.Log(" Took Damage");
        if (hhealth <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("YouLost");
        }
    }
}
