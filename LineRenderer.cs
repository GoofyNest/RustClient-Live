public sealed class LineRenderer : Renderer // TypeDefIndex: 3402
{
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute]
	public int positionCount { get; set; }


	[ObsoleteAttribute]
	public void SetColors(Color start, Color end) { }

	public void set_startColor(Color value) { }

	public void set_endColor(Color value) { }

	public int get_positionCount() { }

	public void set_positionCount(int value) { }

	public void SetPosition(int index, Vector3 position) { }

	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute]
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute]
	public void SetPositions(Vector3[] positions) { }

	private void set_startColor_Injected(ref Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

