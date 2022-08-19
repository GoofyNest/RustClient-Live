public class DeferredDecal : MonoBehaviour // TypeDefIndex: 10648
{	// Fields
	public Mesh mesh; // 0x18
	public Material material; // 0x20
	public DeferredDecalQueue queue; // 0x28
	public bool applyImmediately; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDecalEnabled>k__BackingField; // 0x2D
	private bool cached; // 0x2E
	private Matrix4x4 localToWorldMatrix; // 0x30

	// Properties
	public bool IsDecalEnabled { get; set; }
	public Matrix4x4 matrix { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8ED840 Offset: 0x8ECC40 VA: 0x1808ED840
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8ED970 Offset: 0x8ECD70 VA: 0x1808ED970
	private void set_IsDecalEnabled(bool value) { }

	// RVA: 0x8ED850 Offset: 0x8ECC50 VA: 0x1808ED850
	public Matrix4x4 get_matrix() { }

	// RVA: 0x8ED7C0 Offset: 0x8ECBC0 VA: 0x1808ED7C0
	protected void OnEnable() { }

	// RVA: 0x8ED700 Offset: 0x8ECB00 VA: 0x1808ED700
	protected void OnDisable() { }

	// RVA: 0x8ED700 Offset: 0x8ECB00 VA: 0x1808ED700
	public void DisableDecal() { }

	// RVA: 0x8ED760 Offset: 0x8ECB60 VA: 0x1808ED760
	public void EnableDecal() { }

	// RVA: 0x8ED830 Offset: 0x8ECC30 VA: 0x1808ED830
	public void .ctor() { }

}

