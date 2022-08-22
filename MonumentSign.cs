public class MonumentSign : LODComponent // TypeDefIndex: 8808
{	public float viewDistance; // 0x80
	public GameObject uiRoot; // 0x88
	public RustText signText; // 0x90
	private MonumentInfo closestMonument; // 0x98
	private int currentLod; // 0xA0
	private bool force; // 0xA4


	private void UpdateText() { }

	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	private MonumentInfo FindClosestMonument() { }

	public void .ctor() { }

}

