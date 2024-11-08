using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    private GameManager gameManager;
    private Target[] targets;
    private int currentTargetIndex = 0;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask obstacleLayer;
   
   

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        targets = FindObjectsOfType<Target>();
        FaceNextVisibleTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FaceNextVisibleTarget();
        }
    }

    private void FaceNextVisibleTarget()
    {
        int targetCount = targets.Length;

        currentTargetIndex = (currentTargetIndex + 1) % targetCount;
        Target target = targets[currentTargetIndex];
        playerCamera.transform.LookAt(target.transform);





    }


}



