public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
{
// Namespace: 
internal class <Module> // TypeDefIndex: 7120

// Namespace: ntw.CurvedTextMeshPro
[ExecuteInEditMode] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
	// Fields
	[SerializeField] // RVA: 0x7FE10 Offset: 0x7F210 VA: 0x18007FE10
	[TooltipAttribute] // RVA: 0x7FE10 Offset: 0x7F210 VA: 0x18007FE10
	private float m_radius; // 0x20
	[TooltipAttribute] // RVA: 0x7FF80 Offset: 0x7F380 VA: 0x18007FF80
	public float m_arcDegrees; // 0x24
	[SerializeField] // RVA: 0x80020 Offset: 0x7F420 VA: 0x180080020
	[TooltipAttribute] // RVA: 0x80020 Offset: 0x7F420 VA: 0x180080020
	private float m_angularOffset; // 0x28
	private float m_oldRadius; // 0x2C
	private float m_oldArcDegrees; // 0x30
	private float m_oldAngularOffset; // 0x34

	// Methods

	// RVA: 0x22C2F00 Offset: 0x22C2300 VA: 0x1822C2F00 Slot: 4
	protected override bool ParametersHaveChanged() { }

	// RVA: 0x22C2C50 Offset: 0x22C2050 VA: 0x1822C2C50 Slot: 5
	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	// RVA: 0x22C2F60 Offset: 0x22C2360 VA: 0x1822C2F60
	public void .ctor() { }

}

