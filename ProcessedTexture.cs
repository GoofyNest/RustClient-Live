public class ProcessedTexture // TypeDefIndex: 13169
{
	protected RenderTexture result;
	protected Material material;


	public void Dispose() { }

	protected RenderTexture CreateRenderTexture(string name, int width, int height, bool linear) { }

	protected void DestroyRenderTexture(ref RenderTexture rt) { }

	protected RenderTexture CreateTemporary() { }

	protected void ReleaseTemporary(RenderTexture rt) { }

	protected Material CreateMaterial(string shader) { }

	protected Material CreateMaterial(Shader shader) { }

	protected void DestroyMaterial(ref Material mat) { }

	public static Texture op_Implicit(ProcessedTexture t) { }

	public void .ctor() { }

}

