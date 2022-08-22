public class PlaceCliffs : ProceduralComponent // TypeDefIndex: 10528
{	public SpawnFilter Filter; // 0x28
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


	public override void Process(uint seed) { }

	private PlaceCliffs.CliffPlacement PlaceMale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	private PlaceCliffs.CliffPlacement PlaceFemale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	private PlaceCliffs.CliffPlacement Place<ParentSocketType, ChildSocketType>(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale, int parentAngle = 0, int parentCount = 0, int parentScore = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12580E0 Offset: 0x12574E0 VA: 0x1812580E0
	|-PlaceCliffs.Place<DecorSocketFemale, DecorSocketMale>
	|-PlaceCliffs.Place<DecorSocketMale, DecorSocketFemale>
	|-PlaceCliffs.Place<object, object>
	*/

	public void .ctor() { }

	private static void .cctor() { }

}

private class PlaceCliffs.CliffPlacement // TypeDefIndex: 10529
{	public int count; // 0x10
	public int score; // 0x14
	public Prefab prefab; // 0x18
	public Vector3 pos; // 0x20
	public Quaternion rot; // 0x2C
	public Vector3 scale; // 0x3C
	public PlaceCliffs.CliffPlacement next; // 0x48


	public void .ctor() { }

}

private sealed class PlaceCliffs.<>c // TypeDefIndex: 10530
{	public static readonly PlaceCliffs.<>c <>9; // 0x0
	public static Func<Prefab, bool> <>9__17_0; // 0x8
	public static Func<Prefab, bool> <>9__17_1; // 0x10
	public static Func<Prefab, bool> <>9__17_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Process>b__17_0(Prefab prefab) { }

	internal bool <Process>b__17_1(Prefab prefab) { }

	internal bool <Process>b__17_2(Prefab prefab) { }

}

