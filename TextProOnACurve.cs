public abstract class TextProOnACurve : MonoBehaviour // TypeDefIndex: 7122
{	// Fields
	private TMP_Text m_TextComponent; // 0x18

	// Methods

	// RVA: 0x22C2FA0 Offset: 0x22C23A0 VA: 0x1822C2FA0
	private void Awake() { }

	// RVA: 0x22C3890 Offset: 0x22C2C90 VA: 0x1822C3890
	private void OnEnable() { }

	// RVA: 0x22C3000 Offset: 0x22C2400 VA: 0x1822C3000
	public void ForceUpdate() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool ParametersHaveChanged();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx);

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

