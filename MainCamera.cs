public class MainCamera : RustCamera<MainCamera> // TypeDefIndex: 9200
{	public static Camera mainCamera; // 0x0
	public static Transform mainCameraTransform; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <velocity>k__BackingField; // 0x10
	private static long[] MipStreamingBudget; // 0x20
	private double totalFrameTime; // 0x148
	private double lowestFrameTime; // 0x150
	private double highestFrameTime; // 0x158
	private int totalFrames; // 0x160
	private RealTimeSince timeSinceFrameSubmit; // 0x164
	private Stopwatch frameTime; // 0x168
	protected const float defaultSqrDistance = 1,677722E+07;

	public static bool isValid { get; }
	public static Vector3 velocity { get; set; }
	public static Vector3 position { get; set; }
	public static Vector3 forward { get; set; }
	public static Vector3 right { get; set; }
	public static Vector3 up { get; set; }
	public static Quaternion rotation { get; set; }
	public static Ray Ray { get; }
	public static RaycastHit Raycast { get; }


	public static bool get_isValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_velocity(Vector3 value) { }

	public static Vector3 get_position() { }

	public static void set_position(Vector3 value) { }

	public static Vector3 get_forward() { }

	public static void set_forward(Vector3 value) { }

	public static Vector3 get_right() { }

	public static void set_right(Vector3 value) { }

	public static Vector3 get_up() { }

	public static void set_up(Vector3 value) { }

	public static Quaternion get_rotation() { }

	public static void set_rotation(Quaternion value) { }

	public static Ray get_Ray() { }

	public static RaycastHit get_Raycast() { }

	public static EnvironmentType GetEnvironment() { }

	public static bool InEnvironment(EnvironmentType type) { }

	protected override void Awake() { }

	public void Setup() { }

	protected override void OnDestroy() { }

	private void AdjustTextureStreamingBudget() { }

	private void Update() { }

	public void RecordFrameTime() { }

	protected override void LateUpdate() { }

	public static float Distance(Vector3 pos) { }

	public static float SqrDistance(Vector3 pos) { }

	public static float Distance(BaseEntity ent) { }

	public static float SqrDistance(BaseEntity ent) { }

	public static float Distance2D(Vector3 pos) { }

	public static float SqrDistance2D(Vector3 pos) { }

	public static float Distance2D(BaseEntity ent) { }

	public static HitTest Trace(float maxDistance, BaseEntity IgnoreEntity, float radius = 0) { }

	public static bool IsInFrontOfLocalPlayerCamera(Vector3 point) { }

	public void .ctor() { }

	private static void .cctor() { }

}

