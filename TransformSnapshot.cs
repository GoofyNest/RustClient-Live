public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12120
{
	[CompilerGeneratedAttribute] 
	private float <Time>k__BackingField; 
	public Vector3 pos; 
	public Quaternion rot; 

	public float Time { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Time() { }

	[CompilerGeneratedAttribute] 
	public void set_Time(float value) { }

	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	public void MatchValuesTo(TransformSnapshot entry) { }

	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	public TransformSnapshot GetNew() { }

}

