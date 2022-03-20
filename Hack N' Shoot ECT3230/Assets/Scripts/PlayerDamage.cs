using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public int damage = 0;


    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damage == 4)
        {

            SceneManager.GetSceneByBuildIndex(0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            audioSource.PlayOneShot(clip);
            damage++;

        }

    }

}
