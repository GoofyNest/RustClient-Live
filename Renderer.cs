public class Renderer : Component // TypeDefIndex: 3404
{
	[ObsoleteAttribute]
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

	[FreeFunctionAttribute]
	public Bounds get_bounds() { }

	[FreeFunctionAttribute]
	private Material GetMaterial() { }

	[FreeFunctionAttribute]
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute]
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute]
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute]
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute]
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute]
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	[FreeFunctionAttribute]
	public bool HasPropertyBlock() { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeNameAttribute]
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

	[NativeNameAttribute]
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

