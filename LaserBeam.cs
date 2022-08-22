public class LaserBeam : MonoBehaviour // TypeDefIndex: 8891
{	public float scrollSpeed; // 0x18
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


	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void PrintQueue(ConsoleSystem.Arg args) { }

	public void LaserUpdate() { }

	public BaseProjectile GetLocalPlayerWeapon() { }

	public Vector3 GetDotFinalPosition(Ray castRay) { }

	public Vector3 DotCast(Ray castRay) { }

	private void UpdateDot() { }

	public void OnEnable() { }

	private void OnDisable() { }

	private void UpdateBeam() { }

	private void UpdateLaserPositions() { }

	public void LateUpdate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class LaserBeam.LaserBeamWorkQueue : PersistentObjectWorkQueue<LaserBeam> // TypeDefIndex: 8892
{
	protected override void RunJob(LaserBeam entity) { }

	protected override bool ShouldAdd(LaserBeam entity) { }

	public void .ctor() { }

}

