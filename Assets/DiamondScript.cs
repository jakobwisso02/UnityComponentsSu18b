using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{

    public SpriteRenderer rend;
    public Color newColor;
    public Transform other;

    [Range(-720, 720)]
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new Vector3(3, 2, other.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(15f * Time.deltaTime, 0f, 0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1f * Time.deltaTime, 0f, 0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(80f * Time.deltaTime, 0f, 0f, Space.Self);
        }

        //Time.deltaTime = tidskillnad mellan varje frame


    }
}
