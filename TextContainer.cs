public class TextContainer : UIBehaviour // TypeDefIndex: 6869
{	// Fields
	private bool m_hasChanged; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_pivot; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextContainerAnchors m_anchorPosition; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Rect m_rect; // 0x28
	private bool m_isDefaultWidth; // 0x38
	private bool m_isDefaultHeight; // 0x39
	private bool m_isAutoFitting; // 0x3A
	private Vector3[] m_corners; // 0x40
	private Vector3[] m_worldCorners; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector4 m_margins; // 0x50
	private RectTransform m_rectTransform; // 0x60
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x68

	// Properties
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

	// Methods

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_hasChanged() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_hasChanged(bool value) { }

	// RVA: 0x115AFC0 Offset: 0x115A3C0 VA: 0x18115AFC0
	public Vector2 get_pivot() { }

	// RVA: 0x115B470 Offset: 0x115A870 VA: 0x18115B470
	public void set_pivot(Vector2 value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x115B190 Offset: 0x115A590 VA: 0x18115B190
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public Rect get_rect() { }

	// RVA: 0x115B530 Offset: 0x115A930 VA: 0x18115B530
	public void set_rect(Rect value) { }

	// RVA: 0x115B080 Offset: 0x115A480 VA: 0x18115B080
	public Vector2 get_size() { }

	// RVA: 0x115B590 Offset: 0x115A990 VA: 0x18115B590
	public void set_size(Vector2 value) { }

	// RVA: 0x115B180 Offset: 0x115A580 VA: 0x18115B180
	public float get_width() { }

	// RVA: 0x115B6C0 Offset: 0x115AAC0 VA: 0x18115B6C0
	public void set_width(float value) { }

	// RVA: 0x115AFA0 Offset: 0x115A3A0 VA: 0x18115AFA0
	public float get_height() { }

	// RVA: 0x115B2E0 Offset: 0x115A6E0 VA: 0x18115B2E0
	public void set_height(float value) { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_isDefaultWidth() { }

	// RVA: 0x8B1130 Offset: 0x8B0530 VA: 0x1808B1130
	public bool get_isDefaultHeight() { }

	// RVA: 0x115AFB0 Offset: 0x115A3B0 VA: 0x18115AFB0
	public bool get_isAutoFitting() { }

	// RVA: 0x115B3C0 Offset: 0x115A7C0 VA: 0x18115B3C0
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Vector3[] get_corners() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public Vector3[] get_worldCorners() { }

	// RVA: 0x1058C50 Offset: 0x1058050 VA: 0x181058C50
	public Vector4 get_margins() { }

	// RVA: 0x115B3D0 Offset: 0x115A7D0 VA: 0x18115B3D0
	public void set_margins(Vector4 value) { }

	// RVA: 0x115AFE0 Offset: 0x115A3E0 VA: 0x18115AFE0
	public RectTransform get_rectTransform() { }

	// RVA: 0x115B0E0 Offset: 0x115A4E0 VA: 0x18115B0E0
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x115A040 Offset: 0x1159440 VA: 0x18115A040 Slot: 4
	protected override void Awake() { }

	// RVA: 0x115A730 Offset: 0x1159B30 VA: 0x18115A730 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x115A550 Offset: 0x1159950 VA: 0x18115A550
	private void OnContainerChanged() { }

	// RVA: 0x115A740 Offset: 0x1159B40 VA: 0x18115A740 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x115AAF0 Offset: 0x1159EF0 VA: 0x18115AAF0
	private void SetRect(Vector2 size) { }

	// RVA: 0x115AB70 Offset: 0x1159F70 VA: 0x18115AB70
	private void UpdateCorners() { }

	// RVA: 0x115A430 Offset: 0x1159830 VA: 0x18115A430
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x115A0E0 Offset: 0x11594E0 VA: 0x18115A0E0
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x115AF20 Offset: 0x115A320 VA: 0x18115AF20
	public void .ctor() { }

	// RVA: 0x115AEB0 Offset: 0x115A2B0 VA: 0x18115AEB0
	private static void .cctor() { }

}

