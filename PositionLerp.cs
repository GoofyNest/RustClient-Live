public class PositionLerp : IDisposable // TypeDefIndex: 9221
{	private static ListHashSet<PositionLerp> InstanceList; // 0x0
	public static bool DebugLog; // 0x8
	public static bool DebugDraw; // 0x9
	public static int TimeOffsetInterval; // 0xC
	public static float TimeOffset; // 0x10
	public const int TimeOffsetIntervalMin = 4;
	public const int TimeOffsetIntervalMax = 64;
	private bool enabled; // 0x10
	private Action idleDisable; // 0x18
	private Interpolator<TransformSnapshot> interpolator; // 0x20
	private IPosLerpTarget target; // 0x28
	private static TransformSnapshot snapshotPrototype; // 0x14
	private float timeOffset0; // 0x30
	private float timeOffset1; // 0x34
	private float timeOffset2; // 0x38
	private float timeOffset3; // 0x3C
	private int timeOffsetCount; // 0x40
	private float lastClientTime; // 0x44
	private float lastServerTime; // 0x48
	private float extrapolatedTime; // 0x4C
	private float enabledTime; // 0x50

	public bool Enabled { get; set; }
	public static float LerpTime { get; }


	public bool get_Enabled() { }

	public void set_Enabled(bool value) { }

	public static float get_LerpTime() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void Initialize(IPosLerpTarget target) { }

	public void Snapshot(Vector3 position, Quaternion rotation, float serverTime) { }

	public void Snapshot(Vector3 position, Quaternion rotation) { }

	public void SnapTo(Vector3 position, Quaternion rotation, float serverTime) { }

	public void SnapTo(Vector3 position, Quaternion rotation) { }

	public void SnapToEnd() { }

	public void Wipe() { }

	public static void WipeAll() { }

	protected void DoCycle() { }

	public void TransformEntries(Matrix4x4 matrix) { }

	public Quaternion GetEstimatedAngularVelocity() { }

	public Vector3 GetEstimatedVelocity() { }

	public void Dispose() { }

	public static void Clear() { }

	public static void Cycle() { }

	public void .ctor() { }

	private static void .cctor() { }

}

