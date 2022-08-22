public class Renderer : Component // TypeDefIndex: 3403
{	[ObsoleteAttribute] // RVA: 0x903D0 Offset: 0x8F7D0 VA: 0x1800903D0
	public bool motionVectors { set; }
	public Bounds bounds { get; }
	public bool enabled { get; set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public bool receiveShadows { get; set; }
	public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
	public LightProbeUsage lightProbeUsage { get; set; }
	public ReflectionProbeUsage reflectionProbeUsage { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }


	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F300 Offset: 0x8E700 VA: 0x18008F300
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F4A0 Offset: 0x8E8A0 VA: 0x18008F4A0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F690 Offset: 0x8EA90 VA: 0x18008F690
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F740 Offset: 0x8EB40 VA: 0x18008F740
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8F950 Offset: 0x8ED50 VA: 0x18008F950
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8F9F0 Offset: 0x8EDF0 VA: 0x18008F9F0
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FD70 Offset: 0x8F170 VA: 0x18008FD70
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x90040 Offset: 0x8F440 VA: 0x180090040
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x900B0 Offset: 0x8F4B0 VA: 0x1800900B0
	public bool HasPropertyBlock() { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x901A0 Offset: 0x8F5A0 VA: 0x1800901A0
	public bool get_isVisible() { }

	public ShadowCastingMode get_shadowCastingMode() { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public bool get_receiveShadows() { }

	public void set_receiveShadows(bool value) { }

	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	public LightProbeUsage get_lightProbeUsage() { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x902B0 Offset: 0x8F6B0 VA: 0x1800902B0
	private Material[] GetSharedMaterialArray() { }

	public Material[] get_materials() { }

	public void set_materials(Material[] value) { }

	public Material get_material() { }

	public void set_material(Material value) { }

	public Material get_sharedMaterial() { }

	public void set_sharedMaterial(Material value) { }

	public Material[] get_sharedMaterials() { }

	public void set_sharedMaterials(Material[] value) { }

	public void GetSharedMaterials(List<Material> m) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

