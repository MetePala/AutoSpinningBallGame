using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject gameovercanvas;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("dusman"))
        {
            Time.timeScale = 0;
            gameovercanvas.SetActive(true);
        }
    }
}
