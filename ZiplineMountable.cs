public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E57B50 Offset: 0x1E56F50 VA: 0x181E57B50
	public static void ResetToPool(ZiplineMountable instance) { }

	// RVA: 0x1E57A70 Offset: 0x1E56E70 VA: 0x181E57A70
	public void ResetToPool() { }

	// RVA: 0x1E578E0 Offset: 0x1E56CE0 VA: 0x181E578E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E56B70 Offset: 0x1E55F70 VA: 0x181E56B70
	public void CopyTo(ZiplineMountable instance) { }

	// RVA: 0x1E56CD0 Offset: 0x1E560D0 VA: 0x181E56CD0
	public ZiplineMountable Copy() { }

	// RVA: 0x1E576B0 Offset: 0x1E56AB0 VA: 0x181E576B0
	public static ZiplineMountable Deserialize(Stream stream) { }

	// RVA: 0x1E56E90 Offset: 0x1E56290 VA: 0x181E56E90
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E57400 Offset: 0x1E56800 VA: 0x181E57400
	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E57490 Offset: 0x1E56890 VA: 0x181E57490
	public static ZiplineMountable Deserialize(byte[] buffer) { }

	// RVA: 0x1E57A30 Offset: 0x1E56E30 VA: 0x181E57A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E58310 Offset: 0x1E57710 VA: 0x181E58310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E58330 Offset: 0x1E57730 VA: 0x181E58330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	// RVA: 0x1E57A50 Offset: 0x1E56E50 VA: 0x181E57A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E575B0 Offset: 0x1E569B0 VA: 0x181E575B0
	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	// RVA: 0x1E57730 Offset: 0x1E56B30 VA: 0x181E57730
	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E56F10 Offset: 0x1E56310 VA: 0x181E56F10
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E57190 Offset: 0x1E56590 VA: 0x181E57190
	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E57C30 Offset: 0x1E57030 VA: 0x181E57C30
	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	// RVA: 0x1E580B0 Offset: 0x1E574B0 VA: 0x181E580B0
	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1E58300 Offset: 0x1E57700 VA: 0x181E58300
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E58310 Offset: 0x1E57710 VA: 0x181E58310
	public void ToProto(Stream stream) { }

	// RVA: 0x1E57FA0 Offset: 0x1E573A0 VA: 0x181E57FA0
	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	// RVA: 0x1E57EB0 Offset: 0x1E572B0 VA: 0x181E57EB0
	public static void SerializeLengthDelimited(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ZiplineMountable : BaseMountable // TypeDefIndex: 8671
{	// Fields
	public float MoveSpeed; // 0x320
	public float ForwardAdditive; // 0x324
	public CapsuleCollider ZipCollider; // 0x328
	public Transform ZiplineGrabRoot; // 0x330
	public Transform LeftHandIkPoint; // 0x338
	public Transform RightHandIkPoint; // 0x340
	public float SpeedUpTime; // 0x348
	public bool EditorHoldInPlace; // 0x34C
	private List<Vector3> linePoints; // 0x350
	private const BaseEntity.Flags PushForward = 128;
	public AnimationCurve MountPositionCurve; // 0x358
	public AnimationCurve MountRotationCurve; // 0x360
	public float MountEaseInTime; // 0x368
	private const BaseEntity.Flags ShowHandle = 256;
	private float forwardSpeedAnim; // 0x36C

	// Properties
	public override bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public override float FirstPersonWithArmsEyesLerp { get; }
	public static bool HasPushedForward { get; set; }

	// Methods

	// RVA: 0x1A96B60 Offset: 0x1A95F60 VA: 0x181A96B60
	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	// RVA: 0x1A96360 Offset: 0x1A95760 VA: 0x181A96360
	private Vector3 GetLineEndPoint() { }

	// RVA: 0x1A96410 Offset: 0x1A95810 VA: 0x181A96410
	private Vector3 GetNextLinePoint(Transform forTransform) { }

	// RVA: 0x1A96ED0 Offset: 0x1A962D0 VA: 0x181A96ED0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x1A96800 Offset: 0x1A95C00 VA: 0x181A96800 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A961F0 Offset: 0x1A955F0 VA: 0x181A961F0 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 165
	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 166
	public override float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0x1A97460 Offset: 0x1A96860 VA: 0x181A97460
	public static bool get_HasPushedForward() { }

	// RVA: 0x1A974A0 Offset: 0x1A968A0 VA: 0x181A974A0
	public static void set_HasPushedForward(bool value) { }

	// RVA: 0x1A96EA0 Offset: 0x1A962A0 VA: 0x181A96EA0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A96A00 Offset: 0x1A95E00 VA: 0x181A96A00 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x1A96A20 Offset: 0x1A95E20 VA: 0x181A96A20 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x1A97370 Offset: 0x1A96770 VA: 0x181A97370
	public void .ctor() { }

}

