using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BirdScript : MonoBehaviour
{
    public Vector3 flappyForce = new Vector3(0, 50, 0);
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            GetComponent<Rigidbody>().AddForce(flappyForce);
        }

        if (Input.GetKeyDown("space") && Time.timeScale == 0)
        {

            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene(0);
        }
        {


        }


    }

    void OnCollisionEnter()
    {


        Time.timeScale = 0;

    }
}
