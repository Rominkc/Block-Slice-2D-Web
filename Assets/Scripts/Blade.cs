using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {
    public GameObject BladeTrailPrefab;
    bool isCutting = false;
    Rigidbody2D rb;
    Camera cam;
    GameObject currentBladeTrail;
    CircleCollider2D circleCollider;
    Vector2 previousPosition;
    public float minCuttingVelocity = .001f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
 
    }
	
	// Update is called once per frame, only do this when the game is in play, not when it is paused
	void Update () {
        if (Input.GetMouseButtonDown(0) && !PauseMenu.gameIsPaused)
        {
            startCutting();
        }
        else if (Input.GetMouseButtonUp(0) && !PauseMenu.gameIsPaused)
        {
            stopCutting();
        }

        if (isCutting)
        {
            updateCut();
        }
	}
    void updateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }
        previousPosition = newPosition;
    }

    void startCutting()
    {
        isCutting = true;
       currentBladeTrail = Instantiate(BladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = false;
    }

    void stopCutting()
    {
        isCutting = false;
        if (currentBladeTrail != null)
        {
            currentBladeTrail.transform.SetParent(null);
            Destroy(currentBladeTrail, 2f);
        }
        circleCollider.enabled = false;
    }
}
