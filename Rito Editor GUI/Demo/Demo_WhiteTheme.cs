using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

// 날짜 : 2021-05-27 AM 2:31:20
// 작성자 : Rito

namespace Rito.EditorUtilities.Demo
{
    using RGUI = RitoEditorGUI;

    public class Demo_WhiteTheme : Demo_ThemeBase
    {
        [CustomEditor(typeof(Demo_WhiteTheme))]
        private class CE : UnityEditor.Editor
        {
            private Demo_WhiteTheme m;
            private void OnEnable()
            {
                m = target as Demo_WhiteTheme;
            }

            public override void OnInspectorGUI()
            {
                RGUI.Options
                    .SetMargins(top: 12f, left: 12f, right: 20f, bottom: 16f)
                    .ActivateRectDebugger(true)
                    .AcrivateTooltipDebugger(true)
                    .Init();

                // ------------------------------------------------------
                FoldoutHeaderBox.White
                    .SetData(m.bool1, "Foldout Header Box", 2f, 2f)
                    .Draw(20f, 62f)
                    .HeaderSpace()
                    .Get(out m.bool1);

                if (m.bool1)
                {
                    Label.White
                        .SetData("Label 012345")
                        .Draw(0.01f, 0.4f);
                    SelectableLabel.White
                        .SetData("Selectable Label")
                        .Draw(0.4f, 0.99f).Layout();

                    IntField.White
                        .SetData("Int Field", m.int1)
                        .Draw(0.01f, 0.99f).Layout()
                        .Get(out m.int1);

                    IntSlider.White
                        .SetData("Int Slider", m.int2, 0, 10)
                        .Draw(0.01f, 0.99f).Layout()
                        .Get(out m.int2);

                    RGUI.Space(4f);
                }

                RGUI.Space(8f);

                // ------------------------------------------------------
                HeaderBox.White
                    .SetData("Header Box", 2f, 2f)
                    .DrawLayout(4);

                Vector3Field.White
                    .SetData("Vector3 Field", m.vector3)
                    .DrawLayout(0.01f, 0.99f).Get(out m.vector3);

                BoolField.White
                    .SetData("Bool Field", m.bool2)
                    .DrawLayout(0.01f, 0.99f).Get(out m.bool2);

                StringField.White
                    .SetData("String Field", m.string1, "Placeholder")
                    .DrawLayout(0.01f, 0.99f).Get(out m.string1);

                Button.White
                    .SetData("Button")
                    .Draw(0.01f, 0.49f);
                ToggleButton.White
                    .SetData("Toggle Button", m.bool3)
                    .Draw(0.5f, 0.99f).Layout(2f).Get(out m.bool3);

                RGUI.Space(12f);

                // ------------------------------------------------------
                Box.White
                    .SetData(2f)
                    .DrawLayout(4, 2f, 0f);

                ColorField.White
                    .SetData("Color Field", m.color1)
                    .DrawLayout(0.01f, 0.99f).Get(out m.color1);

                ObjectField<Material>.White
                    .SetData("Material Field", m.material1)
                    .DrawLayout(0.01f, 0.99f).Get(out m.material1);

                Dropdown<float>.White
                    .SetData("Float Dropdown", m.fList, m.fSelected)
                    .DrawLayout(0.01f, 0.99f).Get(out m.fSelected);

                HelpBox.White
                    .SetData("Help Box", MessageType.Warning)
                    .DrawLayout(0.01f, 0.99f);

                RGUI.Space(8f);

                // ------------------------------------------------------
                Label.White
                    .SetData("Label ABCD abcd")
                    .Draw(0f, 0.4f);

                SelectableLabel.White
                    .SetData("Selectable Label")
                    .Draw(0.4f, 1.0f).Layout();

                FloatField.White
                    .SetData("Float Field", m.float1)
                    .DrawLayout().Get(out m.float1);

                Vector4Field.White
                    .SetData("Vector4 Field", m.vector4)
                    .DrawLayout().Get(out m.vector4);

                FloatSlider.White
                    .SetData("Float Slider", m.float2, 0f, 1f)
                    .DrawLayout().Get(out m.float2);

                TextArea.White
                    .SetData(m.string2, "Text Area")
                    .DrawLayout().Get(out m.string2);

                ColorPicker.White
                    .SetData(m.color2)
                    .DrawLayout().Get(out m.color2);

                HelpBox.White
                    .SetData("Help Box", MessageType.Error)
                    .DrawLayout();

                Dropdown<string>.White
                    .SetData("String Dropdown", m.sArray, m.sSelected)
                    .DrawLayout().Get(out m.sSelected);

                Toggle.White
                    .SetData(m.bool4)
                    .DrawLayout().Get(out m.bool4);

                Button.White
                    .SetData("Button")
                    .Draw(0f, 0.49f);
                ToggleButton.White
                    .SetData("Toggle Button", m.bool5)
                    .Draw(0.5f, 1.0f).Layout().Get(out m.bool5);

                RGUI.Finalize(this);
            }
        }
    }
}