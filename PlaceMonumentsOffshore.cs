public class PlaceMonumentsOffshore : ProceduralComponent // TypeDefIndex: 10541
{	// Fields
	public string ResourceFolder; // 0x28
	public int TargetCount; // 0x30
	public int MinDistanceFromTerrain; // 0x34
	public int MaxDistanceFromTerrain; // 0x38
	public int DistanceBetweenMonuments; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0xDA180 Offset: 0xD9580 VA: 0x1800DA180
	public int MinWorldSize; // 0x40
	private const int Candidates = 10;
	private const int Attempts = 10000;

	// Methods

	// RVA: 0x8D5630 Offset: 0x8D4A30 VA: 0x1808D5630 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x8D5420 Offset: 0x8D4820 VA: 0x1808D5420
	private bool CheckRadius(List<PlaceMonumentsOffshore.SpawnInfo> spawns, Vector3 pos, float radius) { }

	// RVA: 0x8D6190 Offset: 0x8D5590 VA: 0x1808D6190
	public void .ctor() { }

}

private struct PlaceMonumentsOffshore.SpawnInfo // TypeDefIndex: 10542
{	// Fields
	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private sealed class PlaceMonumentsOffshore.<>c // TypeDefIndex: 10543
{	// Fields
	public static readonly PlaceMonumentsOffshore.<>c <>9; // 0x0
	public static Func<string, string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x8E4F60 Offset: 0x8E4360 VA: 0x1808E4F60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8E4D20 Offset: 0x8E4120 VA: 0x1808E4D20
	internal string <Process>b__9_0(string folder) { }

}

