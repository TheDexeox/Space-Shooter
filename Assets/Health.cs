using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public string End;
    public int health = 3;
    int MaxHealth;
    void Start()
    {
        MaxHealth = health;
    }

    public void ReduceHealth()
    {
        health -= 1;

        if (health <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
