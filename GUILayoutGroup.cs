internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 4055
{
	public List<GUILayoutEntry> entries; 
	public bool isVertical; 
	public bool resetCoords; 
	public float spacing; 
	public bool sameSize; 
	public bool isWindow; 
	public int windowID; 
	private int m_Cursor; 
	protected int m_StretchableCountX; 
	protected int m_StretchableCountY; 
	protected bool m_UserSpecifiedWidth; 
	protected bool m_UserSpecifiedHeight; 
	protected float m_ChildMinWidth; 
	protected float m_ChildMaxWidth; 
	protected float m_ChildMinHeight; 
	protected float m_ChildMaxHeight; 
	protected int m_MarginLeft; 
	protected int m_MarginRight; 
	protected int m_MarginTop; 
	protected int m_MarginBottom; 

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

