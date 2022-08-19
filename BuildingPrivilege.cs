public class BuildInfo // TypeDefIndex: 6169
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BuildInfo.ScmInfo <Scm>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BuildInfo.BuildDesc <Build>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Valid>k__BackingField; // 0x28
	private static BuildInfo _current; // 0x0

	// Properties
	public int Date { get; set; }
	[JsonIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DateTime BuildDate { get; }
	public BuildInfo.ScmInfo Scm { get; set; }
	public BuildInfo.BuildDesc Build { get; set; }
	public bool Valid { get; set; }
	public static BuildInfo Current { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_Date(int value) { }

	// RVA: 0x14E1E20 Offset: 0x14E1220 VA: 0x1814E1E20
	public DateTime get_BuildDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public BuildInfo.ScmInfo get_Scm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Scm(BuildInfo.ScmInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public BuildInfo.BuildDesc get_Build() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Build(BuildInfo.BuildDesc value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	public void set_Valid(bool value) { }

	// RVA: 0x14E1F60 Offset: 0x14E1360 VA: 0x1814E1F60
	public static BuildInfo get_Current() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BuildInfo.ScmInfo // TypeDefIndex: 6170
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ChangeId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Branch>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Repo>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Comment>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Author>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Date>k__BackingField; // 0x40

	// Properties
	public string Type { get; set; }
	public string ChangeId { get; set; }
	public string Branch { get; set; }
	public string Repo { get; set; }
	public string Comment { get; set; }
	public string Author { get; set; }
	public string Date { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Type(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_ChangeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ChangeId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Branch(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Repo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Repo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Author() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Author(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Date(string value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BuildInfo.BuildDesc // TypeDefIndex: 6171
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Id>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Number>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Tag>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Url>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Node>k__BackingField; // 0x38

	// Properties
	public string Id { get; set; }
	public string Number { get; set; }
	public string Tag { get; set; }
	public string Url { get; set; }
	public string Name { get; set; }
	public string Node { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Number(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Tag(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Url(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Node() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Node(string value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BuildingBlock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6303
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int model; // 0x14
	public int grade; // 0x18
	public bool beingDemolished; // 0x1C

	// Methods

	// RVA: 0x1F6C090 Offset: 0x1F6B490 VA: 0x181F6C090
	public static void ResetToPool(BuildingBlock instance) { }

	// RVA: 0x1F6C120 Offset: 0x1F6B520 VA: 0x181F6C120
	public void ResetToPool() { }

	// RVA: 0x1F6BDB0 Offset: 0x1F6B1B0 VA: 0x181F6BDB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D63960 Offset: 0x1D62D60 VA: 0x181D63960
	public void CopyTo(BuildingBlock instance) { }

	// RVA: 0x1F6AE80 Offset: 0x1F6A280 VA: 0x181F6AE80
	public BuildingBlock Copy() { }

	// RVA: 0x1F6BA10 Offset: 0x1F6AE10 VA: 0x181F6BA10
	public static BuildingBlock Deserialize(Stream stream) { }

	// RVA: 0x1F6AF00 Offset: 0x1F6A300 VA: 0x181F6AF00
	public static BuildingBlock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6B460 Offset: 0x1F6A860 VA: 0x181F6B460
	public static BuildingBlock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6B770 Offset: 0x1F6AB70 VA: 0x181F6B770
	public static BuildingBlock Deserialize(byte[] buffer) { }

	// RVA: 0x1F6BEC0 Offset: 0x1F6B2C0 VA: 0x181F6BEC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6C660 Offset: 0x1F6BA60 VA: 0x181F6C660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6C680 Offset: 0x1F6BA80 VA: 0x181F6C680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingBlock previous) { }

	// RVA: 0x1F6C070 Offset: 0x1F6B470 VA: 0x181F6C070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6B4F0 Offset: 0x1F6A8F0 VA: 0x181F6B4F0
	public static BuildingBlock Deserialize(byte[] buffer, BuildingBlock instance, bool isDelta = False) { }

	// RVA: 0x1F6BC00 Offset: 0x1F6B000 VA: 0x181F6BC00
	public static BuildingBlock Deserialize(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F6AF80 Offset: 0x1F6A380 VA: 0x181F6AF80
	public static BuildingBlock DeserializeLengthDelimited(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F6B200 Offset: 0x1F6A600 VA: 0x181F6B200
	public static BuildingBlock DeserializeLength(Stream stream, int length, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F6C1B0 Offset: 0x1F6B5B0 VA: 0x181F6C1B0
	public static void SerializeDelta(Stream stream, BuildingBlock instance, BuildingBlock previous) { }

	// RVA: 0x1F6C530 Offset: 0x1F6B930 VA: 0x181F6C530
	public static void Serialize(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1F6C650 Offset: 0x1F6BA50 VA: 0x181F6C650
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6C660 Offset: 0x1F6BA60 VA: 0x181F6C660
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6C420 Offset: 0x1F6B820 VA: 0x181F6C420
	public static byte[] SerializeToBytes(BuildingBlock instance) { }

	// RVA: 0x1F6C370 Offset: 0x1F6B770 VA: 0x181F6C370
	public static void SerializeLengthDelimited(Stream stream, BuildingBlock instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BuildingPrivilege : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6310
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PlayerNameID> users; // 0x18
	public float upkeepPeriodMinutes; // 0x20
	public float costFraction; // 0x24
	public float protectedMinutes; // 0x28

	// Methods

	// RVA: 0x1F6DF30 Offset: 0x1F6D330 VA: 0x181F6DF30
	public static void ResetToPool(BuildingPrivilege instance) { }

	// RVA: 0x1F6E120 Offset: 0x1F6D520 VA: 0x181F6E120
	public void ResetToPool() { }

	// RVA: 0x1F6DC30 Offset: 0x1F6D030 VA: 0x181F6DC30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F6C6A0 Offset: 0x1F6BAA0 VA: 0x181F6C6A0
	public void CopyTo(BuildingPrivilege instance) { }

	// RVA: 0x1F6C7E0 Offset: 0x1F6BBE0 VA: 0x181F6C7E0
	public BuildingPrivilege Copy() { }

	// RVA: 0x1F6D420 Offset: 0x1F6C820 VA: 0x181F6D420
	public static BuildingPrivilege Deserialize(Stream stream) { }

	// RVA: 0x1F6CCB0 Offset: 0x1F6C0B0 VA: 0x181F6CCB0
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6CD30 Offset: 0x1F6C130 VA: 0x181F6CD30
	public static BuildingPrivilege DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6D910 Offset: 0x1F6CD10 VA: 0x181F6D910
	public static BuildingPrivilege Deserialize(byte[] buffer) { }

	// RVA: 0x1F6DCB0 Offset: 0x1F6D0B0 VA: 0x181F6DCB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6EA70 Offset: 0x1F6DE70 VA: 0x181F6EA70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6EA90 Offset: 0x1F6DE90 VA: 0x181F6EA90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingPrivilege previous) { }

	// RVA: 0x1F6DF10 Offset: 0x1F6D310 VA: 0x181F6DF10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6D0E0 Offset: 0x1F6C4E0 VA: 0x181F6D0E0
	public static BuildingPrivilege Deserialize(byte[] buffer, BuildingPrivilege instance, bool isDelta = False) { }

	// RVA: 0x1F6D6A0 Offset: 0x1F6CAA0 VA: 0x181F6D6A0
	public static BuildingPrivilege Deserialize(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F6C970 Offset: 0x1F6BD70 VA: 0x181F6C970
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F6CDC0 Offset: 0x1F6C1C0 VA: 0x181F6CDC0
	public static BuildingPrivilege DeserializeLength(Stream stream, int length, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F6E310 Offset: 0x1F6D710 VA: 0x181F6E310
	public static void SerializeDelta(Stream stream, BuildingPrivilege instance, BuildingPrivilege previous) { }

	// RVA: 0x1F6E7E0 Offset: 0x1F6DBE0 VA: 0x181F6E7E0
	public static void Serialize(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1F6EA60 Offset: 0x1F6DE60 VA: 0x181F6EA60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6EA70 Offset: 0x1F6DE70 VA: 0x181F6EA70
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6E6D0 Offset: 0x1F6DAD0 VA: 0x181F6E6D0
	public static byte[] SerializeToBytes(BuildingPrivilege instance) { }

	// RVA: 0x1F6E620 Offset: 0x1F6DA20 VA: 0x181F6E620
	public static void SerializeLengthDelimited(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BuildingPrivlidge : StorageContainer // TypeDefIndex: 8363
{	// Fields
	private Option __menuOption_Menu_MaxAuth; // 0x3D0
	private Option __menuOption_Menu_RotateVM; // 0x428
	private Option __menuOption_MenuAuthorize; // 0x480
	private Option __menuOption_MenuClearList; // 0x4D8
	private Option __menuOption_MenuDeauthorize; // 0x530
	private float cachedProtectedMinutes; // 0x588
	private float cachedUpkeepPeriodMinutes; // 0x58C
	private float cachedUpkeepCostFraction; // 0x590
	public List<PlayerNameID> authorizedPlayers; // 0x598
	public const BaseEntity.Flags Flag_MaxAuths = 2048;
	public List<ItemDefinition> allowedConstructionItems; // 0x5A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x706550 Offset: 0x705950 VA: 0x180706550 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x707B90 Offset: 0x706F90 VA: 0x180707B90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7078B0 Offset: 0x706CB0 VA: 0x1807078B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x706520 Offset: 0x705920 VA: 0x180706520
	public float CalculateUpkeepPeriodMinutes() { }

	// RVA: 0x7064F0 Offset: 0x7058F0 VA: 0x1807064F0
	public float CalculateUpkeepCostFraction() { }

	// RVA: 0x706350 Offset: 0x705750 VA: 0x180706350
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts) { }

	// RVA: 0x707280 Offset: 0x706680 VA: 0x180707280
	public float GetProtectedMinutes(bool force = False) { }

	// RVA: 0x7079A0 Offset: 0x706DA0 VA: 0x1807079A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x707370 Offset: 0x706770 VA: 0x180707370
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x7072C0 Offset: 0x7066C0 VA: 0x1807072C0
	public bool IsAuthed(ulong userID) { }

	// RVA: 0x706300 Offset: 0x705700 VA: 0x180706300
	public bool AnyAuthed() { }

	// RVA: 0x707430 Offset: 0x706830 VA: 0x180707430 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void BuildingDirty() { }

	[BaseEntity.Menu] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.Description] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.Icon] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x707740 Offset: 0x706B40 VA: 0x180707740
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.Description] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.Icon] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	// RVA: 0x707590 Offset: 0x706990 VA: 0x180707590
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x707550 Offset: 0x706950 VA: 0x180707550
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.Description] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.Icon] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	// RVA: 0x707700 Offset: 0x706B00 VA: 0x180707700
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x7076F0 Offset: 0x706AF0 VA: 0x1807076F0
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.Description] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.Icon] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	// RVA: 0x7076B0 Offset: 0x706AB0 VA: 0x1807076B0
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x7075D0 Offset: 0x7069D0 VA: 0x1807075D0
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	// RVA: 0x707A00 Offset: 0x706E00 VA: 0x180707A00 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.Description] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.Icon] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	// RVA: 0x707870 Offset: 0x706C70 VA: 0x180707870
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0x707790 Offset: 0x706B90 VA: 0x180707790
	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	// RVA: 0x707120 Offset: 0x706520 VA: 0x180707120 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x7072B0 Offset: 0x7066B0 VA: 0x1807072B0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x707AD0 Offset: 0x706ED0 VA: 0x180707AD0
	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 8364
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x71F090 Offset: 0x71E490 VA: 0x18071F090
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 8365
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x71F0C0 Offset: 0x71E4C0 VA: 0x18071F0C0
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

public class BuildingBlock : StabilityEntity // TypeDefIndex: 8538
{	// Fields
	private bool forceSkinRefresh; // 0x268
	private int modelState; // 0x26C
	private int lastModelState; // 0x270
	public BuildingGrade.Enum grade; // 0x274
	private BuildingGrade.Enum lastGrade; // 0x278
	private ConstructionSkin currentSkin; // 0x280
	private DeferredAction skinChange; // 0x288
	private MeshRenderer placeholderRenderer; // 0x290
	private MeshCollider placeholderCollider; // 0x298
	private static Material HighlightMaterial; // 0x0
	public static BuildingBlock.UpdateSkinWorkQueue updateSkinQueueClient; // 0x8
	public bool CullBushes; // 0x2A0
	public Construction blockDefinition; // 0x2A8
	private static Vector3[] outsideLookupOffsets; // 0x10

	// Properties
	public ConstructionGrade currentGrade { get; }

	// Methods

	// RVA: 0x704900 Offset: 0x703D00 VA: 0x180704900 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x702830 Offset: 0x701C30 VA: 0x180702830 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x704E10 Offset: 0x704210 VA: 0x180704E10 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x702C80 Offset: 0x702080 VA: 0x180702C80
	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x704E70 Offset: 0x704270 VA: 0x180704E70
	private void RefreshSkin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7053A0 Offset: 0x7047A0 VA: 0x1807053A0 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x702280 Offset: 0x701680 VA: 0x180702280
	private bool CanDemolish(BasePlayer player) { }

	// RVA: 0x704060 Offset: 0x703460 VA: 0x180704060
	private bool IsDemolishable() { }

	// RVA: 0x703660 Offset: 0x702A60 VA: 0x180703660
	private bool HasDemolishPrivilege(BasePlayer player) { }

	// RVA: 0x702A80 Offset: 0x701E80 VA: 0x180702A80
	private void Demolish(BasePlayer player) { }

	// RVA: 0x702910 Offset: 0x701D10 VA: 0x180702910
	private void DemolishOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x705260 Offset: 0x704660 VA: 0x180705260
	public void SetConditionalModel(int state) { }

	// RVA: 0x702E50 Offset: 0x702250 VA: 0x180702E50
	public bool GetConditionalModel(int index) { }

	// RVA: 0x705C00 Offset: 0x705000 VA: 0x180705C00
	public ConstructionGrade get_currentGrade() { }

	// RVA: 0x702E70 Offset: 0x702270 VA: 0x180702E70
	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade) { }

	// RVA: 0x702250 Offset: 0x701650 VA: 0x180702250
	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x703820 Offset: 0x702C20 VA: 0x180703820
	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x704540 Offset: 0x703940 VA: 0x180704540
	private bool IsUpgradeBlocked() { }

	// RVA: 0x702080 Offset: 0x701480 VA: 0x180702080
	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x705270 Offset: 0x704670 VA: 0x180705270
	public void SetGrade(BuildingGrade.Enum iGradeID) { }

	// RVA: 0x705430 Offset: 0x704830 VA: 0x180705430
	private void UpdateGrade() { }

	// RVA: 0x705820 Offset: 0x704C20 VA: 0x180705820
	private void UpgradeToGrade(BuildingGrade.Enum i, BasePlayer player) { }

	// RVA: 0x703210 Offset: 0x702610 VA: 0x180703210
	private void GradeChangingOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x704860 Offset: 0x703C60 VA: 0x180704860
	private bool NeedsSkinChange() { }

	// RVA: 0x705550 Offset: 0x704950 VA: 0x180705550
	public void UpdateSkin(bool force = False) { }

	// RVA: 0x702AE0 Offset: 0x701EE0 VA: 0x180702AE0
	private void DestroySkin() { }

	// RVA: 0x705470 Offset: 0x704870 VA: 0x180705470
	private void UpdatePlaceholder(bool state) { }

	// RVA: 0x7026B0 Offset: 0x701AB0 VA: 0x1807026B0
	private void ChangeSkin() { }

	// RVA: 0x702490 Offset: 0x701890 VA: 0x180702490
	private void ChangeSkin(GameObjectRef prefab) { }

	// RVA: 0x705390 Offset: 0x704790 VA: 0x180705390 Slot: 127
	public override bool ShouldBlockProjectiles() { }

	// RVA: 0x704830 Offset: 0x703C30 VA: 0x180704830 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x702050 Offset: 0x701450 VA: 0x180702050 Slot: 137
	public override List<ItemAmount> BuildCost() { }

	// RVA: 0x702B90 Offset: 0x701F90 VA: 0x180702B90
	public void DrawHighlight() { }

	// RVA: 0x703970 Offset: 0x702D70 VA: 0x180703970
	public void Highlight(MeshRenderer renderer) { }

	// RVA: 0x7023E0 Offset: 0x7017E0 VA: 0x1807023E0
	private bool CanRotate(BasePlayer player) { }

	// RVA: 0x704370 Offset: 0x703770 VA: 0x180704370
	private bool IsRotatable() { }

	// RVA: 0x7043C0 Offset: 0x7037C0 VA: 0x1807043C0
	private bool IsRotationBlocked() { }

	// RVA: 0x703740 Offset: 0x702B40 VA: 0x180703740
	private bool HasRotationPrivilege(BasePlayer player) { }

	// RVA: 0x7051B0 Offset: 0x7045B0 VA: 0x1807051B0
	private void Rotation(BasePlayer player) { }

	// RVA: 0x704F70 Offset: 0x704370 VA: 0x180704F70
	private void RotationOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x7046C0 Offset: 0x703AC0 VA: 0x1807046C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x704F00 Offset: 0x704300 VA: 0x180704F00 Slot: 27
	public override void ResetState() { }

	// RVA: 0x703FE0 Offset: 0x7033E0 VA: 0x180703FE0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x704DA0 Offset: 0x7041A0 VA: 0x180704DA0 Slot: 30
	public override void PostInitShared() { }

	// RVA: 0x6D0C70 Offset: 0x6D0070 VA: 0x1806D0C70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x702460 Offset: 0x701860 VA: 0x180702460 Slot: 122
	public override string Categorize() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x7040E0 Offset: 0x7034E0 VA: 0x1807040E0 Slot: 106
	public override bool IsOutside() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x705BE0 Offset: 0x704FE0 VA: 0x180705BE0
	public void .ctor() { }

	// RVA: 0x7058D0 Offset: 0x704CD0 VA: 0x1807058D0
	private static void .cctor() { }

}

public static class BuildingBlock.BlockFlags // TypeDefIndex: 8539
{	// Fields
	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 8540
{	// Methods

	// RVA: 0x71F1A0 Offset: 0x71E5A0 VA: 0x18071F1A0 Slot: 6
	protected override void RunJob(BuildingBlock entity) { }

	// RVA: 0x71F1E0 Offset: 0x71E5E0 VA: 0x18071F1E0 Slot: 5
	protected override bool ShouldAdd(BuildingBlock entity) { }

	// RVA: 0x71F1F0 Offset: 0x71E5F0 VA: 0x18071F1F0
	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 8541
{	// Fields
	public BuildingGrade.Enum iNewGrade; // 0x10
	public BuildingBlock <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x71F0E0 Offset: 0x71E4E0 VA: 0x18071F0E0
	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 9049
{	// Fields
	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;

	// Methods

	// RVA: 0x707E10 Offset: 0x707210 VA: 0x180707E10
	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	// RVA: 0x708600 Offset: 0x707A00 VA: 0x180708600
	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	// RVA: 0x708B90 Offset: 0x707F90 VA: 0x180708B90
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x7085A0 Offset: 0x7079A0 VA: 0x1807085A0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x708CB0 Offset: 0x7080B0 VA: 0x180708CB0
	public void .ctor() { }

}

private struct BuildingProximity.ProximityInfo // TypeDefIndex: 9050
{	// Fields
	public bool hit; // 0x0
	public bool connection; // 0x1
	public Line line; // 0x4
	public float sqrDist; // 0x1C

}

public class BuildingBlockDecay : Decay // TypeDefIndex: 9525
{	// Methods

	// RVA: 0x702040 Offset: 0x701440 VA: 0x180702040
	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 9526
{	// Fields
	public BuildingGrade.Enum decayGrade; // 0x98

	// Methods

	// RVA: 0x702040 Offset: 0x701440 VA: 0x180702040
	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 9825
{	// Fields
	public static ClientBuildingManager client; // 0x0
	protected ListHashSet<DecayEntity> decayEntities; // 0x10
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; // 0x18

	// Methods

	// RVA: 0x705FA0 Offset: 0x7053A0 VA: 0x180705FA0
	public BuildingManager.Building GetBuilding(uint buildingID) { }

	// RVA: 0x705E00 Offset: 0x705200 VA: 0x180705E00
	public void Add(DecayEntity ent) { }

	// RVA: 0x706010 Offset: 0x705410 VA: 0x180706010
	public void Remove(DecayEntity ent) { }

	// RVA: 0x705F50 Offset: 0x705350 VA: 0x180705F50
	public void Clear() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract BuildingManager.Building CreateBuilding(uint id);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	// RVA: 0x706260 Offset: 0x705660 VA: 0x180706260
	protected void .ctor() { }

	// RVA: 0x706200 Offset: 0x705600 VA: 0x180706200
	private static void .cctor() { }

}

public class BuildingManager.Building // TypeDefIndex: 9826
{	// Fields
	public uint ID; // 0x10
	public ListHashSet<BuildingPrivlidge> buildingPrivileges; // 0x18
	public ListHashSet<BuildingBlock> buildingBlocks; // 0x20
	public ListHashSet<DecayEntity> decayEntities; // 0x28
	public NavMeshObstacle buildingNavMeshObstacle; // 0x30
	public ListHashSet<NavMeshObstacle> navmeshCarvers; // 0x38
	public bool isNavMeshCarvingDirty; // 0x40
	public bool isNavMeshCarveOptimized; // 0x41

	// Methods

	// RVA: 0x7093F0 Offset: 0x7087F0 VA: 0x1807093F0
	public bool IsEmpty() { }

	// RVA: 0x7091D0 Offset: 0x7085D0 VA: 0x1807091D0
	public BuildingPrivlidge GetDominatingBuildingPrivilege() { }

	// RVA: 0x709350 Offset: 0x708750 VA: 0x180709350
	public bool HasBuildingPrivileges() { }

	// RVA: 0x709300 Offset: 0x708700 VA: 0x180709300
	public bool HasBuildingBlocks() { }

	// RVA: 0x7093A0 Offset: 0x7087A0 VA: 0x1807093A0
	public bool HasDecayEntities() { }

	// RVA: 0x708DB0 Offset: 0x7081B0 VA: 0x180708DB0
	public void AddBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x709540 Offset: 0x708940 VA: 0x180709540
	public void RemoveBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x708D10 Offset: 0x708110 VA: 0x180708D10
	public void AddBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x7094B0 Offset: 0x7088B0 VA: 0x1807094B0
	public void RemoveBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x708E50 Offset: 0x708250 VA: 0x180708E50
	public void AddDecayEntity(DecayEntity ent) { }

	// RVA: 0x7095D0 Offset: 0x7089D0 VA: 0x1807095D0
	public void RemoveDecayEntity(DecayEntity ent) { }

	// RVA: 0x708EF0 Offset: 0x7082F0 VA: 0x180708EF0
	public void Add(DecayEntity ent) { }

	// RVA: 0x709660 Offset: 0x708A60 VA: 0x180709660
	public void Remove(DecayEntity ent) { }

	// RVA: 0x709150 Offset: 0x708550 VA: 0x180709150
	public void Dirty() { }

	// RVA: 0x709860 Offset: 0x708C60 VA: 0x180709860
	public void .ctor() { }

}

public class BuildingGrade : ScriptableObject // TypeDefIndex: 10716
{	// Fields
	public BuildingGrade.Enum type; // 0x18
	public float baseHealth; // 0x1C
	public List<ItemAmount> baseCost; // 0x20
	public PhysicMaterial physicMaterial; // 0x28
	public ProtectionProperties damageProtecton; // 0x30
	public BaseEntity.Menu.Option upgradeMenu; // 0x38

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public enum BuildingGrade.Enum // TypeDefIndex: 10717
{	// Fields
	public int value__; // 0x0
	public const BuildingGrade.Enum None = -1;
	public const BuildingGrade.Enum Twigs = 0;
	public const BuildingGrade.Enum Wood = 1;
	public const BuildingGrade.Enum Stone = 2;
	public const BuildingGrade.Enum Metal = 3;
	public const BuildingGrade.Enum TopTier = 4;
	public const BuildingGrade.Enum Count = 5;

}

