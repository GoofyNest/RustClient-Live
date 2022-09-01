public static class LayoutUtility // TypeDefIndex: 4982
{

	public static float GetMinSize(RectTransform rect, int axis) { }

	public static float GetPreferredSize(RectTransform rect, int axis) { }

	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	public static float GetMinWidth(RectTransform rect) { }

	public static float GetPreferredWidth(RectTransform rect) { }

	public static float GetFlexibleWidth(RectTransform rect) { }

	public static float GetMinHeight(RectTransform rect) { }

	public static float GetPreferredHeight(RectTransform rect) { }

	public static float GetFlexibleHeight(RectTransform rect) { }

	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }

}

private sealed class LayoutUtility.<>c // TypeDefIndex: 4983
{
	public static readonly LayoutUtility.<>c <>9; 
	public static Func<ILayoutElement, float> <>9__3_0; 
	public static Func<ILayoutElement, float> <>9__4_0; 
	public static Func<ILayoutElement, float> <>9__4_1; 
	public static Func<ILayoutElement, float> <>9__5_0; 
	public static Func<ILayoutElement, float> <>9__6_0; 
	public static Func<ILayoutElement, float> <>9__7_0; 
	public static Func<ILayoutElement, float> <>9__7_1; 
	public static Func<ILayoutElement, float> <>9__8_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

