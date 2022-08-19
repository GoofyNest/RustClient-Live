public class FoliageDisplacement : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10674
{	// Fields
	public bool moving; // 0x18
	public bool billboard; // 0x19
	public Mesh mesh; // 0x20
	public Material material; // 0x28
	private bool visible; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x6E7EE0 Offset: 0x6E72E0 VA: 0x1806E7EE0
	protected void OnEnable() { }

	// RVA: 0x6E7E20 Offset: 0x6E7220 VA: 0x1806E7E20
	protected void OnDisable() { }

	// RVA: 0x6E7F60 Offset: 0x6E7360 VA: 0x1806E7F60 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6E7DE0 Offset: 0x6E71E0 VA: 0x1806E7DE0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6E7FE0 Offset: 0x6E73E0 VA: 0x1806E7FE0
	private void SetVisible(bool state) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

