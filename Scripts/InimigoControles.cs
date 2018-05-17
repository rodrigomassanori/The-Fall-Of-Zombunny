namespace InimigoControles
{
    using UnityEngine;
    using UnityEngine.AI;

    [RequireComponent(typeof(NavMeshAgent))]

    public class InimigoControles : MonoBehaviour
    {
        NavMeshAgent agent;

        Animator anim;

        public Transform target;

        public Transform returnToSpawn;

        bool FoundPlayer;

        float distToLostTarget = 8.0f;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();

            anim = GetComponent<Animator>();
        }

        void Start()
        {
            FoundPlayer = false;
        }

        void Update()
        {
            if (Vector3.Distance(transform.position, target.transform.position) 
            < distToLostTarget)
            {
                distToLostTarget -= 1.0f;

                agent.destination = target.transform.position;

                FoundPlayer = true;

                anim.SetBool("IsPlayerNear", FoundPlayer);
            }

            else
            {
                distToLostTarget += 1.0f;

                agent.destination = returnToSpawn.position;

                FoundPlayer = false;

                anim.SetBool("Back", FoundPlayer);
            }
        }
    }
}