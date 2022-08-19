public class RandomDynamicPrefab : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10354
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public string ResourceFolder; // 0x28
	private Prefab prefab; // 0x30
	private GameObject instance; // 0x38
	private LODCell cell; // 0x40

	// Methods

	// RVA: 0x6A6B30 Offset: 0x6A5F30 VA: 0x1806A6B30
	protected void OnEnable() { }

	// RVA: 0x6A6A80 Offset: 0x6A5E80 VA: 0x1806A6A80
	protected void OnDisable() { }

	// RVA: 0x6A6D70 Offset: 0x6A6170 VA: 0x1806A6D70 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A68E0 Offset: 0x6A5CE0 VA: 0x1806A68E0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A6DF0 Offset: 0x6A61F0 VA: 0x1806A6DF0
	public void .ctor() { }

}

