public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 9939
{	// Fields
	public float Distance; // 0x80
	private RendererBatch meshBatch; // 0x88
	private Renderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private int curlod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x95C6D0 Offset: 0x95BAD0 VA: 0x18095C6D0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B3E30 Offset: 0x7B3230 VA: 0x1807B3E30 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x95C760 Offset: 0x95BB60 VA: 0x18095C760 Slot: 13
	protected override void Show() { }

	// RVA: 0x95C600 Offset: 0x95BA00 VA: 0x18095C600 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B42E0 Offset: 0x7B36E0 VA: 0x1807B42E0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x95C570 Offset: 0x95B970 VA: 0x18095C570 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x95C8F0 Offset: 0x95BCF0 VA: 0x18095C8F0
	public void .ctor() { }

}

