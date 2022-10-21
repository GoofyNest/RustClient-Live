public class PlaceCliffs : ProceduralComponent // TypeDefIndex: 12259
{
	public SpawnFilter Filter; 
	public string ResourceFolder; 
	public int RetryMultiplier; 
	public int CutoffSlope; 
	public float MinScale; 
	public float MaxScale; 
	private static int target_count; 
	private static int target_length; 
	private static float min_scale_delta; 
	private static int max_scale_attempts; 
	private static int min_rotation; 
	private static int max_rotation; 
	private static int rotation_delta; 
	private static float offset_c; 
	private static float offset_l; 
	private static float offset_r; 
	private static Vector3[] offsets; 


	public override void Process(uint seed) { }

	private PlaceCliffs.CliffPlacement PlaceMale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	private PlaceCliffs.CliffPlacement PlaceFemale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	private PlaceCliffs.CliffPlacement Place<ParentSocketType, ChildSocketType>(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale, int parentAngle = 0, int parentCount = 0, int parentScore = 0) { }
	/* GenericInstMethod :
	|
	|-PlaceCliffs.Place<DecorSocketFemale, DecorSocketMale>
	|-PlaceCliffs.Place<DecorSocketMale, DecorSocketFemale>
	|-PlaceCliffs.Place<object, object>
	*/

	public void .ctor() { }

	private static void .cctor() { }

}

private class PlaceCliffs.CliffPlacement // TypeDefIndex: 12260
{
	public int count; 
	public int score; 
	public Prefab prefab; 
	public Vector3 pos; 
	public Quaternion rot; 
	public Vector3 scale; 
	public PlaceCliffs.CliffPlacement next; 


	public void .ctor() { }

}

private sealed class PlaceCliffs.<>c // TypeDefIndex: 12261
{
	public static readonly PlaceCliffs.<>c <>9; 
	public static Func<Prefab, bool> <>9__17_0; 
	public static Func<Prefab, bool> <>9__17_1; 
	public static Func<Prefab, bool> <>9__17_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Process>b__17_0(Prefab prefab) { }

	internal bool <Process>b__17_1(Prefab prefab) { }

	internal bool <Process>b__17_2(Prefab prefab) { }

}

