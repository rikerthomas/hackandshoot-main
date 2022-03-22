using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDamage : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public TextMeshProUGUI hitsText;
    public TextMeshProUGUI projectileText;
    public int enemyHits;
    public int projectileHits;

    public int damage = 0;


    // Start is called before the first frame update
    void Start()
    {
        projectileHits = 0;
        enemyHits = 0;
        audioSource = GetComponent<AudioSource>();
        SetCountText();
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
            enemyHits = enemyHits + 1;
            SetCountText();

        }
        if(collision.gameObject.CompareTag("Projectile"))
        {
            audioSource.PlayOneShot(clip);
            projectileHits = projectileHits + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        hitsText.text = "Enemy Hits: " + enemyHits.ToString();
        projectileText.text = "Projectile Hits: " + projectileHits.ToString();
    }

}
