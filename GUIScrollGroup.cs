internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 4056
{	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A67D50 Offset: 0x1A67150 VA: 0x181A67D50
	public void .ctor() { }

	// RVA: 0x1A678A0 Offset: 0x1A66CA0 VA: 0x181A678A0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A67940 Offset: 0x1A66D40 VA: 0x181A67940 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A67750 Offset: 0x1A66B50 VA: 0x181A67750 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A67AB0 Offset: 0x1A66EB0 VA: 0x181A67AB0 Slot: 11
	public override void SetVertical(float y, float height) { }

}

