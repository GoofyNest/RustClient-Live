public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 9939
{	public float Distance; // 0x80
	private RendererBatch meshBatch; // 0x88
	private Renderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private int curlod; // 0xA0
	private bool force; // 0xA4


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

