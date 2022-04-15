using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KolController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid2d;
    [SerializeField] GameObject _body;
    Animator _anim;
    int randomA = 4, randomB = 4;
    [SerializeField] Text _scoreText;
    int _score;
    bool yon=true;
    private void Start()
    {
        _anim = GetComponent<Animator>();
        _rigid2d.velocity = new Vector2(randomA, randomB);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("dusman"))
        {
            _score++;
            _scoreText.text = $"Score : {_score}";
            Destroy(col.gameObject);
            _rigid2d.velocity = new Vector2(randomA, randomB);

           _body.transform.localScale +=new Vector3(0.05f, 0.05f, 0.05f);

          if(yon ==true)
            {
                _anim.Play("kolsol");
                yon = false;
            }
          else
            {
                _anim.Play("kolarr");
                yon = true;
            }
        }
        if (col.gameObject.CompareTag("cevre"))
        {
            randomA = Random.Range(-5, 5);
            randomB = Random.Range(-5, 5);
            _rigid2d.velocity = new Vector2(randomA, randomB);
        }
    }
    private void FixedUpdate()
    {
      
    }
}
