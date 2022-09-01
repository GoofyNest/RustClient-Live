public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<VectorData> linePoints; 


	public static void ResetToPool(ZiplineMountable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ZiplineMountable instance) { }

	public ZiplineMountable Copy() { }

	public static ZiplineMountable Deserialize(Stream stream) { }

	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	public static ZiplineMountable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	public static void SerializeLengthDelimited(Stream stream, ZiplineMountable instance) { }

	public void .ctor() { }

}

public class ZiplineMountable : BaseMountable // TypeDefIndex: 8674
{
	public float MoveSpeed; 
	public float ForwardAdditive; 
	public CapsuleCollider ZipCollider; 
	public Transform ZiplineGrabRoot; 
	public Transform LeftHandIkPoint; 
	public Transform RightHandIkPoint; 
	public float SpeedUpTime; 
	public bool EditorHoldInPlace; 
	private List<Vector3> linePoints; 
	private const BaseEntity.Flags PushForward = 128;
	public AnimationCurve MountPositionCurve; 
	public AnimationCurve MountRotationCurve; 
	public float MountEaseInTime; 
	private const BaseEntity.Flags ShowHandle = 256;
	private float forwardSpeedAnim; 

	public override bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public override float FirstPersonWithArmsEyesLerp { get; }
	public static bool HasPushedForward { get; set; }


	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	private Vector3 GetLineEndPoint() { }

	private Vector3 GetNextLinePoint(Transform forTransform) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override float GetMountedAnimationSpeed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	public override float get_FirstPersonWithArmsEyesLerp() { }

	public static bool get_HasPushedForward() { }

	public static void set_HasPushedForward(bool value) { }

	public override void ResetState() { }

	public override float MaxVelocity() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

}

