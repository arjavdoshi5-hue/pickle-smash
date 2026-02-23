using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    [Header("Swipe Settings")]
    public float minSwipeDistance = 50f;
    public float fastSwipeSpeedThreshold = 1000f;
    public float lobMinimumDuration = 0.4f;
    public float lobMinimumDistance = 200f;

    private Vector2 startTouchPosition;
    private float startTime;

    void Start()
    {
        Debug.Log("--- SWIPE MANAGER IS AWAKE ---");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("--- MOUSE CLICK DETECTED ---");
        }

        // 1. Mouse Input (For Editor Testing)
        if (Input.GetMouseButtonDown(0))
        {
            startTouchPosition = Input.mousePosition;
            startTime = Time.time;
            Debug.Log("Swipe Started");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endTouchPosition = Input.mousePosition;
            float endTime = Time.time;
            DetectSwipe(startTouchPosition, endTouchPosition, endTime - startTime);
        }

        // 2. Touch Input (For Mobile Devices)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
                startTime = Time.time;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Vector2 endTouchPosition = touch.position;
                float endTime = Time.time;
                DetectSwipe(startTouchPosition, endTouchPosition, endTime - startTime);
            }
        }
    }

    private void DetectSwipe(Vector2 startPos, Vector2 endPos, float duration)
    {
        Vector2 swipeVector = endPos - startPos;
        float swipeDistance = swipeVector.magnitude;

        // Ignore tiny accidental touches
        if (swipeDistance < minSwipeDistance)
            return;

        Vector2 direction = swipeVector.normalized;
        CategorizeSwipe(direction, swipeDistance, duration);
    }

    private void CategorizeSwipe(Vector2 direction, float distance, float duration)
    {
        float speed = distance / duration;

        // Is it mostly horizontal or vertical?
        bool isVertical = Mathf.Abs(direction.y) > Mathf.Abs(direction.x);

        if (isVertical)
        {
            if (direction.y > 0)
            {
                // Upward swipe
                if (speed >= fastSwipeSpeedThreshold)
                {
                    Debug.Log("🎯 SHOT: Drive (Fast Upward Topspin)");
                }
                else if (duration >= lobMinimumDuration && distance >= lobMinimumDistance)
                {
                    Debug.Log("☁️ SHOT: Lob (Long, slow upward)");
                }
                else
                {
                    Debug.Log("🏓 SHOT: Dink (Short, soft upward)");
                }
            }
            else
            {
                // Downward swipe
                Debug.Log("💥 SHOT: Smash (Downward finish)");
            }
        }
        else
        {
            // Horizontal swipe
            Debug.Log("🎯 SHOT: Drive (Fast flat horizontal)");
        }
    }
}
