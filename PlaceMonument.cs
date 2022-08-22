public class PlaceMonument : ProceduralComponent // TypeDefIndex: 10534
{	public SpawnFilter Filter; // 0x28
	public GameObjectRef Monument; // 0x30
	private const int Attempts = 10000;


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private struct PlaceMonument.SpawnInfo // TypeDefIndex: 10535
{	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

