using UnityEngine;

namespace Study3D.MiniGolf
{
    public class GameUI : MonoBehaviour
    {
        public static GameUI Instance;
        public GameObject clearUI;
        public GameObject nextStageButton;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
            
            clearUI.SetActive(false);
        }

        public void SetClearUI(bool apply)
        {
            if (apply == false) clearUI.SetActive(false);
            else
            {
                clearUI.SetActive(true);
                
                bool activeNextButton = GameManager.Instance.currentStageNumber != GameManager.Instance.MaxStage;
                nextStageButton.SetActive(activeNextButton);
            }
        }
    }
}