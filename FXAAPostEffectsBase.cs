public class FXAAPostEffectsBase : MonoBehaviour // TypeDefIndex: 11485
{	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool isSupported; // 0x19

	// Methods

	// RVA: 0x8C4D10 Offset: 0x8C4110 VA: 0x1808C4D10
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8C5600 Offset: 0x8C4A00 VA: 0x1808C5600
	private Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8C5BB0 Offset: 0x8C4FB0 VA: 0x1808C5BB0
	private void OnEnable() { }

	// RVA: 0x8C5530 Offset: 0x8C4930 VA: 0x1808C5530
	private bool CheckSupport() { }

	// RVA: 0x8C4C80 Offset: 0x8C4080 VA: 0x1808C4C80
	private bool CheckResources() { }

	// RVA: 0x8C5C40 Offset: 0x8C5040 VA: 0x1808C5C40
	private void Start() { }

	// RVA: 0x8C5460 Offset: 0x8C4860 VA: 0x1808C5460
	public bool CheckSupport(bool needDepth) { }

	// RVA: 0x8C55A0 Offset: 0x8C49A0 VA: 0x1808C55A0
	private bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x8C5BC0 Offset: 0x8C4FC0 VA: 0x1808C5BC0
	private void ReportAutoDisable() { }

	// RVA: 0x8C5180 Offset: 0x8C4580 VA: 0x1808C5180
	private bool CheckShader(Shader s) { }

	// RVA: 0x8C5B90 Offset: 0x8C4F90 VA: 0x1808C5B90
	private void NotSupported() { }

	// RVA: 0x8C57F0 Offset: 0x8C4BF0 VA: 0x1808C57F0
	private void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x8C5CC0 Offset: 0x8C50C0 VA: 0x1808C5CC0
	public void .ctor() { }

}

