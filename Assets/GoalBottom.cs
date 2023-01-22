using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBottom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerController player = col.gameObject.GetComponent<PlayerController>();
        if (player is null) return;

        player.goalReachedBottom = true;
    }
}