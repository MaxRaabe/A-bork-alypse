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
        #endregion

        // Start is called before the first frame update
        void Start() {
            r_player = this.gameObject;
            r_rb = r_player.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
