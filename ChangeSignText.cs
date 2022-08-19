public class ChangeSignText : UIDialog // TypeDefIndex: 10887
{	// Fields
	public Action<int, Texture2D> onUpdateTexture; // 0x30
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

	// Properties
	public MeshPaintableSource[] currentSources { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public MeshPaintableSource[] get_currentSources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_currentSources(MeshPaintableSource[] value) { }

	// RVA: 0x54EDE0 Offset: 0x54E1E0 VA: 0x18054EDE0
	public void Setup(MeshPaintableSource[] sources) { }

	// RVA: 0x54E3C0 Offset: 0x54D7C0 VA: 0x18054E3C0
	public void LoadImageIntoFrame(int frame, byte[] imageData) { }

	// RVA: 0x54DCA0 Offset: 0x54D0A0 VA: 0x18054DCA0
	private void DisableLODs(GameObject go) { }

	// RVA: 0x54F9C0 Offset: 0x54EDC0 VA: 0x18054F9C0
	public void UpdateSign() { }

	// RVA: 0x54E990 Offset: 0x54DD90 VA: 0x18054E990
	public void RegisterChange(BaseMeshPaintable paintable) { }

	// RVA: 0x54E890 Offset: 0x54DC90 VA: 0x18054E890
	public void ProcessUndo(BaseMeshPaintable paintable) { }

	// RVA: 0x54E690 Offset: 0x54DA90 VA: 0x18054E690
	public void ProcessRedo(BaseMeshPaintable paintable) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4BF560 Offset: 0x4BE960 VA: 0x1804BF560
	public void Cancel() { }

	// RVA: 0x54D8E0 Offset: 0x54CCE0 VA: 0x18054D8E0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x54EB90 Offset: 0x54DF90 VA: 0x18054EB90
	public void SelectFrame(int n) { }

	// RVA: 0x54D7E0 Offset: 0x54CBE0 VA: 0x18054D7E0
	public void ClearCurrentFrame() { }

	// RVA: 0x54DB30 Offset: 0x54CF30 VA: 0x18054DB30
	public void CopyPreviousFrame() { }

	// RVA: 0x54E2A0 Offset: 0x54D6A0 VA: 0x18054E2A0
	public bool IsUndoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x54E170 Offset: 0x54D570 VA: 0x18054E170
	public bool IsRedoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

private class ChangeSignText.UndoBuffer : IDisposable // TypeDefIndex: 10888
{	// Fields
	private List<Texture2D> buffer; // 0x10
	private Texture2D startFrame; // 0x18
	private int undoIndex; // 0x20
	private int undoSteps; // 0x24

	// Properties
	private int CurrentSlot { get; }
	public bool IsUndoAvailable { get; }
	public bool IsRedoAvailable { get; }

	// Methods

	// RVA: 0x560CE0 Offset: 0x5600E0 VA: 0x180560CE0
	public void Initialise(Texture2D forTexture, int bufferLength) { }

	// RVA: 0x5610C0 Offset: 0x5604C0 VA: 0x1805610C0
	public void RegisterChange(Texture2D forTexture) { }

	// RVA: 0x560F40 Offset: 0x560340 VA: 0x180560F40
	public void ProcessUndo(Texture2D targetTexture) { }

	// RVA: 0x560E10 Offset: 0x560210 VA: 0x180560E10
	public void ProcessRedo(Texture2D targetTexture) { }

	// RVA: 0x5611E0 Offset: 0x5605E0 VA: 0x1805611E0
	private int get_CurrentSlot() { }

	// RVA: 0x561290 Offset: 0x560690 VA: 0x180561290
	public bool get_IsUndoAvailable() { }

	// RVA: 0x561270 Offset: 0x560670 VA: 0x180561270
	public bool get_IsRedoAvailable() { }

	// RVA: 0x560BF0 Offset: 0x55FFF0 VA: 0x180560BF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

