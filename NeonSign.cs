public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6393
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<NeonSign.Lights> frameLighting; 
	public int currentFrame; 
	public float animationSpeed; 


	public static void ResetToPool(NeonSign instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(NeonSign instance) { }

	public NeonSign Copy() { }

	public static NeonSign Deserialize(Stream stream) { }

	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	public static NeonSign DeserializeLength(Stream stream, int length) { }

	public static NeonSign Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	public static void Serialize(Stream stream, NeonSign instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(NeonSign instance) { }

	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	public void .ctor() { }

}

public class NeonSign.Lights : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6394
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Color topLeft; 
	public Color topRight; 
	public Color bottomLeft; 
	public Color bottomRight; 


	public static void ResetToPool(NeonSign.Lights instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(NeonSign.Lights instance) { }

	public NeonSign.Lights Copy() { }

	public static NeonSign.Lights Deserialize(Stream stream) { }

	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	public void .ctor() { }

}

public class NeonSign : Signage // TypeDefIndex: 8426
{
	private Option __menuOption_SwitchToFastSpeed; 
	private Option __menuOption_SwitchToMediumSpeed; 
	private Option __menuOption_SwitchToSlowSpeed; 
	private const float FastSpeed = 0,5;
	private const float MediumSpeed = 1;
	private const float SlowSpeed = 2;
	private const float MinSpeed = 0,5;
	private const float MaxSpeed = 5;
	[HeaderAttribute] 
	public Light topLeft; 
	public Light topRight; 
	public Light bottomLeft; 
	public Light bottomRight; 
	public float lightIntensity; 
	[RangeAttribute] 
	public int powerConsumption; 
	public Material activeMaterial; 
	public Material inactiveMaterial; 
	private float animationSpeed; 
	private int currentFrame; 
	private List<NeonSign.Lights> frameLighting; 
	public AmbienceEmitter ambientSoundEmitter; 
	public SoundDefinition switchSoundDef; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override int ConsumptionAmount() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void UpdateNeonDisplay() { }

	private void UpdateLights() { }

	private void UpdateSounds() { }

	protected override void OnEnterTextureRange() { }

	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchToSlowSpeed(BasePlayer player) { }

	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchToMediumSpeed(BasePlayer player) { }

	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchToFastSpeed(BasePlayer player) { }

	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void EnsureInitialized() { }

	private static Color ClampColor(Color color) { }

	public void .ctor() { }

}

