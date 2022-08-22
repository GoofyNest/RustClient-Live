public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E0F0 Offset: 0x8D4F0 VA: 0x18008E0F0
	public int positionCount { get; set; }


	[ObsoleteAttribute] // RVA: 0x8DD90 Offset: 0x8D190 VA: 0x18008DD90
	public void SetColors(Color start, Color end) { }

	public void set_startColor(Color value) { }

	public void set_endColor(Color value) { }

	public int get_positionCount() { }

	public void set_positionCount(int value) { }

	public void SetPosition(int index, Vector3 position) { }

	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DE30 Offset: 0x8D230 VA: 0x18008DE30
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8DED0 Offset: 0x8D2D0 VA: 0x18008DED0
	public void SetPositions(Vector3[] positions) { }

	private void set_startColor_Injected(ref Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

