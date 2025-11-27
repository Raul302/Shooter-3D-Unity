using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3;

    float countdown;
    public float radius = 5;
    public float explosion_force = 70;
    bool exploded = false;

    public GameObject explosion_effect;

    private void Start()
    {
        countdown = delay;

    }
    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && exploded == false)
        {

            Exploded();
            exploded = true;
        }
    }

    public void Exploded()
    {
        Instantiate(explosion_effect,transform.position,transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach ( var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();

            if(rb != null)
            {
                rb.AddExplosionForce(explosion_force*20,transform.position,radius);
            }

        }
        SoundManager.Instance.PlayGrenadeExplosionSound();

        gameObject.GetComponent<SphereCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;


        Destroy(gameObject,delay*2);
    }
}
