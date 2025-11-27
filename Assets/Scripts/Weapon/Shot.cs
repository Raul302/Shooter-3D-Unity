using UnityEngine;

public class Shot : MonoBehaviour
{

    public Transform spawn_bullet_point;

    public GameObject bullet;

    public float shotForce = 1500f;

    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {


            if (Time.time > shotRateTime && GameManager.Instance.gunAmmo > 0)
            {
                animator.SetTrigger("Shoot");
                SoundManager.Instance.PlayGunShotSound();
                GameManager.Instance.gunAmmo--;

                GameObject new_bullet;
                new_bullet = Instantiate(
                    bullet, spawn_bullet_point.position, spawn_bullet_point.rotation
                    );

                new_bullet.GetComponent<Rigidbody>().AddForce(
                    spawn_bullet_point.forward * shotForce
                    );

                shotRateTime = Time.time + shotRate;

                Destroy(new_bullet,5f);
            }

        }
        
    }
}
