using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject enemy_bullet;

    public Transform spawn_bullet_point;

    private Transform player_position;

    public float bullet_velocity = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_position = FindFirstObjectByType<PlayerMovement>().transform;
        Invoke("ShootPlayer",3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootPlayer()
    {
        Vector3 player_direction = player_position.position - transform.position;
        GameObject new_bullet;
        new_bullet = Instantiate(enemy_bullet,spawn_bullet_point.position,spawn_bullet_point.rotation);

        new_bullet.GetComponent<Rigidbody>().AddForce(player_direction*bullet_velocity,ForceMode.Force);


        Invoke("ShootPlayer", 3);

    }
}
