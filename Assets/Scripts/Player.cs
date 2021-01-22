using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float force = 2.0f;
    UI ui;
    [SerializeField]
    AudioClip bounce;
    [SerializeField]
    AudioClip score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ui = GameObject.Find("Canvas").GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(0, force, 0));
            GetComponent<AudioSource>().PlayOneShot(bounce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
            //Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ui.UpdateScore();
        GetComponent<AudioSource>().PlayOneShot(score);
    }
}
