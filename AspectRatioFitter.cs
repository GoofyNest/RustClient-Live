public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4961
{
	[SerializeField] 
	private AspectRatioFitter.AspectMode m_AspectMode; 
	[SerializeField] 
	private float m_AspectRatio; 
	private RectTransform m_Rect; 
	private bool m_DelayedSetDirty; 
	private DrivenRectTransformTracker m_Tracker; 

	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }


	public AspectRatioFitter.AspectMode get_aspectMode() { }

	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	public float get_aspectRatio() { }

	public void set_aspectRatio(float value) { }

	private RectTransform get_rectTransform() { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected virtual void Update() { }

	protected override void OnRectTransformDimensionsChange() { }

	private void UpdateRect() { }

	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	private Vector2 GetParentSize() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	protected void SetDirty() { }

}

public enum AspectRatioFitter.AspectMode // TypeDefIndex: 4962
{
	public int value__; 
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;

}

