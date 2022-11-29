public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 4976
{
	[SerializeField] 
	protected float m_Spacing; 
	[SerializeField] 
	protected bool m_ChildForceExpandWidth; 
	[SerializeField] 
	protected bool m_ChildForceExpandHeight; 
	[SerializeField] 
	protected bool m_ChildControlWidth; 
	[SerializeField] 
	protected bool m_ChildControlHeight; 
	[SerializeField] 
	protected bool m_ChildScaleWidth; 
	[SerializeField] 
	protected bool m_ChildScaleHeight; 

	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }


	public float get_spacing() { }

	public void set_spacing(float value) { }

	public bool get_childForceExpandWidth() { }

	public void set_childForceExpandWidth(bool value) { }

	public bool get_childForceExpandHeight() { }

	public void set_childForceExpandHeight(bool value) { }

	public bool get_childControlWidth() { }

	public void set_childControlWidth(bool value) { }

	public bool get_childControlHeight() { }

	public void set_childControlHeight(bool value) { }

	public bool get_childScaleWidth() { }

	public void set_childScaleWidth(bool value) { }

	public bool get_childScaleHeight() { }

	public void set_childScaleHeight(bool value) { }

	protected void CalcAlongAxis(int axis, bool isVertical) { }

	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	protected void .ctor() { }

}

