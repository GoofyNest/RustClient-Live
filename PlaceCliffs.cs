public class PlaceCliffs : ProceduralComponent // TypeDefIndex: 10528
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int RetryMultiplier; // 0x38
	public int CutoffSlope; // 0x3C
	public float MinScale; // 0x40
	public float MaxScale; // 0x44
	private static int target_count; // 0x0
	private static int target_length; // 0x4
	private static float min_scale_delta; // 0x8
	private static int max_scale_attempts; // 0xC
	private static int min_rotation; // 0x10
	private static int max_rotation; // 0x14
	private static int rotation_delta; // 0x18
	private static float offset_c; // 0x1C
	private static float offset_l; // 0x20
	private static float offset_r; // 0x24
	private static Vector3[] offsets; // 0x28

	// Methods

	// RVA: 0x8D2700 Offset: 0x8D1B00 VA: 0x1808D2700 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x8D2610 Offset: 0x8D1A10 VA: 0x1808D2610
	private PlaceCliffs.CliffPlacement PlaceMale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	// RVA: 0x8D2520 Offset: 0x8D1920 VA: 0x1808D2520
	private PlaceCliffs.CliffPlacement PlaceFemale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	// RVA: -1 Offset: -1
	private PlaceCliffs.CliffPlacement Place<ParentSocketType, ChildSocketType>(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale, int parentAngle = 0, int parentCount = 0, int parentScore = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12580E0 Offset: 0x12574E0 VA: 0x1812580E0
	|-PlaceCliffs.Place<DecorSocketFemale, DecorSocketMale>
	|-PlaceCliffs.Place<DecorSocketMale, DecorSocketFemale>
	|-PlaceCliffs.Place<object, object>
	*/

	// RVA: 0x8D3720 Offset: 0x8D2B20 VA: 0x1808D3720
	public void .ctor() { }

	// RVA: 0x8D3400 Offset: 0x8D2800 VA: 0x1808D3400
	private static void .cctor() { }

}

private class PlaceCliffs.CliffPlacement // TypeDefIndex: 10529
{	// Fields
	public int count; // 0x10
	public int score; // 0x14
	public Prefab prefab; // 0x18
	public Vector3 pos; // 0x20
	public Quaternion rot; // 0x2C
	public Vector3 scale; // 0x3C
	public PlaceCliffs.CliffPlacement next; // 0x48

	// Methods

	// RVA: 0x8C9B70 Offset: 0x8C8F70 VA: 0x1808C9B70
	public void .ctor() { }

}

private sealed class PlaceCliffs.<>c // TypeDefIndex: 10530
{	// Fields
	public static readonly PlaceCliffs.<>c <>9; // 0x0
	public static Func<Prefab, bool> <>9__17_0; // 0x8
	public static Func<Prefab, bool> <>9__17_1; // 0x10
	public static Func<Prefab, bool> <>9__17_2; // 0x18

	// Methods

	// RVA: 0x8E4FC0 Offset: 0x8E43C0 VA: 0x1808E4FC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8E4AF0 Offset: 0x8E3EF0 VA: 0x1808E4AF0
	internal bool <Process>b__17_0(Prefab prefab) { }

	// RVA: 0x8E4C20 Offset: 0x8E4020 VA: 0x1808E4C20
	internal bool <Process>b__17_1(Prefab prefab) { }

	// RVA: 0x8E4CA0 Offset: 0x8E40A0 VA: 0x1808E4CA0
	internal bool <Process>b__17_2(Prefab prefab) { }

}

