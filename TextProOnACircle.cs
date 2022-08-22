public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
{
internal class <Module> // TypeDefIndex: 7120

[ExecuteInEditMode] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
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


	protected override bool ParametersHaveChanged() { }

	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	public void .ctor() { }

}

