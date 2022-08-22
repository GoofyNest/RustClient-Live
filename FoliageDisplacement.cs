public class FoliageDisplacement : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10674
{	public bool moving; // 0x18
	public bool billboard; // 0x19
	public Mesh mesh; // 0x20
	public Material material; // 0x28
	private bool visible; // 0x30
	private LODCell cell; // 0x38


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	private void SetVisible(bool state) { }

	public void .ctor() { }

}

