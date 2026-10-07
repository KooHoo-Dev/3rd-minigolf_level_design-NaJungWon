using UnityEngine;
using UnityEngine.Serialization;

namespace Study3D.MiniGolf
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public GameObject[] GameStages;
        public GolfBallTester golfBall;
        public int MaxStage => GameStages.Length - 1;
        public int currentStageNumber = 0;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            for (int i = 0; i < GameStages.Length; i++)
            {
                GameStages[i].SetActive(false);
            }
            
            GameStages[currentStageNumber].SetActive(true);
        }

        public void SetNextStage()
        {
            currentStageNumber++;
            if(currentStageNumber - 1 >= 0) GameStages[currentStageNumber - 1].SetActive(false);
            GameStages[currentStageNumber].SetActive(true);
            golfBall.ball.PlaceAt(golfBall.startPosition);
            RequestClearUI(false);
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void RequestClearUI(bool apply)
        {
            GameUI.Instance.SetClearUI(apply);
        }
    }
}