using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewChasing : MonoBehaviour
{
    public Transform target;
    public float speed = 4f;
    Rigidbody rb;
    public Collider player;
    private Animator animator;
    private float timeToDisappear = 3f;


    public GameObject bullet;

    public int hits;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        bullet = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        {
            if (hits >= 3)
            {
                animator.SetBool("isDead", true);
                StartCoroutine(DisappearCoroutine(gameObject));

                return;

            }

        }


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hits < 3)
        {
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                rb.MovePosition(pos);
                transform.LookAt(target);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == player)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            hits++;
        }
    }

    private IEnumerator DisappearCoroutine(GameObject gameObject)
    {
        yield return new WaitForSeconds(timeToDisappear);
        Destroy(gameObject);
    }
}
