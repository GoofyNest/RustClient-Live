public class Renderer : Component // TypeDefIndex: 3403
{	// Properties
	[ObsoleteAttribute] // RVA: 0x903D0 Offset: 0x8F7D0 VA: 0x1800903D0
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

	// Methods

	// RVA: 0x19AE450 Offset: 0x19AD850 VA: 0x1819AE450
	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F300 Offset: 0x8E700 VA: 0x18008F300
	// RVA: 0x19AE070 Offset: 0x19AD470 VA: 0x1819AE070
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F4A0 Offset: 0x8E8A0 VA: 0x18008F4A0
	// RVA: 0x19ADC90 Offset: 0x19AD090 VA: 0x1819ADC90
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F690 Offset: 0x8EA90 VA: 0x18008F690
	// RVA: 0x19ADD60 Offset: 0x19AD160 VA: 0x1819ADD60
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F740 Offset: 0x8EB40 VA: 0x18008F740
	// RVA: 0x19ADFD0 Offset: 0x19AD3D0 VA: 0x1819ADFD0
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	// RVA: 0x19ADC10 Offset: 0x19AD010 VA: 0x1819ADC10
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8F950 Offset: 0x8ED50 VA: 0x18008F950
	// RVA: 0x19ADBC0 Offset: 0x19ACFC0 VA: 0x1819ADBC0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8F9F0 Offset: 0x8EDF0 VA: 0x18008F9F0
	// RVA: 0x19ADF80 Offset: 0x19AD380 VA: 0x1819ADF80
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	// RVA: 0x19ADF30 Offset: 0x19AD330 VA: 0x1819ADF30
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FD70 Offset: 0x8F170 VA: 0x18008FD70
	// RVA: 0x19ADCD0 Offset: 0x19AD0D0 VA: 0x1819ADCD0
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x90040 Offset: 0x8F440 VA: 0x180090040
	// RVA: 0x19ADED0 Offset: 0x19AD2D0 VA: 0x1819ADED0
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x900B0 Offset: 0x8F4B0 VA: 0x1800900B0
	// RVA: 0x19ADE90 Offset: 0x19AD290 VA: 0x1819ADE90
	public bool HasPropertyBlock() { }

	// RVA: 0x19ADF30 Offset: 0x19AD330 VA: 0x1819ADF30
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19ADED0 Offset: 0x19AD2D0 VA: 0x1819ADED0
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x19ADCD0 Offset: 0x19AD0D0 VA: 0x1819ADCD0
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19AE0D0 Offset: 0x19AD4D0 VA: 0x1819AE0D0
	public bool get_enabled() { }

	// RVA: 0x19AE380 Offset: 0x19AD780 VA: 0x1819AE380
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x901A0 Offset: 0x8F5A0 VA: 0x1800901A0
	// RVA: 0x19AE110 Offset: 0x19AD510 VA: 0x1819AE110
	public bool get_isVisible() { }

	// RVA: 0x19AE2C0 Offset: 0x19AD6C0 VA: 0x1819AE2C0
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x19AE530 Offset: 0x19AD930 VA: 0x1819AE530
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x19AE280 Offset: 0x19AD680 VA: 0x1819AE280
	public bool get_receiveShadows() { }

	// RVA: 0x19AE4A0 Offset: 0x19AD8A0 VA: 0x1819AE4A0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x19AE240 Offset: 0x19AD640 VA: 0x1819AE240
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0x19AE410 Offset: 0x19AD810 VA: 0x1819AE410
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x19AE150 Offset: 0x19AD550 VA: 0x1819AE150
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x19AE3D0 Offset: 0x19AD7D0 VA: 0x1819AE3D0
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x19AE4F0 Offset: 0x19AD8F0 VA: 0x1819AE4F0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x19AE300 Offset: 0x19AD700 VA: 0x1819AE300
	public int get_sortingLayerID() { }

	// RVA: 0x19AE570 Offset: 0x19AD970 VA: 0x1819AE570
	public void set_sortingLayerID(int value) { }

	// RVA: 0x19AE340 Offset: 0x19AD740 VA: 0x1819AE340
	public int get_sortingOrder() { }

	// RVA: 0x19AE5B0 Offset: 0x19AD9B0 VA: 0x1819AE5B0
	public void set_sortingOrder(int value) { }

	// RVA: 0x19AE1E0 Offset: 0x19AD5E0 VA: 0x1819AE1E0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x19ADC50 Offset: 0x19AD050 VA: 0x1819ADC50
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x902B0 Offset: 0x8F6B0 VA: 0x1800902B0
	// RVA: 0x19ADD20 Offset: 0x19AD120 VA: 0x1819ADD20
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x19ADC10 Offset: 0x19AD010 VA: 0x1819ADC10
	public Material[] get_materials() { }

	// RVA: 0x19ADF80 Offset: 0x19AD380 VA: 0x1819ADF80
	public void set_materials(Material[] value) { }

	// RVA: 0x19ADC90 Offset: 0x19AD090 VA: 0x1819ADC90
	public Material get_material() { }

	// RVA: 0x19ADFD0 Offset: 0x19AD3D0 VA: 0x1819ADFD0
	public void set_material(Material value) { }

	// RVA: 0x19ADD60 Offset: 0x19AD160 VA: 0x1819ADD60
	public Material get_sharedMaterial() { }

	// RVA: 0x19ADFD0 Offset: 0x19AD3D0 VA: 0x1819ADFD0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x19ADD20 Offset: 0x19AD120 VA: 0x1819ADD20
	public Material[] get_sharedMaterials() { }

	// RVA: 0x19ADF80 Offset: 0x19AD380 VA: 0x1819ADF80
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x19ADDA0 Offset: 0x19AD1A0 VA: 0x1819ADDA0
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x19AE020 Offset: 0x19AD420 VA: 0x1819AE020
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19AE190 Offset: 0x19AD590 VA: 0x1819AE190
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

