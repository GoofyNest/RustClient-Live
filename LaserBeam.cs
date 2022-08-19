public class LaserBeam : MonoBehaviour // TypeDefIndex: 8891
{	// Fields
	public float scrollSpeed; // 0x18
	public LineRenderer beamRenderer; // 0x20
	public GameObject dotObject; // 0x28
	public Renderer dotRenderer; // 0x30
	public GameObject dotSpotlight; // 0x38
	public Vector2 scrollDir; // 0x40
	public float maxDistance; // 0x48
	public float stillBlendFactor; // 0x4C
	public float movementBlendFactor; // 0x50
	public float movementThreshhold; // 0x54
	public bool isFirstPerson; // 0x58
	public Transform emissionOverride; // 0x60
	private MaterialPropertyBlock block; // 0x68
	public static LaserBeam.LaserBeamWorkQueue workQueue; // 0x0
	[ClientVar] // RVA: 0xC1B30 Offset: 0xC0F30 VA: 0x1800C1B30
	[HelpAttribute] // RVA: 0xC1B30 Offset: 0xC0F30 VA: 0x1800C1B30
	public static float framebudgetms; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugCollisions; // 0xC
	private TimeSince lastUpdate; // 0x70
	private float cachedDotDistance; // 0x74
	private float aimToBarrelBlendFrac; // 0x78
	private Vector4 laserST; // 0x7C

	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6BDA40 Offset: 0x6BCE40 VA: 0x1806BDA40
	public static void PrintQueue(ConsoleSystem.Arg args) { }

	// RVA: 0x6BD660 Offset: 0x6BCA60 VA: 0x1806BD660
	public void LaserUpdate() { }

	// RVA: 0x6BD580 Offset: 0x6BC980 VA: 0x1806BD580
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x6BD3D0 Offset: 0x6BC7D0 VA: 0x1806BD3D0
	public Vector3 GetDotFinalPosition(Ray castRay) { }

	// RVA: 0x6BD150 Offset: 0x6BC550 VA: 0x1806BD150
	public Vector3 DotCast(Ray castRay) { }

	// RVA: 0x6BE2B0 Offset: 0x6BD6B0 VA: 0x1806BE2B0
	private void UpdateDot() { }

	// RVA: 0x6BD950 Offset: 0x6BCD50 VA: 0x1806BD950
	public void OnEnable() { }

	// RVA: 0x6BD8D0 Offset: 0x6BCCD0 VA: 0x1806BD8D0
	private void OnDisable() { }

	// RVA: 0x6BDED0 Offset: 0x6BD2D0 VA: 0x1806BDED0
	private void UpdateBeam() { }

	// RVA: 0x6BEFD0 Offset: 0x6BE3D0 VA: 0x1806BEFD0
	private void UpdateLaserPositions() { }

	// RVA: 0x6BD8A0 Offset: 0x6BCCA0 VA: 0x1806BD8A0
	public void LateUpdate() { }

	// RVA: 0x6BF090 Offset: 0x6BE490 VA: 0x1806BF090
	public void .ctor() { }

	// RVA: 0x6BEFF0 Offset: 0x6BE3F0 VA: 0x1806BEFF0
	private static void .cctor() { }

}

public class LaserBeam.LaserBeamWorkQueue : PersistentObjectWorkQueue<LaserBeam> // TypeDefIndex: 8892
{	// Methods

	// RVA: 0x6BD010 Offset: 0x6BC410 VA: 0x1806BD010 Slot: 5
	protected override void RunJob(LaserBeam entity) { }

	// RVA: 0x6BD070 Offset: 0x6BC470 VA: 0x1806BD070 Slot: 4
	protected override bool ShouldAdd(LaserBeam entity) { }

	// RVA: 0x6BD110 Offset: 0x6BC510 VA: 0x1806BD110
	public void .ctor() { }

}

