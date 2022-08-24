public class WindZoneExManager : MonoBehaviour // TypeDefIndex: 10700
{
	public float maxAccumMain; 
	public float maxAccumTurbulence; 
	public float globalMainScale; 
	public float globalTurbulenceScale; 
	public Transform testPosition; 
	private const int MaxWindZones = 8;
	private const float MaxWindZoneDistanceToCamera = 1000;
	private const float MaxWindZoneSqrDistanceToCamera = 1000000;
	private static HashSet<WindZoneEx> registeredZones; 
	private static List<WindZoneExManager.CurrentZoneEntry> currentZones; 
	private static Vector4[] windZoneInfoArray; 
	private static Vector4[] windZoneParamArray; 
	private static WindZoneExManager instance; 

	public static WindZoneExManager Instance { get; }


	public static WindZoneExManager get_Instance() { }

	public static void Clear() { }

	public static void Register(WindZoneEx zone) { }

	public static void Unregister(WindZoneEx zone) { }

	private void Awake() { }

	private void Update() { }

	public void FindAndSortZones(Camera camera) { }

	public void SetShaderGlobals() { }

	private static Vector4 ComputeWindForce(float time, Vector4 zoneInfo, Vector4 zoneParam, Vector3 center) { }

	public static Vector4 ComputeWindForceAtLocation(Vector3 location) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private enum WindZoneExManager.TestMode // TypeDefIndex: 10701
{
	public int value__; 
	public const WindZoneExManager.TestMode Disabled = 0;
	public const WindZoneExManager.TestMode Low = 1;

}

private struct WindZoneExManager.CurrentZoneEntry // TypeDefIndex: 10702
{
	public WindZoneEx zone; 
	public float distanceSqr; 


	public void .ctor(WindZoneEx zone, float distance) { }

}

private sealed class WindZoneExManager.<>c // TypeDefIndex: 10703
{
	public static readonly WindZoneExManager.<>c <>9; 
	public static Comparison<WindZoneExManager.CurrentZoneEntry> <>9__22_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <FindAndSortZones>b__22_0(WindZoneExManager.CurrentZoneEntry x, WindZoneExManager.CurrentZoneEntry y) { }

}

