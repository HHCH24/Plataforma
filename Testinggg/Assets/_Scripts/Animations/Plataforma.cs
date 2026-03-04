using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _animator.SetTrigger("Disapear");
        }
    }
}
