using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        float x = Random.Range(-25, 26);
        float y = 0;
        float z = Random.Range(-25, 26);
        Vector3 pos = new Vector3(x, y, z);
        agent.destination = pos; 
    }
    // Update is called once per frame
    void Update()
    {

    }
}
