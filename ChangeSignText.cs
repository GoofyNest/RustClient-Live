public class ChangeSignText : UIDialog // TypeDefIndex: 10887
{	public Action<int, Texture2D> onUpdateTexture; // 0x30
	public GameObject objectContainer; // 0x38
	public GameObject currentFrameSection; // 0x40
	public GameObject[] frameOptions; // 0x48
	public Camera cameraPreview; // 0x50
	public Camera camera3D; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshPaintableSource[] <currentSources>k__BackingField; // 0x60
	private List<GameObject> copiedObjects; // 0x68
	private int currentFrame; // 0x70
	private Dictionary<BaseMeshPaintable, ChangeSignText.UndoBuffer> undoBuffer; // 0x78
	private static string savedContainerName; // 0x0
	private static Vector3 savedContainerEuler; // 0x8

	public MeshPaintableSource[] currentSources { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MeshPaintableSource[] get_currentSources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private class ChangeSignText.UndoBuffer : IDisposable // TypeDefIndex: 10888
{	private List<Texture2D> buffer; // 0x10
	private Texture2D startFrame; // 0x18
	private int undoIndex; // 0x20
	private int undoSteps; // 0x24

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

