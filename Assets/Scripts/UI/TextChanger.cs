using UnityEngine;

using TMPro;

namespace Runner.UI
{
    public class TextChanger : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textField;

        public void ChangeText(int value)
        {
            _textField.text = value.ToString();
        }
    }
}
