public class PlaceMonument : ProceduralComponent // TypeDefIndex: 10534
{	// Fields
	public SpawnFilter Filter; // 0x28
	public GameObjectRef Monument; // 0x30
	private const int Attempts = 10000;

	// Methods

	// RVA: 0x8D4D00 Offset: 0x8D4100 VA: 0x1808D4D00 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

private struct PlaceMonument.SpawnInfo // TypeDefIndex: 10535
{	// Fields
	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

