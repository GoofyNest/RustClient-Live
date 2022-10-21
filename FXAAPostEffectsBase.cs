public class FXAAPostEffectsBase : MonoBehaviour // TypeDefIndex: 13239
{
	protected bool supportHDRTextures; 
	protected bool isSupported; 


	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	private Material CreateMaterial(Shader s, Material m2Create) { }

	private void OnEnable() { }

	private bool CheckSupport() { }

	private bool CheckResources() { }

	private void Start() { }

	public bool CheckSupport(bool needDepth) { }

	private bool CheckSupport(bool needDepth, bool needHdr) { }

	private void ReportAutoDisable() { }

	private bool CheckShader(Shader s) { }

	private void NotSupported() { }

	private void DrawBorder(RenderTexture dest, Material material) { }

	public void .ctor() { }

}

