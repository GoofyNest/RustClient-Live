public class SpecialPurposeCamera // TypeDefIndex: 10696
{	public bool dirty; // 0x10
	public string name; // 0x18
	public Camera camera; // 0x20
	public RenderTexture texture; // 0x28
	public CommandBuffer commands; // 0x30
	internal Vector3 position; // 0x38
	internal Quaternion rotation; // 0x44
	internal float orthographicSize; // 0x54
	internal float nearClipPlane; // 0x58
	internal float farClipPlane; // 0x5C
	internal bool created; // 0x60
	private ListHashSet<SpecialPurposeCamera.RenderEntry> dynamicEntries; // 0x68
	private InstancingContainer dynamicBuffer; // 0x70
	private ListHashSet<SpecialPurposeCamera.RenderEntry> staticEntries; // 0x78
	private InstancingContainer staticBuffer; // 0x80
	private CameraEvent cameraEvent; // 0x88
	private MaterialPropertyBlock block; // 0x90


	public void .ctor(string name) { }

	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	public void Destroy() { }

	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	private Matrix4x4 ViewMatrix() { }

	private Matrix4x4 ProjMatrix() { }

	public void Refresh() { }

}

private struct SpecialPurposeCamera.RenderEntry : IEquatable<SpecialPurposeCamera.RenderEntry> // TypeDefIndex: 10697
{	public Transform transform; // 0x0
	public Mesh mesh; // 0x8
	public Material material; // 0x10
	public bool billboard; // 0x18

	public Matrix4x4 matrix { get; }


	public void .ctor(Transform transform, Mesh mesh, Material material, bool billboard) { }

	public Matrix4x4 get_matrix() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(SpecialPurposeCamera.RenderEntry other) { }

	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

