public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4967
{
	[SerializeField] 
	protected ContentSizeFitter.FitMode m_HorizontalFit; 
	[SerializeField] 
	protected ContentSizeFitter.FitMode m_VerticalFit; 
	private RectTransform m_Rect; 
	private DrivenRectTransformTracker m_Tracker; 

	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }


	public ContentSizeFitter.FitMode get_horizontalFit() { }

	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	public ContentSizeFitter.FitMode get_verticalFit() { }

	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	private RectTransform get_rectTransform() { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnRectTransformDimensionsChange() { }

	private void HandleSelfFittingAlongAxis(int axis) { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	protected void SetDirty() { }

}

public enum ContentSizeFitter.FitMode // TypeDefIndex: 4968
{
	public int value__; 
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;

}

