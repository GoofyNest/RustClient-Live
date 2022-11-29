public class MeshPaintController : MonoBehaviour, IClientComponent // TypeDefIndex: 10932
{
	public Camera pickerCamera; 
	public Texture2D brushTexture; 
	public Vector2 brushScale; 
	public Color brushColor; 
	public float brushSpacing; 
	public RawImage brushImage; 
	public float brushPreviewScaleMultiplier; 
	public bool applyDefaults; 
	public Texture2D defaltBrushTexture; 
	public float defaultBrushSize; 
	public Color defaultBrushColor; 
	public float defaultBrushAlpha; 
	public Toggle lastBrush; 
	public Button UndoButton; 
	public Button RedoButton; 
	private Vector3 lastPosition; 
	internal List<BaseMeshPaintable> dirtyPaintables; 
	internal bool drawingBlocked; 
	private ChangeSignText signTextPanel; 
	private BaseMeshPaintable paintingMesh; 
	private BaseMeshPaintable lastPaintedMesh; 


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

