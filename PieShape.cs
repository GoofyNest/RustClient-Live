public class PieShape : Graphic // TypeDefIndex: 11197
{	// Fields
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float outerSize; // 0x90
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float innerSize; // 0x94
	public float startRadius; // 0x98
	public float endRadius; // 0x9C
	public float border; // 0xA0
	public bool debugDrawing; // 0xA4

	// Methods

	// RVA: 0x8D1930 Offset: 0x8D0D30 VA: 0x1808D1930 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vbo) { }

	// RVA: 0x8D20C0 Offset: 0x8D14C0 VA: 0x1808D20C0
	public void .ctor() { }

}

