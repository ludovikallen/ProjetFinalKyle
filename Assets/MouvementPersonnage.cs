using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPersonnage : MonoBehaviour
{
    public float speed;
    Animator animator;
    int jumpHash = Animator.StringToHash("Speed");
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
     //   float mouve = moveHorizontal + moveVertical;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
      //  animator.SetFloat(jumpHash, mouve);
        transform.position += movement * speed;
    }
}
