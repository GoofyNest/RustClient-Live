internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 4055
{	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x104B3C0 Offset: 0x104A7C0 VA: 0x18104B3C0 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x1074D40 Offset: 0x1074140 VA: 0x181074D40 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x1A61B00 Offset: 0x1A60F00 VA: 0x181A61B00
	public void .ctor() { }

	// RVA: 0x1A5EF30 Offset: 0x1A5E330 VA: 0x181A5EF30 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A5F050 Offset: 0x1A5E450 VA: 0x181A5F050 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A60420 Offset: 0x1A5F820 VA: 0x181A60420
	public void ResetCursor() { }

	// RVA: 0x1A601C0 Offset: 0x1A5F5C0 VA: 0x181A601C0
	public GUILayoutEntry GetNext() { }

	// RVA: 0x1A5EED0 Offset: 0x1A5E2D0 VA: 0x181A5EED0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x1A5F980 Offset: 0x1A5ED80 VA: 0x181A5F980 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A60430 Offset: 0x1A5F830 VA: 0x181A60430 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A5F1C0 Offset: 0x1A5E5C0 VA: 0x181A5F1C0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A60D40 Offset: 0x1A60140 VA: 0x181A60D40 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x1A61670 Offset: 0x1A60A70 VA: 0x181A61670 Slot: 3
	public override string ToString() { }

}

