internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 13514
{
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; 
	private int[] m_AutoExposurePingPong; 
	private RenderTexture m_CurrentAutoExposure; 


	public void .ctor() { }

	private void CheckTexture(int eye, int id) { }

	public override void Render(PostProcessRenderContext context) { }

	public override void Release() { }

}

