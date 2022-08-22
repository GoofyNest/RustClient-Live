public class MeshPaintController : MonoBehaviour, IClientComponent // TypeDefIndex: 9202
{	public Camera pickerCamera; // 0x18
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


	private void Awake() { }

	private void Update() { }

	private bool IsCopyPasteModifierHeld() { }

	private void Draw(Vector3 pos) { }

	private void ApplyPaintables() { }

	public void UpdateBrushSize(float fNewSize) { }

	public void UpdateBrushAlpha(float fAlpha) { }

	public void UpdateBrushColor(Color color) { }

	public void UpdateBrushTexture(Texture texture) { }

	public void SetLastBrush(Toggle toggle) { }

	public void SwitchToLastBrushIfErasing() { }

	public void OnClickedUndo() { }

	public void OnClickedRedo() { }

	private void UpdateUndoRedoButtons() { }

	public void UpdateLastPaintedMesh(BaseMeshPaintable paintable) { }

	public void .ctor() { }

}

