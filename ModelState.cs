public class ModelState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6274
{

public class ModelState : IDisposable, Pool.IPooled, IProto 
	public bool ShouldPool; 
	private bool _disposed; 
	public float waterLevel; 
	public Vector3 lookDir; 
	public int flags; 
	public int poseType; 
	public Vector3 inheritedVelocity; 

	public bool ducked { get; set; }
	public bool jumped { get; set; }
	public bool onground { get; set; }
	public bool sleeping { get; set; }
	public bool sprinting { get; set; }
	public bool onLadder { get; set; }
	public bool flying { get; set; }
	public bool aiming { get; set; }
	public bool prone { get; set; }
	public bool mounted { get; set; }
	public bool relaxed { get; set; }
	public bool crawling { get; set; }
	public bool onPhone { get; set; }
	public bool headLook { get; set; }


	public void .ctor() { }

	public bool HasFlag(ModelState.Flag f) { }

	public void SetFlag(ModelState.Flag f, bool b) { }

	public bool get_ducked() { }

	public void set_ducked(bool value) { }

	public bool get_jumped() { }

	public void set_jumped(bool value) { }

	public bool get_onground() { }

	public void set_onground(bool value) { }

	public bool get_sleeping() { }

	public void set_sleeping(bool value) { }

	public bool get_sprinting() { }

	public void set_sprinting(bool value) { }

	public bool get_onLadder() { }

	public void set_onLadder(bool value) { }

	public bool get_flying() { }

	public void set_flying(bool value) { }

	public bool get_aiming() { }

	public void set_aiming(bool value) { }

	public bool get_prone() { }

	public void set_prone(bool value) { }

	public bool get_mounted() { }

	public void set_mounted(bool value) { }

	public bool get_relaxed() { }

	public void set_relaxed(bool value) { }

	public bool get_crawling() { }

	public void set_crawling(bool value) { }

	public bool get_onPhone() { }

	public void set_onPhone(bool value) { }

	public bool get_headLook() { }

	public void set_headLook(bool value) { }

	public static bool Equal(ModelState a, ModelState b) { }

	public static void ResetToPool(ModelState instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ModelState instance) { }

	public ModelState Copy() { }

	public static ModelState Deserialize(Stream stream) { }

	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	public static ModelState DeserializeLength(Stream stream, int length) { }

	public static ModelState Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	public static void Serialize(Stream stream, ModelState instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ModelState instance) { }

	public static void SerializeLengthDelimited(Stream stream, ModelState instance) { }

}

public enum ModelState.Flag // TypeDefIndex: 6275
{
	public int value__; 
	public const ModelState.Flag Ducked = 1;
	public const ModelState.Flag Jumped = 2;
	public const ModelState.Flag OnGround = 4;
	public const ModelState.Flag Sleeping = 8;
	public const ModelState.Flag Sprinting = 16;
	public const ModelState.Flag OnLadder = 32;
	public const ModelState.Flag Flying = 64;
	public const ModelState.Flag Aiming = 128;
	public const ModelState.Flag Prone = 256;
	public const ModelState.Flag Mounted = 512;
	public const ModelState.Flag Relaxed = 1024;
	public const ModelState.Flag OnPhone = 2048;
	public const ModelState.Flag Crawling = 4096;
	public const ModelState.Flag HeadLook = 16384;

}

