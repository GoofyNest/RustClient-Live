public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 8196
{	// Fields
	protected bool supportImageEffects; // 0x18
	protected bool supportHDRTextures; // 0x19
	protected bool supportDepthTextures; // 0x1A
	protected bool supportDX11; // 0x1B
	private bool checkedSystemInfo; // 0x1C
	protected bool isSupported; // 0x1D
	private Camera camera; // 0x20

	// Properties
	public Camera Camera { get; }

	// Methods

	// RVA: 0x21DED50 Offset: 0x21DE150 VA: 0x1821DED50
	public Camera get_Camera() { }

	// RVA: 0x21DE100 Offset: 0x21DD500 VA: 0x1821DE100
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21DEA80 Offset: 0x21DDE80 VA: 0x1821DEA80
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21DECA0 Offset: 0x21DE0A0 VA: 0x1821DECA0
	private void OnEnable() { }

	// RVA: 0x21DEA00 Offset: 0x21DDE00 VA: 0x1821DEA00
	protected bool CheckSupport() { }

	// RVA: 0x21DE070 Offset: 0x21DD470 VA: 0x1821DE070 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	protected void Start() { }

	// RVA: 0x21DE8B0 Offset: 0x21DDCB0 VA: 0x1821DE8B0
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x21DE850 Offset: 0x21DDC50 VA: 0x1821DE850
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x21DEC70 Offset: 0x21DE070 VA: 0x1821DEC70
	public bool Dx11Support() { }

	// RVA: 0x21DECB0 Offset: 0x21DE0B0 VA: 0x1821DECB0
	protected void ReportAutoDisable() { }

	// RVA: 0x21DE570 Offset: 0x21DD970 VA: 0x1821DE570
	private bool CheckShader(Shader s) { }

	// RVA: 0x21DEC80 Offset: 0x21DE080 VA: 0x1821DEC80
	protected void NotSupported() { }

	// RVA: 0x8C57F0 Offset: 0x8C4BF0 VA: 0x1808C57F0
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x21DED30 Offset: 0x21DE130 VA: 0x1821DED30
	public void .ctor() { }

}

