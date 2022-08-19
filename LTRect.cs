public class LTRect // TypeDefIndex: 5585
{	// Fields
	public Rect _rect; // 0x10
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

	// Properties
	public bool hasInitiliazed { get; }
	public int id { get; }
	public float x { get; set; }
	public float y { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Rect rect { get; set; }

	// Methods

	// RVA: 0x21A4690 Offset: 0x21A3A90 VA: 0x1821A4690
	public void .ctor() { }

	// RVA: 0x21A45F0 Offset: 0x21A39F0 VA: 0x1821A45F0
	public void .ctor(Rect rect) { }

	// RVA: 0x21A4500 Offset: 0x21A3900 VA: 0x1821A4500
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x21A42D0 Offset: 0x21A36D0 VA: 0x1821A42D0
	public void .ctor(float x, float y, float width, float height, float alpha) { }

	// RVA: 0x21A43D0 Offset: 0x21A37D0 VA: 0x1821A43D0
	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	// RVA: 0x21A4750 Offset: 0x21A3B50 VA: 0x1821A4750
	public bool get_hasInitiliazed() { }

	// RVA: 0x21A4770 Offset: 0x21A3B70 VA: 0x1821A4770
	public int get_id() { }

	// RVA: 0x21A4E60 Offset: 0x21A4260 VA: 0x1821A4E60
	public void setId(int id, int counter) { }

	// RVA: 0x21A4DB0 Offset: 0x21A41B0 VA: 0x1821A4DB0
	public void reset() { }

	// RVA: 0x21A4A40 Offset: 0x21A3E40 VA: 0x1821A4A40
	public void resetForRotation() { }

	// RVA: 0x21A4A20 Offset: 0x21A3E20 VA: 0x1821A4A20
	public float get_x() { }

	// RVA: 0x21A4F60 Offset: 0x21A4360 VA: 0x1821A4F60
	public void set_x(float value) { }

	// RVA: 0x21A4A30 Offset: 0x21A3E30 VA: 0x1821A4A30
	public float get_y() { }

	// RVA: 0x21A4F70 Offset: 0x21A4370 VA: 0x1821A4F70
	public void set_y(float value) { }

	// RVA: 0x21A4A10 Offset: 0x21A3E10 VA: 0x1821A4A10
	public float get_width() { }

	// RVA: 0x21A4F50 Offset: 0x21A4350 VA: 0x1821A4F50
	public void set_width(float value) { }

	// RVA: 0x21A4760 Offset: 0x21A3B60 VA: 0x1821A4760
	public float get_height() { }

	// RVA: 0x21A4F40 Offset: 0x21A4340 VA: 0x1821A4F40
	public void set_height(float value) { }

	// RVA: 0x21A4780 Offset: 0x21A3B80 VA: 0x1821A4780
	public Rect get_rect() { }

	// RVA: 0x1091450 Offset: 0x1090850 VA: 0x181091450
	public void set_rect(Rect value) { }

	// RVA: 0x21A4EA0 Offset: 0x21A42A0 VA: 0x1821A4EA0
	public LTRect setStyle(GUIStyle style) { }

	// RVA: 0x21A4E50 Offset: 0x21A4250 VA: 0x1821A4E50
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	// RVA: 0x21A4E40 Offset: 0x21A4240 VA: 0x1821A4E40
	public LTRect setColor(Color color) { }

	// RVA: 0x1998CA0 Offset: 0x19980A0 VA: 0x181998CA0
	public LTRect setAlpha(float alpha) { }

	// RVA: 0x21A4E70 Offset: 0x21A4270 VA: 0x1821A4E70
	public LTRect setLabel(string str) { }

	// RVA: 0x21A4F30 Offset: 0x21A4330 VA: 0x1821A4F30
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	// RVA: 0x21A4EC0 Offset: 0x21A42C0 VA: 0x1821A4EC0
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	// RVA: 0x21A4E90 Offset: 0x21A4290 VA: 0x1821A4E90
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	// RVA: 0x21A3EE0 Offset: 0x21A32E0 VA: 0x1821A3EE0 Slot: 3
	public override string ToString() { }

}

