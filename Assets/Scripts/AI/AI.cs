using UnityEngine;
using UnityEngine.AI;
public class AI : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;

    public GameObject destiny_point;
    public GameObject second_destiny_point;

    private void Start()
    {
        navMeshAgent.destination = destiny_point.transform.position;

    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position,destiny_point.transform.position);

        if (distance < 2)
        {
            navMeshAgent.destination = second_destiny_point.transform.position;

        }
    }

}
