public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10353
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public GameObject[] Candidates; // 0x28
	private GameObject instance; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x6A64B0 Offset: 0x6A58B0 VA: 0x1806A64B0
	protected void OnEnable() { }

	// RVA: 0x6A6400 Offset: 0x6A5800 VA: 0x1806A6400
	protected void OnDisable() { }

	// RVA: 0x6A6840 Offset: 0x6A5C40 VA: 0x1806A6840 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A6390 Offset: 0x6A5790 VA: 0x1806A6390 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A68C0 Offset: 0x6A5CC0 VA: 0x1806A68C0
	public void .ctor() { }

}

