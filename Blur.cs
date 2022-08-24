public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{
	public int iterations; 
	public float blurSpread; 
	public Shader blurShader; 
	private static Material m_Material; 

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

