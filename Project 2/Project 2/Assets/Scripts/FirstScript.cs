using UnityEngine;
using System.Collections;

public class FirstScript : MonoBehaviour
{

    public float speed = 20;
    public Rigidbody projectile;
    public Rigidbody cube;
    public float cubeW = 1.0f;
    public float cubeH = 1.0f;
    //Vector3 posChange = new Vector3(2, 2, 0);

    // Use this for initialization
    void Start()
    {

        //Creates the cube GameObject
        GameObject cube = new GameObject();

        //Works through creating the 8x8 wall of cubes
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {

                // The position I want the wall to start at (close to player)
                float posX = 429.89f;
                float posY = 0.528f;
                float posZ = 229.5f;

                //Moves the position of each box as the for loop goes through it
                Vector3 position = new Vector3(posX + y * cubeW, posY + x * cubeH, posZ);


                //My attempt at instantiation
                //Rigidbody instanstiateCube = Instantiate(cube, transform.position = positionCube, transform.rotation) as Rigidbody;

                //Actual creation of the cube as a cube game object
                cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //Positions the new cube into the position of the position vector
                cube.transform.position = position;

                //Makes the cubes a rigidbody
                Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>();
                //Changes the mass of the cubes
                gameObjectsRigidBody.mass = 0.5f;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("I am alive!");
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instanstiateProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instanstiateProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));


            Debug.Log("Firing");

        }

    }

}

