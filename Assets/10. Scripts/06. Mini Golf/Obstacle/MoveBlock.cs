using UnityEngine;
using UnityEngine.UIElements;

public class MoveBlock : MonoBehaviour
{
    public Vector3 movePos;
    public float moveSpeed;
    private Vector3 startPos;

    public float delayTime;
    private float coolTime;

    private void Awake()
    {
        startPos = transform.position;
    }
    
    private void Update()
    {
        if (coolTime > 0)
        {
            coolTime -= Time.deltaTime;
            return;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, movePos, moveSpeed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, movePos);

        if (distance <= 0.01f)
        {
            //(startPos, movePos) = (movePos, startPos); 이건 또 신기하네
            Vector3 temp = startPos;
            startPos = movePos;
            movePos = temp;
            coolTime = delayTime;
        }
    }
}
