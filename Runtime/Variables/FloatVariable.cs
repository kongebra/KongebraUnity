using UnityEngine;

namespace Kongebra.Variables
{

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