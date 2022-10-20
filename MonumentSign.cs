public class MonumentSign : LODComponent // TypeDefIndex: 10518
{
	public float viewDistance; 
	public GameObject uiRoot; 
	public RustText signText; 
	private MonumentInfo closestMonument; 
	private int currentLod; 
	private bool force; 


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

