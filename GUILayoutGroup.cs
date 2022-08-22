internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 4055
{	public List<GUILayoutEntry> entries; // 0x48
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

	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }


	public override int get_marginLeft() { }

	public override int get_marginRight() { }

	public override int get_marginTop() { }

	public override int get_marginBottom() { }

	public void .ctor() { }

	public override void ApplyOptions(GUILayoutOption[] options) { }

	protected override void ApplyStyleSettings(GUIStyle style) { }

	public void ResetCursor() { }

	public GUILayoutEntry GetNext() { }

	public void Add(GUILayoutEntry e) { }

	public override void CalcWidth() { }

	public override void SetHorizontal(float x, float width) { }

	public override void CalcHeight() { }

	public override void SetVertical(float y, float height) { }

	public override string ToString() { }

}

