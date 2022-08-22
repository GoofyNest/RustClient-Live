public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20


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

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20


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

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C


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

public class PatternFirework.SavedDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6427
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int version; // 0x14
	public string name; // 0x18
	public PatternFirework.Design design; // 0x20


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

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 8275
{	public const int CurrentVersion = 1;
	[HeaderAttribute] // RVA: 0xA3C70 Offset: 0xA3070 VA: 0x1800A3C70
	public GameObjectRef FireworkDesignerDialog; // 0x270
	public int MaxStars; // 0x278
	public float ShellFuseLengthShort; // 0x27C
	public float ShellFuseLengthMed; // 0x280
	public float ShellFuseLengthLong; // 0x284
	public PatternFirework.Design Design; // 0x288
	public PatternFirework.FuseLength ShellFuseLength; // 0x290
	private Option __menuOption_MenuLongFuse; // 0x298
	private Option __menuOption_MenuMediumFuse; // 0x2F0
	private Option __menuOption_MenuOpenDesigner; // 0x348
	private Option __menuOption_MenuShortFuse; // 0x3A0

	public override bool HasMenuOptions { get; }


	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.Description] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.Icon] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	public void MenuOpenDesigner(BasePlayer player) { }

	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.Description] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.Icon] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	public void MenuShortFuse(BasePlayer player) { }

	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.Description] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.Icon] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	public void MenuMediumFuse(BasePlayer player) { }

	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.Description] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.Icon] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	public void MenuLongFuse(BasePlayer player) { }

	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	private float GetShellFuseLength() { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

public enum PatternFirework.FuseLength // TypeDefIndex: 8276
{	public int value__; // 0x0
	public const PatternFirework.FuseLength Short = 0;
	public const PatternFirework.FuseLength Medium = 1;
	public const PatternFirework.FuseLength Long = 2;
	public const PatternFirework.FuseLength Max = 2;

}

