public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 8196
{	protected bool supportImageEffects; // 0x18
	protected bool supportHDRTextures; // 0x19
	protected bool supportDepthTextures; // 0x1A
	protected bool supportDX11; // 0x1B
	private bool checkedSystemInfo; // 0x1C
	protected bool isSupported; // 0x1D
	private Camera camera; // 0x20

	public Camera Camera { get; }


	public Camera get_Camera() { }

	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	protected Material CreateMaterial(Shader s, Material m2Create) { }

	private void OnEnable() { }

	protected bool CheckSupport() { }

	public virtual bool CheckResources() { }

	protected void Start() { }

	protected bool CheckSupport(bool needDepth) { }

	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	public bool Dx11Support() { }

	protected void ReportAutoDisable() { }

	private bool CheckShader(Shader s) { }

	protected void NotSupported() { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	public void .ctor() { }

}

