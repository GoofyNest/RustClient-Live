public class LaserBeam : MonoBehaviour // TypeDefIndex: 10563
{
	public float scrollSpeed; 
	public LineRenderer beamRenderer; 
	public GameObject dotObject; 
	public Renderer dotRenderer; 
	public GameObject dotSpotlight; 
	public Vector2 scrollDir; 
	public float maxDistance; 
	public float stillBlendFactor; 
	public float movementBlendFactor; 
	public float movementThreshhold; 
	public bool isFirstPerson; 
	public Transform emissionOverride; 
	private MaterialPropertyBlock block; 
	public static LaserBeam.LaserBeamWorkQueue workQueue; 
	[ClientVar] 
	[HelpAttribute] 
	public static float framebudgetms; 
	[ClientVar] 
	public static bool debugCollisions; 
	private TimeSince lastUpdate; 
	private float cachedDotDistance; 
	private float aimToBarrelBlendFrac; 
	private Vector4 laserST; 


	[ClientVar] 
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

public class LaserBeam.LaserBeamWorkQueue : PersistentObjectWorkQueue<LaserBeam> // TypeDefIndex: 10564
{

	protected override void RunJob(LaserBeam entity) { }

	protected override bool ShouldAdd(LaserBeam entity) { }

	public void .ctor() { }

}

