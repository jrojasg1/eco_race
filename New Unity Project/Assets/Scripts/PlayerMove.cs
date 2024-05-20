using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;    // Update is called once per frame
    [SerializeField] private float limitValue;
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            
           movePlayer();
        }
        
    }

    private void movePlayer()
    {
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalXPos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);
        playerTransform.localPosition = new Vector3(finalXPos, 1, 0);
    }
}
