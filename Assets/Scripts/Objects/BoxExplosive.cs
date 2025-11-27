using UnityEngine;

public class BoxExplosive : MonoBehaviour
{

    public float radius = 5;
    public float explosion_force = 70;
    bool exploded = false;

    public GameObject explosion_effect;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Exploded();

        }
    }
    public void Exploded()
    {
        Instantiate(explosion_effect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosion_force * 20, transform.position, radius);
            }

        }

        SoundManager.Instance.PlayGrenadeExplosionSound();


        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;


        Destroy(gameObject, 1f);
    }
}
