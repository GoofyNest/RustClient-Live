public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{
	public bool ShouldPool; 
	private bool _disposed; 
	public PatternFirework.Design design; 
	public int shellFuseLength; 


	public static void ResetToPool(PatternFirework instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PatternFirework instance) { }

	public PatternFirework Copy() { }

	public static PatternFirework Deserialize(Stream stream) { }

	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	public static PatternFirework Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	public static void Serialize(Stream stream, PatternFirework instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PatternFirework instance) { }

	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<PatternFirework.Star> stars; 
	public ulong editedBy; 


	public static void ResetToPool(PatternFirework.Design instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PatternFirework.Design instance) { }

	public PatternFirework.Design Copy() { }

	public static PatternFirework.Design Deserialize(Stream stream) { }

	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector2 position; 
	public Color color; 


	public static void ResetToPool(PatternFirework.Star instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PatternFirework.Star instance) { }

	public PatternFirework.Star Copy() { }

	public static PatternFirework.Star Deserialize(Stream stream) { }

	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	public void .ctor() { }

}

public class PatternFirework.SavedDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int version; 
	public string name; 
	public PatternFirework.Design design; 


	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PatternFirework.SavedDesign instance) { }

	public PatternFirework.SavedDesign Copy() { }

	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	public void .ctor() { }

}

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 9989
{
	public const int CurrentVersion = 1;
	[HeaderAttribute] 
	public GameObjectRef FireworkDesignerDialog; 
	public int MaxStars; 
	public float ShellFuseLengthShort; 
	public float ShellFuseLengthMed; 
	public float ShellFuseLengthLong; 
	public PatternFirework.Design Design; 
	public PatternFirework.FuseLength ShellFuseLength; 
	private Option __menuOption_MenuLongFuse; 
	private Option __menuOption_MenuMediumFuse; 
	private Option __menuOption_MenuOpenDesigner; 
	private Option __menuOption_MenuShortFuse; 

	public override bool HasMenuOptions { get; }


	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuOpenDesigner(BasePlayer player) { }

	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuShortFuse(BasePlayer player) { }

	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuMediumFuse(BasePlayer player) { }

	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuLongFuse(BasePlayer player) { }

	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	private float GetShellFuseLength() { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

public enum PatternFirework.FuseLength // TypeDefIndex: 9990
{
	public int value__; 
	public const PatternFirework.FuseLength Short = 0;
	public const PatternFirework.FuseLength Medium = 1;
	public const PatternFirework.FuseLength Long = 2;
	public const PatternFirework.FuseLength Max = 2;

}

