public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{	public int iterations; // 0x18
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	protected Material material { get; }


	protected Material get_material() { }

	protected void OnDisable() { }

	protected void Start() { }

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

