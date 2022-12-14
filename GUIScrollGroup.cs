internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 4061
{
	public float calcMinWidth;
	public float calcMaxWidth;
	public float calcMinHeight;
	public float calcMaxHeight;
	public float clientWidth;
	public float clientHeight;
	public bool allowHorizontalScroll;
	public bool allowVerticalScroll;
	public bool needsHorizontalScrollbar;
	public bool needsVerticalScrollbar;
	public GUIStyle horizontalScrollbar;
	public GUIStyle verticalScrollbar;


	[RequiredByNativeCodeAttribute]
	public void .ctor() { }

	public override void CalcWidth() { }

	public override void SetHorizontal(float x, float width) { }

	public override void CalcHeight() { }

	public override void SetVertical(float y, float height) { }

}

