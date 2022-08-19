public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	// Properties
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E0F0 Offset: 0x8D4F0 VA: 0x18008E0F0
	public int positionCount { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x8DD90 Offset: 0x8D190 VA: 0x18008DD90
	// RVA: 0x18E55F0 Offset: 0x18E49F0 VA: 0x1818E55F0
	public void SetColors(Color start, Color end) { }

	// RVA: 0x18E58D0 Offset: 0x18E4CD0 VA: 0x1818E58D0
	public void set_startColor(Color value) { }

	// RVA: 0x18E57F0 Offset: 0x18E4BF0 VA: 0x1818E57F0
	public void set_endColor(Color value) { }

	// RVA: 0x18E5760 Offset: 0x18E4B60 VA: 0x1818E5760
	public int get_positionCount() { }

	// RVA: 0x18E5840 Offset: 0x18E4C40 VA: 0x1818E5840
	public void set_positionCount(int value) { }

	// RVA: 0x18E56C0 Offset: 0x18E4AC0 VA: 0x1818E56C0
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x18E5540 Offset: 0x18E4940 VA: 0x1818E5540
	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DE30 Offset: 0x8D230 VA: 0x18008DE30
	// RVA: 0x18E55A0 Offset: 0x18E49A0 VA: 0x1818E55A0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8DED0 Offset: 0x8D2D0 VA: 0x18008DED0
	// RVA: 0x18E5710 Offset: 0x18E4B10 VA: 0x1818E5710
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x18E5880 Offset: 0x18E4C80 VA: 0x1818E5880
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x18E57A0 Offset: 0x18E4BA0 VA: 0x1818E57A0
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x18E5670 Offset: 0x18E4A70 VA: 0x1818E5670
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x18E54F0 Offset: 0x18E48F0 VA: 0x1818E54F0
	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

