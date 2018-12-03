using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriseDeDommageJoueur : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ennemi")
        {
            animator.SetTrigger("Die");
            Destroy(GetComponent<MouvementPersonnage>());
            Destroy(GetComponent<RotationDepuisSouris>());
            Destroy(GetComponent<Tirer>());
            Destroy(GetComponent<Rigidbody>());
            Destroy(transform.parent.gameObject, 3f);
        }
    }
}
