public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 11661
{
	public float Distance; 
	private RendererBatch meshBatch; 
	private Renderer meshRenderer; 
	private MeshFilter meshFilter; 
	private int curlod; 
	private bool force; 


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

