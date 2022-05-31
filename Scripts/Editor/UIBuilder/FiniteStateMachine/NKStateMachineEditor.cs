#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace NK.StateMachine.NKEditor
{
    public class NKStateMachineEditor : EditorWindow
    {
        [MenuItem("NK/State Machine/Editor...")]
        public static void OpenWindow()
        {
            NKStateMachineEditor wnd = GetWindow<NKStateMachineEditor>();
            wnd.titleContent = new GUIContent("State Machine Editor");
        }

        public void CreateGUI()
        {
            VisualElement root = rootVisualElement;

            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
                "Assets/Plugins/NKTools/NKFiniteStateMachine/Scripts/Editor/UIBuilder/FiniteStateMachine/NKStateMachineEditor.uxml");
            visualTree.CloneTree(root);

            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(
                "Assets/Plugins/NKTools/NKFiniteStateMachine/Scripts/Editor/UIBuilder/FiniteStateMachine/NKStateMachineEditor.uss");
            root.styleSheets.Add(styleSheet);
        }
    }
}
#endif