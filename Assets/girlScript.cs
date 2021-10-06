using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlScript : MonoBehaviour
{
    public Animator anim;

    public GameObject character;

    public Transform target;

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

    private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("boy"))
        {
            anim.SetBool("Meet", true);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("boy"))
        {

            anim.SetBool("Meet", false);

        }
    }

}
