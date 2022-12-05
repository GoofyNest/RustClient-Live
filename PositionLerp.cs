public class PositionLerp : IDisposable // TypeDefIndex: 10958
{
	private static ListHashSet<PositionLerp> InstanceList;
	public static bool DebugLog;
	public static bool DebugDraw;
	public static int TimeOffsetInterval;
	public static float TimeOffset;
	public const int TimeOffsetIntervalMin = 4;
	public const int TimeOffsetIntervalMax = 64;
	private bool enabled;
	private Action idleDisable;
	private Interpolator<TransformSnapshot> interpolator;
	private IPosLerpTarget target;
	private static TransformSnapshot snapshotPrototype;
	private float timeOffset0;
	private float timeOffset1;
	private float timeOffset2;
	private float timeOffset3;
	private int timeOffsetCount;
	private float lastClientTime;
	private float lastServerTime;
	private float extrapolatedTime;
	private float enabledTime;

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

