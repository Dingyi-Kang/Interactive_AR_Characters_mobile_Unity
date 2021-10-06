using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyScript : MonoBehaviour
{
    public Transform target;

    public Animator anim;

    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.CompareTag("girl"))
        {

            anim.SetBool("Meet", true);

        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("girl"))
        {

            anim.SetBool("Meet", false);

        }
    }

}
