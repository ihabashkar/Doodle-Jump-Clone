using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount = 300;

    void Start()
    {
        Camera cam = Camera.main;
        float camHeight = cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float minX = -camWidth * 0.9f;
        float maxX = camWidth * 0.9f;

        float lastY = 0f;

        for (int i = 0; i < platformCount; i++)
        {
            // vertical spacing tuned for a jumpForce ~10 (reachable but not cramped)
            float yGap = Random.Range(1.5f, 3.5f);
            lastY += yGap;

            // horizontal spread across full camera width
            float x = Random.Range(minX, maxX);

            Instantiate(platformPrefab, new Vector3(x, lastY, 0f), Quaternion.identity);
        }
    }

}
