public class MeshPaintController : MonoBehaviour, IClientComponent // TypeDefIndex: 9202
{	// Fields
	public Camera pickerCamera; // 0x18
	public Texture2D brushTexture; // 0x20
	public Vector2 brushScale; // 0x28
	public Color brushColor; // 0x30
	public float brushSpacing; // 0x40
	public RawImage brushImage; // 0x48
	public float brushPreviewScaleMultiplier; // 0x50
	public bool applyDefaults; // 0x54
	public Texture2D defaltBrushTexture; // 0x58
	public float defaultBrushSize; // 0x60
	public Color defaultBrushColor; // 0x64
	public float defaultBrushAlpha; // 0x74
	public Toggle lastBrush; // 0x78
	public Button UndoButton; // 0x80
	public Button RedoButton; // 0x88
	private Vector3 lastPosition; // 0x90
	internal List<BaseMeshPaintable> dirtyPaintables; // 0xA0
	internal bool drawingBlocked; // 0xA8
	private ChangeSignText signTextPanel; // 0xB0
	private BaseMeshPaintable paintingMesh; // 0xB8
	private BaseMeshPaintable lastPaintedMesh; // 0xC0

	// Methods

	// RVA: 0x95F030 Offset: 0x95E430 VA: 0x18095F030
	private void Awake() { }

	// RVA: 0x95FBB0 Offset: 0x95EFB0 VA: 0x18095FBB0
	private void Update() { }

	// RVA: 0x95F570 Offset: 0x95E970 VA: 0x18095F570
	private bool IsCopyPasteModifierHeld() { }

	// RVA: 0x95F260 Offset: 0x95E660 VA: 0x18095F260
	private void Draw(Vector3 pos) { }

	// RVA: 0x95EEE0 Offset: 0x95E2E0 VA: 0x18095EEE0
	private void ApplyPaintables() { }

	// RVA: 0x95F8B0 Offset: 0x95ECB0 VA: 0x18095F8B0
	public void UpdateBrushSize(float fNewSize) { }

	// RVA: 0x95F810 Offset: 0x95EC10 VA: 0x18095F810
	public void UpdateBrushAlpha(float fAlpha) { }

	// RVA: 0x95F850 Offset: 0x95EC50 VA: 0x18095F850
	public void UpdateBrushColor(Color color) { }

	// RVA: 0x95F9B0 Offset: 0x95EDB0 VA: 0x18095F9B0
	public void UpdateBrushTexture(Texture texture) { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	public void SetLastBrush(Toggle toggle) { }

	// RVA: 0x95F760 Offset: 0x95EB60 VA: 0x18095F760
	public void SwitchToLastBrushIfErasing() { }

	// RVA: 0x95F680 Offset: 0x95EA80 VA: 0x18095F680
	public void OnClickedUndo() { }

	// RVA: 0x95F5A0 Offset: 0x95E9A0 VA: 0x18095F5A0
	public void OnClickedRedo() { }

	// RVA: 0x95FA60 Offset: 0x95EE60 VA: 0x18095FA60
	private void UpdateUndoRedoButtons() { }

	// RVA: 0x95FA30 Offset: 0x95EE30 VA: 0x18095FA30
	public void UpdateLastPaintedMesh(BaseMeshPaintable paintable) { }

	// RVA: 0x9601D0 Offset: 0x95F5D0 VA: 0x1809601D0
	public void .ctor() { }

}

