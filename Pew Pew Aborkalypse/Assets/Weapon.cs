using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PPA
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] public GameObject r_bullet;
        [SerializeField] public Transform r_barrel;
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
        public void Shoot() {
            Instantiate(r_bullet, r_barrel.position, r_barrel.rotation);
        }
    }
}