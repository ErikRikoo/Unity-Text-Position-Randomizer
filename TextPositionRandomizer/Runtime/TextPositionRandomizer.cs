using System;
using System.Text;
using TextPositionRandomizer.Runtime.Utilities;
using UnityEngine;
using TMPro;

namespace TextPositionRandomizer.Runtime
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextPositionRandomizer : MonoBehaviour
    {
        private TextMeshProUGUI m_Text;

        [SerializeField] private string m_CachedText;
        [SerializeField] private FloatRange m_HorizontalRange;
        [SerializeField] private FloatRange m_VerticalRange;

        private void OnValidate()
        {
            Initialize();
            m_Text.text = GenerateNewRandomText();
        }

        private string GenerateNewRandomText()
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < m_CachedText.Length; i++)
            {
                char currentChar = m_CachedText[i];
                float horizontalShift = m_HorizontalRange.Range();
                float verticalShift = m_VerticalRange.Range();
                sb.Append(FormattableString.Invariant($"<voffset={verticalShift}em>{currentChar}<space={horizontalShift}em></voffset>"));
            }
            
            return sb.ToString();
        }

        private void Initialize()
        {
            if (m_Text == null)
            {
                m_Text = GetComponent<TextMeshProUGUI>();
            }

            if (m_CachedText == null)
            {
                m_CachedText = m_Text.text;
            }
        }
    }
}