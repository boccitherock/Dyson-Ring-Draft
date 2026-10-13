using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Gravity : MonoBehaviour
{
    public float Strength = -9.8f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody[] allBodies = GameObject.FindObjectsByType<Rigidbody>(FindObjectsSortMode.None);

        foreach (Rigidbody item in allBodies)
        {
            if (item.gameObject == this.gameObject) continue;

            Vector3 direction = (transform.position - item.transform.position).normalized;

            float x = direction.x;
            float y = direction.y;
            float z = direction.z;

            Vector3 grav = new Vector3 (x, y, 0);

            item.AddForce(grav * Strength, ForceMode.Acceleration);

        }
    }
}
