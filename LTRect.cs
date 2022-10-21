public class LTRect // TypeDefIndex: 5590
{
	public Rect _rect; 
	public float alpha; 
	public float rotation; 
	public Vector2 pivot; 
	public Vector2 margin; 
	public Rect relativeRect; 
	public bool rotateEnabled; 
	[HideInInspector] 
	public bool rotateFinished; 
	public bool alphaEnabled; 
	public string labelStr; 
	public LTGUI.Element_Type type; 
	public GUIStyle style; 
	public bool useColor; 
	public Color color; 
	public bool fontScaleToFit; 
	public bool useSimpleScale; 
	public bool sizeByHeight; 
	public Texture texture; 
	private int _id; 
	[HideInInspector] 
	public int counter; 
	public static bool colorTouched; 

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

