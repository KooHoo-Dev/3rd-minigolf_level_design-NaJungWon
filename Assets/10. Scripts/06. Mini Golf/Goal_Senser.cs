using UnityEngine;

namespace Study3D.MiniGolf
{
    public class Goal_Senser : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject == GameManager.Instance.golfBall.ball.gameObject)
            {
                //GameManager.Instance.currentStageNumber++;
                GameManager.Instance.RequestClearUI(true);
            }
        }
    }
}