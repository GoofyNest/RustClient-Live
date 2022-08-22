public class LTRect // TypeDefIndex: 5585
{	public Rect _rect; // 0x10
	public float alpha; // 0x20
	public float rotation; // 0x24
	public Vector2 pivot; // 0x28
	public Vector2 margin; // 0x30
	public Rect relativeRect; // 0x38
	public bool rotateEnabled; // 0x48
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool rotateFinished; // 0x49
	public bool alphaEnabled; // 0x4A
	public string labelStr; // 0x50
	public LTGUI.Element_Type type; // 0x58
	public GUIStyle style; // 0x60
	public bool useColor; // 0x68
	public Color color; // 0x6C
	public bool fontScaleToFit; // 0x7C
	public bool useSimpleScale; // 0x7D
	public bool sizeByHeight; // 0x7E
	public Texture texture; // 0x80
	private int _id; // 0x88
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int counter; // 0x8C
	public static bool colorTouched; // 0x0

	public bool hasInitiliazed { get; }
	public int id { get; }
	public float x { get; set; }
	public float y { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Rect rect { get; set; }


	public void .ctor() { }

	public void .ctor(Rect rect) { }

	public void .ctor(float x, float y, float width, float height) { }

	public void .ctor(float x, float y, float width, float height, float alpha) { }

	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	public bool get_hasInitiliazed() { }

	public int get_id() { }

	public void setId(int id, int counter) { }

	public void reset() { }

	public void resetForRotation() { }

	public float get_x() { }

	public void set_x(float value) { }

	public float get_y() { }

	public void set_y(float value) { }

	public float get_width() { }

	public void set_width(float value) { }

	public float get_height() { }

	public void set_height(float value) { }

	public Rect get_rect() { }

	public void set_rect(Rect value) { }

	public LTRect setStyle(GUIStyle style) { }

	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	public LTRect setColor(Color color) { }

	public LTRect setAlpha(float alpha) { }

	public LTRect setLabel(string str) { }

	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	public LTRect setSizeByHeight(bool sizeByHeight) { }

	public override string ToString() { }

}

