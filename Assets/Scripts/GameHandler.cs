using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;
using System.Drawing;

public class GameHandler : MonoBehaviour
{
    public Vector3 velocity = new Vector3(-5, 0, 0);
    // Start is called before the first frame update
    void Start()
    {

        GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        //gameObject.GetComponent<SpriteRenderer>.sprite =  ;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime, Space.World);

        if (transform.position.x < -16)
        {

            transform.Translate(195, Random.Range(-2, 4), 0);

        }
    }
}
