using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.Controls;
public class AI : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;


    public Transform[] destinations;

    private int i = 0;

    [Header ( " --- FOLLOW PLAYER ----")]
    public  bool follow_player;

    private GameObject player;

    private float distance_to_player;

    public float distance_to_follow = 10;

  

    private void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
        player = FindAnyObjectByType<PlayerMovement>().gameObject;


    }

    private void Update()
    {
        distance_to_player =
            Vector3.Distance(transform.position, player.transform.position);

        if (distance_to_player <= distance_to_follow && follow_player )
        {
            FollowPlayer();
        } else
        {
            EnemyPath();
        }
       
    }


    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].transform.position;

        if (Vector3.Distance(transform.position, destinations[i].position) <= 2)
        {
            if (destinations[i] != destinations[destinations.Length - 1])
            {
                i = i + 1;
            } else
            {
                i = 0;

            }
        }

    }

    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }

}
 