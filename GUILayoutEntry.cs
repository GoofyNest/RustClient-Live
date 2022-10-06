internal class GUILayoutEntry // TypeDefIndex: 4056
{
	public float minWidth; 
	public float maxWidth; 
	public float minHeight; 
	public float maxHeight; 
	public Rect rect; 
	public int stretchWidth; 
	public int stretchHeight; 
	public bool consideredForMargin; 
	private GUIStyle m_Style; 
	internal static Rect kDummyRect; 
	protected static int indent; 

	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }


	public GUIStyle get_style() { }

	public void set_style(GUIStyle value) { }

	public virtual int get_marginLeft() { }

	public virtual int get_marginRight() { }

	public virtual int get_marginTop() { }

	public virtual int get_marginBottom() { }

	public int get_marginHorizontal() { }

	public int get_marginVertical() { }

	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	public virtual void CalcWidth() { }

	public virtual void CalcHeight() { }

	public virtual void SetHorizontal(float x, float width) { }

	public virtual void SetVertical(float y, float height) { }

	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	public override string ToString() { }

	private static void .cctor() { }

}

