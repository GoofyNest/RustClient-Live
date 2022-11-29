public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7161
{

internal class <Module>

[ExecuteInEditMode] 
public class TextProOnACircle : TextProOnACurve
	[SerializeField] 
	[TooltipAttribute] 
	private float m_radius; 
	[TooltipAttribute] 
	public float m_arcDegrees; 
	[SerializeField] 
	[TooltipAttribute] 
	private float m_angularOffset; 
	private float m_oldRadius; 
	private float m_oldArcDegrees; 
	private float m_oldAngularOffset; 


	protected override bool ParametersHaveChanged() { }

	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	public void .ctor() { }

}

