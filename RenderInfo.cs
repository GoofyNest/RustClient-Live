public static class RenderInfo // TypeDefIndex: 13774
{

	public static void GenerateReport() { }

}

public struct RenderInfo.RendererInstance // TypeDefIndex: 13775
{
	public bool IsVisible; 
	public bool CastShadows; 
	public bool Enabled; 
	public bool RecieveShadows; 
	public float Size; 
	public float Distance; 
	public int BoneCount; 
	public int MaterialCount; 
	public int VertexCount; 
	public int TriangleCount; 
	public int SubMeshCount; 
	public int BlendShapeCount; 
	public string RenderType; 
	public string MeshName; 
	public string ObjectName; 
	public string EntityName; 
	public uint EntityId; 
	public bool UpdateWhenOffscreen; 
	public int ParticleCount; 


	public static RenderInfo.RendererInstance From(Renderer renderer) { }

	public void ReadMesh(Mesh mesh) { }

}

