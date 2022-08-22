internal class GUILayoutEntry // TypeDefIndex: 4053
{	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

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

