public abstract class TextProOnACurve : MonoBehaviour // TypeDefIndex: 7157
{
	private TMP_Text m_TextComponent; 


	private void Awake() { }

	private void OnEnable() { }

	public void ForceUpdate() { }

	protected abstract bool ParametersHaveChanged();

	protected abstract Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx);

	protected void .ctor() { }

}

