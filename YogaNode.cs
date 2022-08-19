internal class YogaNode // TypeDefIndex: 4579
{	// Fields
	internal IntPtr _ygNode; // 0x10
	private MeasureFunction _measureFunction; // 0x18
	private BaselineFunction _baselineFunction; // 0x20

	// Properties
	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }

	// Methods

	// RVA: 0x22F2B90 Offset: 0x22F1F90 VA: 0x1822F2B90
	public float get_LayoutX() { }

	// RVA: 0x22F2BD0 Offset: 0x22F1FD0 VA: 0x1822F2BD0
	public float get_LayoutY() { }

	// RVA: 0x22F2B50 Offset: 0x22F1F50 VA: 0x1822F2B50
	public float get_LayoutWidth() { }

	// RVA: 0x22F2B10 Offset: 0x22F1F10 VA: 0x1822F2B10
	public float get_LayoutHeight() { }

	// RVA: 0x22F2A50 Offset: 0x22F1E50 VA: 0x1822F2A50
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F29B0 Offset: 0x22F1DB0 VA: 0x1822F29B0
	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

