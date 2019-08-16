using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PPA
{
    public class PlayerController : MonoBehaviour
    {
        #region Variables
        [Header("References")]
        private GameObject r_player;
        public Rigidbody2D r_rb;
        public Transform r_groundCheckTransform;
        public float r_groundCheckRadius;
        public LayerMask r_groundLayer;
        

        [Header("Balancing")]
        [SerializeField] public float m_speed;
        [SerializeField] public float m_jumpForce;
        [SerializeField] public float m_topspeed;
 
        [HideInInspector]public bool m_isGrounded;
        #endregion

        // Start is called before the first frame update
        void Start() {
            r_player = this.gameObject;
            r_rb = r_player.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update() {
            m_isGrounded = Physics2D.OverlapCircle(r_groundCheckTransform.position,r_groundCheckRadius,r_groundLayer);
        }
      
    }
}
