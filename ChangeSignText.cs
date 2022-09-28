public class ChangeSignText : UIDialog // TypeDefIndex: 12566
{
	public Action<int, Texture2D> onUpdateTexture; 
	public GameObject objectContainer; 
	public GameObject currentFrameSection; 
	public GameObject[] frameOptions; 
	public Camera cameraPreview; 
	public Camera camera3D; 
	[CompilerGeneratedAttribute] 
	private MeshPaintableSource[] <currentSources>k__BackingField; 
	private List<GameObject> copiedObjects; 
	private int currentFrame; 
	private Dictionary<BaseMeshPaintable, ChangeSignText.UndoBuffer> undoBuffer; 
	private static string savedContainerName; 
	private static Vector3 savedContainerEuler; 

	public MeshPaintableSource[] currentSources { get; set; }


	[CompilerGeneratedAttribute] 
	public MeshPaintableSource[] get_currentSources() { }

	[CompilerGeneratedAttribute] 
	public void set_currentSources(MeshPaintableSource[] value) { }

	public void Setup(MeshPaintableSource[] sources) { }

	public void LoadImageIntoFrame(int frame, byte[] imageData) { }

	private void DisableLODs(GameObject go) { }

	public void UpdateSign() { }

	public void RegisterChange(BaseMeshPaintable paintable) { }

	public void ProcessUndo(BaseMeshPaintable paintable) { }

	public void ProcessRedo(BaseMeshPaintable paintable) { }

	public override void OpenDialog() { }

	public void Cancel() { }

	public override void CloseDialog() { }

	public void SelectFrame(int n) { }

	public void ClearCurrentFrame() { }

	public void CopyPreviousFrame() { }

	public bool IsUndoAvailable(BaseMeshPaintable paintable) { }

	public bool IsRedoAvailable(BaseMeshPaintable paintable) { }

	public void .ctor() { }

}

private class ChangeSignText.UndoBuffer : IDisposable // TypeDefIndex: 12567
{
	private List<Texture2D> buffer; 
	private Texture2D startFrame; 
	private int undoIndex; 
	private int undoSteps; 

	private int CurrentSlot { get; }
	public bool IsUndoAvailable { get; }
	public bool IsRedoAvailable { get; }


	public void Initialise(Texture2D forTexture, int bufferLength) { }

	public void RegisterChange(Texture2D forTexture) { }

	public void ProcessUndo(Texture2D targetTexture) { }

	public void ProcessRedo(Texture2D targetTexture) { }

	private int get_CurrentSlot() { }

	public bool get_IsUndoAvailable() { }

	public bool get_IsRedoAvailable() { }

	public void Dispose() { }

	public void .ctor() { }

}

