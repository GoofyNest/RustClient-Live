public class TextContainer : UIBehaviour // TypeDefIndex: 6869
{
	private bool m_hasChanged; 
	[SerializeField] 
	private Vector2 m_pivot; 
	[SerializeField] 
	private TextContainerAnchors m_anchorPosition; 
	[SerializeField] 
	private Rect m_rect; 
	private bool m_isDefaultWidth; 
	private bool m_isDefaultHeight; 
	private bool m_isAutoFitting; 
	private Vector3[] m_corners; 
	private Vector3[] m_worldCorners; 
	[SerializeField] 
	private Vector4 m_margins; 
	private RectTransform m_rectTransform; 
	private static Vector2 k_defaultSize; 
	private TextMeshPro m_textMeshPro; 

	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }


	public bool get_hasChanged() { }

	public void set_hasChanged(bool value) { }

	public Vector2 get_pivot() { }

	public void set_pivot(Vector2 value) { }

	public TextContainerAnchors get_anchorPosition() { }

	public void set_anchorPosition(TextContainerAnchors value) { }

	public Rect get_rect() { }

	public void set_rect(Rect value) { }

	public Vector2 get_size() { }

	public void set_size(Vector2 value) { }

	public float get_width() { }

	public void set_width(float value) { }

	public float get_height() { }

	public void set_height(float value) { }

	public bool get_isDefaultWidth() { }

	public bool get_isDefaultHeight() { }

	public bool get_isAutoFitting() { }

	public void set_isAutoFitting(bool value) { }

	public Vector3[] get_corners() { }

	public Vector3[] get_worldCorners() { }

	public Vector4 get_margins() { }

	public void set_margins(Vector4 value) { }

	public RectTransform get_rectTransform() { }

	public TextMeshPro get_textMeshPro() { }

	protected override void Awake() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	private void OnContainerChanged() { }

	protected override void OnRectTransformDimensionsChange() { }

	private void SetRect(Vector2 size) { }

	private void UpdateCorners() { }

	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	public void .ctor() { }

	private static void .cctor() { }

}

