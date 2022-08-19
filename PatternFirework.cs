public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20

	// Methods

	// RVA: 0x1F937A0 Offset: 0x1F92BA0 VA: 0x181F937A0
	public static void ResetToPool(PatternFirework instance) { }

	// RVA: 0x1F93850 Offset: 0x1F92C50 VA: 0x181F93850
	public void ResetToPool() { }

	// RVA: 0x1F93630 Offset: 0x1F92A30 VA: 0x181F93630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F929D0 Offset: 0x1F91DD0 VA: 0x181F929D0
	public void CopyTo(PatternFirework instance) { }

	// RVA: 0x1F92A60 Offset: 0x1F91E60 VA: 0x181F92A60
	public PatternFirework Copy() { }

	// RVA: 0x1F935B0 Offset: 0x1F929B0 VA: 0x181F935B0
	public static PatternFirework Deserialize(Stream stream) { }

	// RVA: 0x1F92B30 Offset: 0x1F91F30 VA: 0x181F92B30
	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F93100 Offset: 0x1F92500 VA: 0x181F93100
	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F93190 Offset: 0x1F92590 VA: 0x181F93190
	public static PatternFirework Deserialize(byte[] buffer) { }

	// RVA: 0x1F93760 Offset: 0x1F92B60 VA: 0x181F93760
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F93EC0 Offset: 0x1F932C0 VA: 0x181F93EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F93EE0 Offset: 0x1F932E0 VA: 0x181F93EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	// RVA: 0x1F93780 Offset: 0x1F92B80 VA: 0x181F93780 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F934B0 Offset: 0x1F928B0 VA: 0x181F934B0
	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	// RVA: 0x1F932B0 Offset: 0x1F926B0 VA: 0x181F932B0
	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F92BB0 Offset: 0x1F91FB0 VA: 0x181F92BB0
	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F92E70 Offset: 0x1F92270 VA: 0x181F92E70
	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F93900 Offset: 0x1F92D00 VA: 0x181F93900
	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	// RVA: 0x1F93CD0 Offset: 0x1F930D0 VA: 0x181F93CD0
	public static void Serialize(Stream stream, PatternFirework instance) { }

	// RVA: 0x1F93EB0 Offset: 0x1F932B0 VA: 0x181F93EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F93EC0 Offset: 0x1F932C0 VA: 0x181F93EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F93BC0 Offset: 0x1F92FC0 VA: 0x181F93BC0
	public static byte[] SerializeToBytes(PatternFirework instance) { }

	// RVA: 0x1F93B10 Offset: 0x1F92F10 VA: 0x181F93B10
	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20

	// Methods

	// RVA: 0x1F7CD00 Offset: 0x1F7C100 VA: 0x181F7CD00
	public static void ResetToPool(PatternFirework.Design instance) { }

	// RVA: 0x1F7CB20 Offset: 0x1F7BF20 VA: 0x181F7CB20
	public void ResetToPool() { }

	// RVA: 0x1F7CA60 Offset: 0x1F7BE60 VA: 0x181F7CA60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7BC60 Offset: 0x1F7B060 VA: 0x181F7BC60
	public void CopyTo(PatternFirework.Design instance) { }

	// RVA: 0x1F7BE10 Offset: 0x1F7B210 VA: 0x181F7BE10
	public PatternFirework.Design Copy() { }

	// RVA: 0x1F7C6B0 Offset: 0x1F7BAB0 VA: 0x181F7C6B0
	public static PatternFirework.Design Deserialize(Stream stream) { }

	// RVA: 0x1F7C1A0 Offset: 0x1F7B5A0 VA: 0x181F7C1A0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7C500 Offset: 0x1F7B900 VA: 0x181F7C500
	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7C590 Offset: 0x1F7B990 VA: 0x181F7C590
	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	// RVA: 0x1F7CAE0 Offset: 0x1F7BEE0 VA: 0x181F7CAE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7D530 Offset: 0x1F7C930 VA: 0x181F7D530 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7D550 Offset: 0x1F7C950 VA: 0x181F7D550 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	// RVA: 0x1F7CB00 Offset: 0x1F7BF00 VA: 0x181F7CB00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7C960 Offset: 0x1F7BD60 VA: 0x181F7C960
	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	// RVA: 0x1F7C730 Offset: 0x1F7BB30 VA: 0x181F7C730
	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F7BE90 Offset: 0x1F7B290 VA: 0x181F7BE90
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F7C220 Offset: 0x1F7B620 VA: 0x181F7C220
	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F7CEE0 Offset: 0x1F7C2E0 VA: 0x181F7CEE0
	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	// RVA: 0x1F7D2F0 Offset: 0x1F7C6F0 VA: 0x181F7D2F0
	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1F7D520 Offset: 0x1F7C920 VA: 0x181F7D520
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7D530 Offset: 0x1F7C930 VA: 0x181F7D530
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7D1E0 Offset: 0x1F7C5E0 VA: 0x181F7D1E0
	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	// RVA: 0x1F7D130 Offset: 0x1F7C530 VA: 0x181F7D130
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1F96C90 Offset: 0x1F96090 VA: 0x181F96C90
	public static void ResetToPool(PatternFirework.Star instance) { }

	// RVA: 0x1F96D20 Offset: 0x1F96120 VA: 0x181F96D20
	public void ResetToPool() { }

	// RVA: 0x1F96A80 Offset: 0x1F95E80 VA: 0x181F96A80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F95CD0 Offset: 0x1F950D0 VA: 0x181F95CD0
	public void CopyTo(PatternFirework.Star instance) { }

	// RVA: 0x1F95D00 Offset: 0x1F95100 VA: 0x181F95D00
	public PatternFirework.Star Copy() { }

	// RVA: 0x1F96680 Offset: 0x1F95A80 VA: 0x181F96680
	public static PatternFirework.Star Deserialize(Stream stream) { }

	// RVA: 0x1F95FC0 Offset: 0x1F953C0 VA: 0x181F95FC0
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F96250 Offset: 0x1F95650 VA: 0x181F96250
	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F96830 Offset: 0x1F95C30 VA: 0x181F96830
	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	// RVA: 0x1F96B00 Offset: 0x1F95F00 VA: 0x181F96B00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F974E0 Offset: 0x1F968E0 VA: 0x181F974E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F97500 Offset: 0x1F96900 VA: 0x181F97500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	// RVA: 0x1F96C70 Offset: 0x1F96070 VA: 0x181F96C70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F962E0 Offset: 0x1F956E0 VA: 0x181F962E0
	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	// RVA: 0x1F96500 Offset: 0x1F95900 VA: 0x181F96500
	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F95D80 Offset: 0x1F95180 VA: 0x181F95D80
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F96040 Offset: 0x1F95440 VA: 0x181F96040
	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F96DB0 Offset: 0x1F961B0 VA: 0x181F96DB0
	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	// RVA: 0x1F972A0 Offset: 0x1F966A0 VA: 0x181F972A0
	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1F974D0 Offset: 0x1F968D0 VA: 0x181F974D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F974E0 Offset: 0x1F968E0 VA: 0x181F974E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F97190 Offset: 0x1F96590 VA: 0x181F97190
	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	// RVA: 0x1F970E0 Offset: 0x1F964E0 VA: 0x181F970E0
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PatternFirework.SavedDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6427
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int version; // 0x14
	public string name; // 0x18
	public PatternFirework.Design design; // 0x20

	// Methods

	// RVA: 0x1F95390 Offset: 0x1F94790 VA: 0x181F95390
	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F95470 Offset: 0x1F94870 VA: 0x181F95470
	public void ResetToPool() { }

	// RVA: 0x1F95030 Offset: 0x1F94430 VA: 0x181F95030 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F93F00 Offset: 0x1F93300 VA: 0x181F93F00
	public void CopyTo(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F93F80 Offset: 0x1F93380 VA: 0x181F93F80
	public PatternFirework.SavedDesign Copy() { }

	// RVA: 0x1F94C30 Offset: 0x1F94030 VA: 0x181F94C30
	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	// RVA: 0x1F94050 Offset: 0x1F93450 VA: 0x181F94050
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F94630 Offset: 0x1F93A30 VA: 0x181F94630
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F946C0 Offset: 0x1F93AC0 VA: 0x181F946C0
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	// RVA: 0x1F95190 Offset: 0x1F94590 VA: 0x181F95190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F95C90 Offset: 0x1F95090 VA: 0x181F95C90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F95CB0 Offset: 0x1F950B0 VA: 0x181F95CB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F95370 Offset: 0x1F94770 VA: 0x181F95370 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F94990 Offset: 0x1F93D90 VA: 0x181F94990
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	// RVA: 0x1F94E50 Offset: 0x1F94250 VA: 0x181F94E50
	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F940D0 Offset: 0x1F934D0 VA: 0x181F940D0
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F94390 Offset: 0x1F93790 VA: 0x181F94390
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F95550 Offset: 0x1F94950 VA: 0x181F95550
	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F959F0 Offset: 0x1F94DF0 VA: 0x181F959F0
	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F95C80 Offset: 0x1F95080 VA: 0x181F95C80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F95C90 Offset: 0x1F95090 VA: 0x181F95C90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F958E0 Offset: 0x1F94CE0 VA: 0x181F958E0
	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F95830 Offset: 0x1F94C30 VA: 0x181F95830
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 8275
{	// Fields
	public const int CurrentVersion = 1;
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x948390 Offset: 0x947790 VA: 0x180948390 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x948E40 Offset: 0x948240 VA: 0x180948E40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9497E0 Offset: 0x948BE0 VA: 0x1809497E0 Slot: 146
	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.Description] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.Icon] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3D30 Offset: 0xA3130 VA: 0x1800A3D30
	// RVA: 0x9490A0 Offset: 0x9484A0 VA: 0x1809490A0
	public void MenuOpenDesigner(BasePlayer player) { }

	// RVA: 0x949020 Offset: 0x948420 VA: 0x180949020
	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9496C0 Offset: 0x948AC0 VA: 0x1809496C0
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x9498F0 Offset: 0x948CF0 VA: 0x1809498F0
	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.Description] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.Icon] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	// RVA: 0x949120 Offset: 0x948520 VA: 0x180949120
	public void MenuShortFuse(BasePlayer player) { }

	// RVA: 0x9490E0 Offset: 0x9484E0 VA: 0x1809490E0
	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.Description] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.Icon] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4570 Offset: 0xA3970 VA: 0x1800A4570
	// RVA: 0x948FD0 Offset: 0x9483D0 VA: 0x180948FD0
	public void MenuMediumFuse(BasePlayer player) { }

	// RVA: 0x948F90 Offset: 0x948390 VA: 0x180948F90
	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.Description] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.Icon] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA48A0 Offset: 0xA3CA0 VA: 0x1800A48A0
	// RVA: 0x948F40 Offset: 0x948340 VA: 0x180948F40
	public void MenuLongFuse(BasePlayer player) { }

	// RVA: 0x948F00 Offset: 0x948300 VA: 0x180948F00
	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	// RVA: 0x948E10 Offset: 0x948210 VA: 0x180948E10
	private float GetShellFuseLength() { }

	// RVA: 0x9483E0 Offset: 0x9477E0 VA: 0x1809483E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x949990 Offset: 0x948D90 VA: 0x180949990 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x949170 Offset: 0x948570 VA: 0x180949170 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x949960 Offset: 0x948D60 VA: 0x180949960
	public void .ctor() { }

}

public enum PatternFirework.FuseLength // TypeDefIndex: 8276
{	// Fields
	public int value__; // 0x0
	public const PatternFirework.FuseLength Short = 0;
	public const PatternFirework.FuseLength Medium = 1;
	public const PatternFirework.FuseLength Long = 2;
	public const PatternFirework.FuseLength Max = 2;

}

