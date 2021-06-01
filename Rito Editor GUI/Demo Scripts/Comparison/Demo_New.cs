#if UNITY_EDITOR

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// 날짜 : 2021-06-01 AM 2:18:13
// 작성자 : Rito

namespace Rito.EditorUtilities.Demo
{
    public class Demo_New : MonoBehaviour
    {
        public string stringValue;
        public bool foldoutValue, toggleButtonValue;

        public float[] floatArray = { 0.1f, 0.2f, 0.3f, 0.4f };
        public int floatSelected;

        [CustomEditor(typeof(Demo_New))]
        private class CE : UnityEditor.Editor
        {
            private Demo_New m;
            private void OnEnable() => m = target as Demo_New;

            public override void OnInspectorGUI()
            {
                RitoEditorGUI.Settings
                    .SetMargins(top : 8f, bottom : 6f)
                    .SetLayoutControlXPositions(0.01f, 0.985f)
                    .ActivateRectDebugger()
                    .ActivateTooltipDebugger()
                    .Init();

                const float boxOutlineWidth = 2f;

                FoldoutHeaderBox.Blue
                    .SetData("Header Box", m.foldoutValue, boxOutlineWidth, 4f)
                    .DrawLayout(3, 2f)
                    .Get(out m.foldoutValue);

                if (m.foldoutValue)
                {
                    StringField.Violet
                        .SetData("String Field", m.stringValue, "Placeholder")
                        .DrawLayout().Get(out m.stringValue);

                    // float Dropdown
                    Dropdown<float>.Purple
                        .SetData("Float Dropdown", m.floatArray, m.floatSelected)
                        .DrawLayout().Get(out m.floatSelected);

                    const float buttonRatio = 0.7f;

                    // Button & ToggleButton -> Width 8:2
                    Button.Blue
                        .SetData("Button")
                        .Draw(0.01f, buttonRatio, 20f);

                    ToggleButton.Blue
                        .SetData("Toggle Button", m.toggleButtonValue)
                        .Draw(buttonRatio + 0.01f, 0.985f, 20f).Layout()
                        .Get(out m.toggleButtonValue);
                }

                RitoEditorGUI.Space(boxOutlineWidth);

                RitoEditorGUI.Finalize(this);
            }
        }
    }
}

#endif