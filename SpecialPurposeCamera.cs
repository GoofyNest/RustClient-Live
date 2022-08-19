public class SpecialPurposeCamera // TypeDefIndex: 10696
{	// Fields
	public bool dirty; // 0x10
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

	// Methods

	// RVA: 0xA7A400 Offset: 0xA79800 VA: 0x180A7A400
	public void .ctor(string name) { }

	// RVA: 0xA79670 Offset: 0xA78A70 VA: 0x180A79670
	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0xA797D0 Offset: 0xA78BD0 VA: 0x180A797D0
	public void Destroy() { }

	// RVA: 0xA79520 Offset: 0xA78920 VA: 0x180A79520
	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA79ED0 Offset: 0xA792D0 VA: 0x180A79ED0
	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7A020 Offset: 0xA79420 VA: 0x180A7A020
	private Matrix4x4 ViewMatrix() { }

	// RVA: 0xA79900 Offset: 0xA78D00 VA: 0x180A79900
	private Matrix4x4 ProjMatrix() { }

	// RVA: 0xA799F0 Offset: 0xA78DF0 VA: 0x180A799F0
	public void Refresh() { }

}

private struct SpecialPurposeCamera.RenderEntry : IEquatable<SpecialPurposeCamera.RenderEntry> // TypeDefIndex: 10697
{	// Fields
	public Transform transform; // 0x0
	public Mesh mesh; // 0x8
	public Material material; // 0x10
	public bool billboard; // 0x18

	// Properties
	public Matrix4x4 matrix { get; }

	// Methods

	// RVA: 0xFC1F0 Offset: 0xFB5F0 VA: 0x1800FC1F0
	public void .ctor(Transform transform, Mesh mesh, Material material, bool billboard) { }

	// RVA: 0xFC250 Offset: 0xFB650 VA: 0x1800FC250
	public Matrix4x4 get_matrix() { }

	// RVA: 0xF2E70 Offset: 0xF2270 VA: 0x1800F2E70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFC150 Offset: 0xFB550 VA: 0x1800FC150 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFC120 Offset: 0xFB520 VA: 0x1800FC120 Slot: 4
	public bool Equals(SpecialPurposeCamera.RenderEntry other) { }

	// RVA: 0xA6FF20 Offset: 0xA6F320 VA: 0x180A6FF20
	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	// RVA: 0xA6FF50 Offset: 0xA6F350 VA: 0x180A6FF50
	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

