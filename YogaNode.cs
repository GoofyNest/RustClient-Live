internal class YogaNode // TypeDefIndex: 4579
{
	internal IntPtr _ygNode; 
	private MeasureFunction _measureFunction; 
	private BaselineFunction _baselineFunction; 

	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }


	public float get_LayoutX() { }

	public float get_LayoutY() { }

	public float get_LayoutWidth() { }

	public float get_LayoutHeight() { }

	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

