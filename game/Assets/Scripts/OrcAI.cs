using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OrcAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TheDestination;
    NavMeshAgent TheAgent;
    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TheAgent.SetDestination(TheDestination.transform.position);
    }
}
