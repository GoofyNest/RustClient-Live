public class WindZoneExManager : MonoBehaviour // TypeDefIndex: 10700
{	// Fields
	public float maxAccumMain; // 0x18
	public float maxAccumTurbulence; // 0x1C
	public float globalMainScale; // 0x20
	public float globalTurbulenceScale; // 0x24
	public Transform testPosition; // 0x28
	private const int MaxWindZones = 8;
	private const float MaxWindZoneDistanceToCamera = 1000;
	private const float MaxWindZoneSqrDistanceToCamera = 1000000;
	private static HashSet<WindZoneEx> registeredZones; // 0x0
	private static List<WindZoneExManager.CurrentZoneEntry> currentZones; // 0x8
	private static Vector4[] windZoneInfoArray; // 0x10
	private static Vector4[] windZoneParamArray; // 0x18
	private static WindZoneExManager instance; // 0x20

	// Properties
	public static WindZoneExManager Instance { get; }

	// Methods

	// RVA: 0x8A1330 Offset: 0x8A0730 VA: 0x1808A1330
	public static WindZoneExManager get_Instance() { }

	// RVA: 0x89FDA0 Offset: 0x89F1A0 VA: 0x18089FDA0
	public static void Clear() { }

	// RVA: 0x8A0D00 Offset: 0x8A0100 VA: 0x1808A0D00
	public static void Register(WindZoneEx zone) { }

	// RVA: 0x8A1090 Offset: 0x8A0490 VA: 0x1808A1090
	public static void Unregister(WindZoneEx zone) { }

	// RVA: 0x89FCC0 Offset: 0x89F0C0 VA: 0x18089FCC0
	private void Awake() { }

	// RVA: 0x8A1110 Offset: 0x8A0510 VA: 0x1808A1110
	private void Update() { }

	// RVA: 0x8A0710 Offset: 0x89FB10 VA: 0x1808A0710
	public void FindAndSortZones(Camera camera) { }

	// RVA: 0x8A0D80 Offset: 0x8A0180 VA: 0x1808A0D80
	public void SetShaderGlobals() { }

	// RVA: 0x8A02E0 Offset: 0x89F6E0 VA: 0x1808A02E0
	private static Vector4 ComputeWindForce(float time, Vector4 zoneInfo, Vector4 zoneParam, Vector3 center) { }

	// RVA: 0x89FE30 Offset: 0x89F230 VA: 0x18089FE30
	public static Vector4 ComputeWindForceAtLocation(Vector3 location) { }

	// RVA: 0x8A1300 Offset: 0x8A0700 VA: 0x1808A1300
	public void .ctor() { }

	// RVA: 0x8A1200 Offset: 0x8A0600 VA: 0x1808A1200
	private static void .cctor() { }

}

private enum WindZoneExManager.TestMode // TypeDefIndex: 10701
{	// Fields
	public int value__; // 0x0
	public const WindZoneExManager.TestMode Disabled = 0;
	public const WindZoneExManager.TestMode Low = 1;

}

private struct WindZoneExManager.CurrentZoneEntry // TypeDefIndex: 10702
{	// Fields
	public WindZoneEx zone; // 0x0
	public float distanceSqr; // 0x8

	// Methods

	// RVA: 0xF8FA0 Offset: 0xF83A0 VA: 0x1800F8FA0
	public void .ctor(WindZoneEx zone, float distance) { }

}

private sealed class WindZoneExManager.<>c // TypeDefIndex: 10703
{	// Fields
	public static readonly WindZoneExManager.<>c <>9; // 0x0
	public static Comparison<WindZoneExManager.CurrentZoneEntry> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x897C60 Offset: 0x897060 VA: 0x180897C60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x83A960 Offset: 0x839D60 VA: 0x18083A960
	internal int <FindAndSortZones>b__22_0(WindZoneExManager.CurrentZoneEntry x, WindZoneExManager.CurrentZoneEntry y) { }

}

