using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{

    private float _verticalInput;
    public float Speed = 5f;
    public float RotationSpeed = 45f;
    private float _horizontalInput;
    public ParticleSystem dirtParticle;
    public GameObject projectilePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Speed * _verticalInput * Time.deltaTime);

        // turn the vehicle

        transform.Rotate(Vector3.up, RotationSpeed * _horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lauch a projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


    }

}
