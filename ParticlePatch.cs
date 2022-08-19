public class ParticlePatch // TypeDefIndex: 10357
{	// Fields
	private bool initialized; // 0x10
	private float LOD; // 0x14
	private float shift; // 0x18
	private float extent; // 0x1C
	private Vector3 offset; // 0x20
	private Vector3 position; // 0x2C
	private bool didHit; // 0x38
	private float hitRefreshTime; // 0x3C
	private RaycastHit raycastHit; // 0x40
	private ParticleSpawn particleSpawn; // 0x70
	private List<GameObject> spawns; // 0x78

	// Methods

	// RVA: 0x939340 Offset: 0x938740 VA: 0x180939340
	public void DestroyInstances() { }

	// RVA: 0x939110 Offset: 0x938510 VA: 0x180939110
	public void CreateInstances() { }

	// RVA: 0x939A80 Offset: 0x938E80 VA: 0x180939A80
	public void UpdateInstances() { }

	// RVA: 0x939BC0 Offset: 0x938FC0 VA: 0x180939BC0
	public void .ctor(ParticleSpawn particleSpawn, int i, int j) { }

	// RVA: 0x939470 Offset: 0x938870 VA: 0x180939470
	public bool Shift() { }

	// RVA: 0x939A20 Offset: 0x938E20 VA: 0x180939A20
	public void Spawn() { }

}

