public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 8197
{
	protected bool supportImageEffects; 
	protected bool supportHDRTextures; 
	protected bool supportDepthTextures; 
	protected bool supportDX11; 
	private bool checkedSystemInfo; 
	protected bool isSupported; 
	private Camera camera; 

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

