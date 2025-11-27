using UnityEngine;

public class Enemy : MonoBehaviour
{

    private int life = 3;

    public Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            SoundManager.Instance.PlayHitSound();

            life = life - 1;

            if(life <= 0) {

                DestroyEnemyWithAnimation();
            } else
            {
                animator.SetTrigger("TriggerHit");

            }
        }
    }

    public void DestroyEnemyWithAnimation()
    {
        animator.SetTrigger("DestroyEnemy");

        Destroy(gameObject, 5f);
    }
}
