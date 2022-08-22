public class MeshPaintableSource : MonoBehaviour, IClientComponent // TypeDefIndex: 9206
{	public Vector4 uvRange; // 0x18
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


	public void Init() { }

	public void Free() { }

	public virtual void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	public virtual Color32[] UpdateFrom(Texture2D input) { }

	public void Load(byte[] data) { }

	public void Clear() { }

	public void .ctor() { }

	private static void .cctor() { }

}

