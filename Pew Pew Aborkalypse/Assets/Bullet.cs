using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_bulletSpeed = 20f;
    [SerializeField] private Rigidbody2D r_bulletRB;
    // Start is called before the first frame update
    void Start()
    {
        r_bulletRB.velocity = transform.right * m_bulletSpeed;
        
    }
    private void OnCollisionEnter2D(Collider2D collision) {
        if (this)
            return;
        Destroy(gameObject);
    }


}
