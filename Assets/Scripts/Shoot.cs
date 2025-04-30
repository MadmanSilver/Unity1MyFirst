using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;
    public float fireRate = 1f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.F) && timer >= fireRate)
        {
            StartCoroutine(Fire());
            timer = 0f;
        }
    }

    private IEnumerator Fire() {
        Rigidbody nextProjectile = Instantiate<Rigidbody>(projectile, new Vector3(0f, 0f, 1f) + transform.position, Quaternion.identity);

        nextProjectile.AddTorque(Vector3.up);

        // Spin for a sec before launching.
        yield return new WaitForSeconds(fireRate);

        nextProjectile.AddForce(Vector3.forward);
    }
}
