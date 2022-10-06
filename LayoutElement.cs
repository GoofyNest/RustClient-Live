public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 4980
{
	[SerializeField] 
	private bool m_IgnoreLayout; 
	[SerializeField] 
	private float m_MinWidth; 
	[SerializeField] 
	private float m_MinHeight; 
	[SerializeField] 
	private float m_PreferredWidth; 
	[SerializeField] 
	private float m_PreferredHeight; 
	[SerializeField] 
	private float m_FlexibleWidth; 
	[SerializeField] 
	private float m_FlexibleHeight; 
	[SerializeField] 
	private int m_LayoutPriority; 

	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }


	public virtual bool get_ignoreLayout() { }

	public virtual void set_ignoreLayout(bool value) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual void set_minWidth(float value) { }

	public virtual float get_minHeight() { }

	public virtual void set_minHeight(float value) { }

	public virtual float get_preferredWidth() { }

	public virtual void set_preferredWidth(float value) { }

	public virtual float get_preferredHeight() { }

	public virtual void set_preferredHeight(float value) { }

	public virtual float get_flexibleWidth() { }

	public virtual void set_flexibleWidth(float value) { }

	public virtual float get_flexibleHeight() { }

	public virtual void set_flexibleHeight(float value) { }

	public virtual int get_layoutPriority() { }

	public virtual void set_layoutPriority(int value) { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	protected override void OnDisable() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected void SetDirty() { }

}

