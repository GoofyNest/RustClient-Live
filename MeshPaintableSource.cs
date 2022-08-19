public class MeshPaintableSource : MonoBehaviour, IClientComponent // TypeDefIndex: 9206
{	// Fields
	public Vector4 uvRange; // 0x18
	public int texWidth; // 0x28
	public int texHeight; // 0x2C
	public string replacementTextureName; // 0x30
	public float cameraFOV; // 0x38
	public float cameraDistance; // 0x3C
	public Texture2D texture; // 0x40
	public GameObject sourceObject; // 0x48
	public Mesh collisionMesh; // 0x50
	public Vector3 localPosition; // 0x58
	public Vector3 localRotation; // 0x64
	public bool applyToAllRenderers; // 0x70
	public Renderer[] extraRenderers; // 0x78
	public bool paint3D; // 0x80
	public bool isSelected; // 0x81
	public Renderer legRenderer; // 0x88
	private static MaterialPropertyBlock block; // 0x0

	// Methods

	// RVA: 0x961BC0 Offset: 0x960FC0 VA: 0x180961BC0
	public void Init() { }

	// RVA: 0x961B10 Offset: 0x960F10 VA: 0x180961B10
	public void Free() { }

	// RVA: 0x962250 Offset: 0x961650 VA: 0x180962250 Slot: 4
	public virtual void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	// RVA: 0x9621E0 Offset: 0x9615E0 VA: 0x1809621E0 Slot: 5
	public virtual Color32[] UpdateFrom(Texture2D input) { }

	// RVA: 0x962180 Offset: 0x961580 VA: 0x180962180
	public void Load(byte[] data) { }

	// RVA: 0x961A00 Offset: 0x960E00 VA: 0x180961A00
	public void Clear() { }

	// RVA: 0x962280 Offset: 0x961680 VA: 0x180962280
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

