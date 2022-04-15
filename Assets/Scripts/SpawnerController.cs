using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    float xrandom, yrandom;

    void Start()
    {

        InvokeRepeating("EnemyGetir", 2, 3);
    }

    void Update()
    {


    }
   void EnemyGetir()
    {
        xrandom = Random.Range(-7f, 7f);
        yrandom = Random.Range(-4.5f, 4.5f);
        Instantiate(_enemy, new Vector3(xrandom, yrandom, 0), transform.rotation);
    }
}
