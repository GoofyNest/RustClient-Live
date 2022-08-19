public class MainCamera : RustCamera<MainCamera> // TypeDefIndex: 9200
{	// Fields
	public static Camera mainCamera; // 0x0
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

	// Properties
	public static bool isValid { get; }
	public static Vector3 velocity { get; set; }
	public static Vector3 position { get; set; }
	public static Vector3 forward { get; set; }
	public static Vector3 right { get; set; }
	public static Vector3 up { get; set; }
	public static Quaternion rotation { get; set; }
	public static Ray Ray { get; }
	public static RaycastHit Raycast { get; }

	// Methods

	// RVA: 0x577E00 Offset: 0x577200 VA: 0x180577E00
	public static bool get_isValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x578110 Offset: 0x577510 VA: 0x180578110
	public static Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x578480 Offset: 0x577880 VA: 0x180578480
	private static void set_velocity(Vector3 value) { }

	// RVA: 0x577EE0 Offset: 0x5772E0 VA: 0x180577EE0
	public static Vector3 get_position() { }

	// RVA: 0x578220 Offset: 0x577620 VA: 0x180578220
	public static void set_position(Vector3 value) { }

	// RVA: 0x577D70 Offset: 0x577170 VA: 0x180577D70
	public static Vector3 get_forward() { }

	// RVA: 0x578180 Offset: 0x577580 VA: 0x180578180
	public static void set_forward(Vector3 value) { }

	// RVA: 0x577F70 Offset: 0x577370 VA: 0x180577F70
	public static Vector3 get_right() { }

	// RVA: 0x5782B0 Offset: 0x5776B0 VA: 0x1805782B0
	public static void set_right(Vector3 value) { }

	// RVA: 0x578080 Offset: 0x577480 VA: 0x180578080
	public static Vector3 get_up() { }

	// RVA: 0x5783D0 Offset: 0x5777D0 VA: 0x1805783D0
	public static void set_up(Vector3 value) { }

	// RVA: 0x578000 Offset: 0x577400 VA: 0x180578000
	public static Quaternion get_rotation() { }

	// RVA: 0x578350 Offset: 0x577750 VA: 0x180578350
	public static void set_rotation(Quaternion value) { }

	// RVA: 0x5779B0 Offset: 0x576DB0 VA: 0x1805779B0
	public static Ray get_Ray() { }

	// RVA: 0x577B30 Offset: 0x576F30 VA: 0x180577B30
	public static RaycastHit get_Raycast() { }

	// RVA: 0x5765A0 Offset: 0x5759A0 VA: 0x1805765A0
	public static EnvironmentType GetEnvironment() { }

	// RVA: 0x576680 Offset: 0x575A80 VA: 0x180576680
	public static bool InEnvironment(EnvironmentType type) { }

	// RVA: 0x575E00 Offset: 0x575200 VA: 0x180575E00 Slot: 6
	protected override void Awake() { }

	// RVA: 0x576FD0 Offset: 0x5763D0 VA: 0x180576FD0
	public void Setup() { }

	// RVA: 0x576B30 Offset: 0x575F30 VA: 0x180576B30 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x575C10 Offset: 0x575010 VA: 0x180575C10
	private void AdjustTextureStreamingBudget() { }

	// RVA: 0x5778D0 Offset: 0x576CD0 VA: 0x1805778D0
	private void Update() { }

	// RVA: 0x576C30 Offset: 0x576030 VA: 0x180576C30
	public void RecordFrameTime() { }

	// RVA: 0x576920 Offset: 0x575D20 VA: 0x180576920 Slot: 9
	protected override void LateUpdate() { }

	// RVA: 0x576210 Offset: 0x575610 VA: 0x180576210
	public static float Distance(Vector3 pos) { }

	// RVA: 0x577460 Offset: 0x576860 VA: 0x180577460
	public static float SqrDistance(Vector3 pos) { }

	// RVA: 0x5763B0 Offset: 0x5757B0 VA: 0x1805763B0
	public static float Distance(BaseEntity ent) { }

	// RVA: 0x577250 Offset: 0x576650 VA: 0x180577250
	public static float SqrDistance(BaseEntity ent) { }

	// RVA: 0x575EE0 Offset: 0x5752E0 VA: 0x180575EE0
	public static float Distance2D(Vector3 pos) { }

	// RVA: 0x577090 Offset: 0x576490 VA: 0x180577090
	public static float SqrDistance2D(Vector3 pos) { }

	// RVA: 0x576050 Offset: 0x575450 VA: 0x180576050
	public static float Distance2D(BaseEntity ent) { }

	// RVA: 0x577630 Offset: 0x576A30 VA: 0x180577630
	public static HitTest Trace(float maxDistance, BaseEntity IgnoreEntity, float radius = 0) { }

	// RVA: 0x576770 Offset: 0x575B70 VA: 0x180576770
	public static bool IsInFrontOfLocalPlayerCamera(Vector3 point) { }

	// RVA: 0x577950 Offset: 0x576D50 VA: 0x180577950
	public void .ctor() { }

	// RVA: 0x5778E0 Offset: 0x576CE0 VA: 0x1805778E0
	private static void .cctor() { }

}

