using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class amulet_B : MonoBehaviour
{
    /*
    public Vector3 velocity;
    public Vector3 position;
    public float period;

    public float maxAcceleration = 100;

    public float randomPower;
    public float randomPeriod;

    GameObject enemy_B;
    Transform Enemy_B;

    // Start is called before the first frame update
    void Start()
    {
        enemy_B = GameObject.Find("Enemy_B");
        Enemy_B = enemy_B.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 0.7f);

        if (Enemy_B == null) return;

        var acceleration = Vector3.zero;
        var diff = Enemy_B.position - position;

        acceleration += (diff - velocity * period) * 2f / (period * period);

        if (0 < randomPeriod)
        {
            var xr = Random.Range(-randomPower, randomPower);
            var yr = Random.Range(-randomPower, randomPower);
            var zr = Random.Range(-randomPower, randomPower);
            acceleration += new Vector3(xr, yr, zr);
        }

        if (acceleration.magnitude > maxAcceleration)
        {
            acceleration = acceleration.normalized * maxAcceleration;
        }

        period -= Time.deltaTime;
        randomPeriod -= Time.deltaTime;
        if (period < 0) return;

        velocity += acceleration * Time.deltaTime;
        position += velocity * Time.deltaTime;
        transform.position = position;

        /*
        if (Enemy_B != null)
        {
            // プレイヤーの位置を向く
            transform.LookAt(Enemy_B);

            // プレイヤーに向かって移動
            transform.Translate(Vector3.forward * 0.5f * Time.deltaTime);
        }
        
    }
    */

    /*
    GameObject enemy_B;
    Transform Enemy_B;

    public float torqueRatio;
    public float speed;

    void Start()
    {
        enemy_B = GameObject.Find("Enemy_B");
        Enemy_B = enemy_B.GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        if (Enemy_B == null) return;

        var diff = Enemy_B.transform.position - transform.position;
        var target_rot = Quaternion.LookRotation(diff);
        var rot = target_rot * Quaternion.Inverse(transform.rotation);

        if (rot.w < 0f)
        {
            rot.x = -rot.x;
            rot.y = -rot.y;
            rot.z = -rot.z;
            rot.w = -rot.w;
        }

        var torque = new Vector3(rot.x, rot.y, rot.z) * torqueRatio;
        GetComponent<Rigidbody>().AddTorque(torque);

        GetComponent<Rigidbody>().velocity = transform.forward * speed;    
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
