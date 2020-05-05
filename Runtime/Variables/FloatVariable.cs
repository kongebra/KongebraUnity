using UnityEngine;

namespace Kongebra.Variables
{
    // Credit: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Variables/FloatVariable.cs
    [CreateAssetMenu(fileName = "New Float Variable", menuName = "Kongebra/Variables/Float Variable", order = 0)]
    public class FloatVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public float Value;

        public void SetValue(float value) {
            Value = value;
        }

        public void SetValue(FloatVariable variable) {
            Value = variable.Value;
        }

        public void ApplyChange(float amount) {
            Value += amount;
        }

        public void ApplyChange(FloatVariable variable) {
            Value += variable.Value;
        }
    }
}