public class SpecialPurposeCamera // TypeDefIndex: 12427
{
	public bool dirty; 
	public string name; 
	public Camera camera; 
	public RenderTexture texture; 
	public CommandBuffer commands; 
	internal Vector3 position; 
	internal Quaternion rotation; 
	internal float orthographicSize; 
	internal float nearClipPlane; 
	internal float farClipPlane; 
	internal bool created; 
	private ListHashSet<SpecialPurposeCamera.RenderEntry> dynamicEntries; 
	private InstancingContainer dynamicBuffer; 
	private ListHashSet<SpecialPurposeCamera.RenderEntry> staticEntries; 
	private InstancingContainer staticBuffer; 
	private CameraEvent cameraEvent; 
	private MaterialPropertyBlock block; 


	public void .ctor(string name) { }

	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	public void Destroy() { }

	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	private Matrix4x4 ViewMatrix() { }

	private Matrix4x4 ProjMatrix() { }

	public void Refresh() { }

}

private struct SpecialPurposeCamera.RenderEntry : IEquatable<SpecialPurposeCamera.RenderEntry> // TypeDefIndex: 12428
{
	public Transform transform; 
	public Mesh mesh; 
	public Material material; 
	public bool billboard; 

	public Matrix4x4 matrix { get; }


	public void .ctor(Transform transform, Mesh mesh, Material material, bool billboard) { }

	public Matrix4x4 get_matrix() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(SpecialPurposeCamera.RenderEntry other) { }

	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

