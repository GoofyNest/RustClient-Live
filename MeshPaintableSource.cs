public class MeshPaintableSource : MonoBehaviour, IClientComponent // TypeDefIndex: 9210
{
	public Vector4 uvRange; 
	public int texWidth; 
	public int texHeight; 
	public string replacementTextureName; 
	public float cameraFOV; 
	public float cameraDistance; 
	public Texture2D texture; 
	public GameObject sourceObject; 
	public Mesh collisionMesh; 
	public Vector3 localPosition; 
	public Vector3 localRotation; 
	public bool applyToAllRenderers; 
	public Renderer[] extraRenderers; 
	public bool paint3D; 
	public bool isSelected; 
	public Renderer legRenderer; 
	private static MaterialPropertyBlock block; 


	public void Init() { }

	public void Free() { }

	public virtual void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	public virtual Color32[] UpdateFrom(Texture2D input) { }

	public void Load(byte[] data) { }

	public void Clear() { }

	public void .ctor() { }

	private static void .cctor() { }

}

