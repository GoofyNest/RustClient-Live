public class PositionLerp : IDisposable // TypeDefIndex: 9221
{	// Fields
	private static ListHashSet<PositionLerp> InstanceList; // 0x0
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

	// Properties
	public bool Enabled { get; set; }
	public static float LerpTime { get; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_Enabled() { }

	// RVA: 0x97B410 Offset: 0x97A810 VA: 0x18097B410
	public void set_Enabled(bool value) { }

	// RVA: 0x97B370 Offset: 0x97A770 VA: 0x18097B370
	public static float get_LerpTime() { }

	// RVA: 0x979E70 Offset: 0x979270 VA: 0x180979E70
	private void OnEnable() { }

	// RVA: 0x979DF0 Offset: 0x9791F0 VA: 0x180979DF0
	private void OnDisable() { }

	// RVA: 0x979D50 Offset: 0x979150 VA: 0x180979D50
	public void Initialize(IPosLerpTarget target) { }

	// RVA: 0x97A570 Offset: 0x979970 VA: 0x18097A570
	public void Snapshot(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x97A4B0 Offset: 0x9798B0 VA: 0x18097A4B0
	public void Snapshot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x97A2C0 Offset: 0x9796C0 VA: 0x18097A2C0
	public void SnapTo(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x97A190 Offset: 0x979590 VA: 0x18097A190
	public void SnapTo(Vector3 position, Quaternion rotation) { }

	// RVA: 0x979F00 Offset: 0x979300 VA: 0x180979F00
	public void SnapToEnd() { }

	// RVA: 0x97B1A0 Offset: 0x97A5A0 VA: 0x18097B1A0
	public void Wipe() { }

	// RVA: 0x97B010 Offset: 0x97A410 VA: 0x18097B010
	public static void WipeAll() { }

	// RVA: 0x978EE0 Offset: 0x9782E0 VA: 0x180978EE0
	protected void DoCycle() { }

	// RVA: 0x97ADB0 Offset: 0x97A1B0 VA: 0x18097ADB0
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x9797D0 Offset: 0x978BD0 VA: 0x1809797D0
	public Quaternion GetEstimatedAngularVelocity() { }

	// RVA: 0x979AC0 Offset: 0x978EC0 VA: 0x180979AC0
	public Vector3 GetEstimatedVelocity() { }

	// RVA: 0x978DE0 Offset: 0x9781E0 VA: 0x180978DE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x978C90 Offset: 0x978090 VA: 0x180978C90
	public static void Clear() { }

	// RVA: 0x978D00 Offset: 0x978100 VA: 0x180978D00
	public static void Cycle() { }

	// RVA: 0x97B2E0 Offset: 0x97A6E0 VA: 0x18097B2E0
	public void .ctor() { }

	// RVA: 0x97B210 Offset: 0x97A610 VA: 0x18097B210
	private static void .cctor() { }

}

