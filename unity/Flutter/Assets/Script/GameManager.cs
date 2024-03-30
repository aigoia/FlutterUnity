using TMPro;
using UnityEngine;

namespace Script
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI say;

        public void ShowTexture(string text)
        {
            say.text = text;
        }
    }
}
