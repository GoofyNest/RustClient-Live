public class AIDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6540
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> availableStates; // 0x18
	public List<AIStateContainer> stateContainers; // 0x20
	public int defaultStateContainer; // 0x28
	public string description; // 0x30
	public int scope; // 0x38
	public int intialViewStateID; // 0x3C

	// Methods

	// RVA: 0x2005CB0 Offset: 0x20050B0 VA: 0x182005CB0
	public static void ResetToPool(AIDesign instance) { }

	// RVA: 0x2005F40 Offset: 0x2005340 VA: 0x182005F40
	public void ResetToPool() { }

	// RVA: 0x2005BF0 Offset: 0x2004FF0 VA: 0x182005BF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2004900 Offset: 0x2003D00 VA: 0x182004900
	public void CopyTo(AIDesign instance) { }

	// RVA: 0x2004B30 Offset: 0x2003F30 VA: 0x182004B30
	public AIDesign Copy() { }

	// RVA: 0x20055A0 Offset: 0x20049A0 VA: 0x1820055A0
	public static AIDesign Deserialize(Stream stream) { }

	// RVA: 0x2004BB0 Offset: 0x2003FB0 VA: 0x182004BB0
	public static AIDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2005510 Offset: 0x2004910 VA: 0x182005510
	public static AIDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2005720 Offset: 0x2004B20 VA: 0x182005720
	public static AIDesign Deserialize(byte[] buffer) { }

	// RVA: 0x2005C70 Offset: 0x2005070 VA: 0x182005C70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2006B40 Offset: 0x2005F40 VA: 0x182006B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2006B60 Offset: 0x2005F60 VA: 0x182006B60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIDesign previous) { }

	// RVA: 0x2005C90 Offset: 0x2005090 VA: 0x182005C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2005620 Offset: 0x2004A20 VA: 0x182005620
	public static AIDesign Deserialize(byte[] buffer, AIDesign instance, bool isDelta = False) { }

	// RVA: 0x2005840 Offset: 0x2004C40 VA: 0x182005840
	public static AIDesign Deserialize(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x2004C30 Offset: 0x2004030 VA: 0x182004C30
	public static AIDesign DeserializeLengthDelimited(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x20050B0 Offset: 0x20044B0 VA: 0x1820050B0
	public static AIDesign DeserializeLength(Stream stream, int length, AIDesign instance, bool isDelta) { }

	// RVA: 0x20061D0 Offset: 0x20055D0 VA: 0x1820061D0
	public static void SerializeDelta(Stream stream, AIDesign instance, AIDesign previous) { }

	// RVA: 0x20067A0 Offset: 0x2005BA0 VA: 0x1820067A0
	public static void Serialize(Stream stream, AIDesign instance) { }

	// RVA: 0x2006B30 Offset: 0x2005F30 VA: 0x182006B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x2006B40 Offset: 0x2005F40 VA: 0x182006B40
	public void ToProto(Stream stream) { }

	// RVA: 0x2006690 Offset: 0x2005A90 VA: 0x182006690
	public static byte[] SerializeToBytes(AIDesign instance) { }

	// RVA: 0x20065E0 Offset: 0x20059E0 VA: 0x1820065E0
	public static void SerializeLengthDelimited(Stream stream, AIDesign instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AIStateContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6541
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int id; // 0x14
	public int state; // 0x18
	public List<AIEventData> events; // 0x20
	public int inputMemorySlot; // 0x28

	// Methods

	// RVA: 0x200C9C0 Offset: 0x200BDC0 VA: 0x18200C9C0
	public static void ResetToPool(AIStateContainer instance) { }

	// RVA: 0x200C7D0 Offset: 0x200BBD0 VA: 0x18200C7D0
	public void ResetToPool() { }

	// RVA: 0x200C710 Offset: 0x200BB10 VA: 0x18200C710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200B130 Offset: 0x200A530 VA: 0x18200B130
	public void CopyTo(AIStateContainer instance) { }

	// RVA: 0x200B2E0 Offset: 0x200A6E0 VA: 0x18200B2E0
	public AIStateContainer Copy() { }

	// RVA: 0x200BCF0 Offset: 0x200B0F0 VA: 0x18200BCF0
	public static AIStateContainer Deserialize(Stream stream) { }

	// RVA: 0x200B4D0 Offset: 0x200A8D0 VA: 0x18200B4D0
	public static AIStateContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200B8F0 Offset: 0x200ACF0 VA: 0x18200B8F0
	public static AIStateContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200C0D0 Offset: 0x200B4D0 VA: 0x18200C0D0
	public static AIStateContainer Deserialize(byte[] buffer) { }

	// RVA: 0x200C790 Offset: 0x200BB90 VA: 0x18200C790
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200D320 Offset: 0x200C720 VA: 0x18200D320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200D340 Offset: 0x200C740 VA: 0x18200D340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIStateContainer previous) { }

	// RVA: 0x200C7B0 Offset: 0x200BBB0 VA: 0x18200C7B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200BFD0 Offset: 0x200B3D0 VA: 0x18200BFD0
	public static AIStateContainer Deserialize(byte[] buffer, AIStateContainer instance, bool isDelta = False) { }

	// RVA: 0x200C450 Offset: 0x200B850 VA: 0x18200C450
	public static AIStateContainer Deserialize(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x200B550 Offset: 0x200A950 VA: 0x18200B550
	public static AIStateContainer DeserializeLengthDelimited(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x200B980 Offset: 0x200AD80 VA: 0x18200B980
	public static AIStateContainer DeserializeLength(Stream stream, int length, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x200CBB0 Offset: 0x200BFB0 VA: 0x18200CBB0
	public static void SerializeDelta(Stream stream, AIStateContainer instance, AIStateContainer previous) { }

	// RVA: 0x200D070 Offset: 0x200C470 VA: 0x18200D070
	public static void Serialize(Stream stream, AIStateContainer instance) { }

	// RVA: 0x200D310 Offset: 0x200C710 VA: 0x18200D310
	public byte[] ToProtoBytes() { }

	// RVA: 0x200D320 Offset: 0x200C720 VA: 0x18200D320
	public void ToProto(Stream stream) { }

	// RVA: 0x200CF60 Offset: 0x200C360 VA: 0x18200CF60
	public static byte[] SerializeToBytes(AIStateContainer instance) { }

	// RVA: 0x200CEB0 Offset: 0x200C2B0 VA: 0x18200CEB0
	public static void SerializeLengthDelimited(Stream stream, AIStateContainer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6542
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int eventType; // 0x14
	public int triggerStateContainer; // 0x18
	public bool inverted; // 0x1C
	public int inputMemorySlot; // 0x20
	public int outputMemorySlot; // 0x24
	public int id; // 0x28
	public TimerAIEventData timerData; // 0x30
	public PlayerDetectedAIEventData playerDetectedData; // 0x38
	public HealthBelowAIEventData healthBelowData; // 0x40
	public InRangeAIEventData inRangeData; // 0x48
	public HungerAboveAIEventData hungerAboveData; // 0x50
	public TirednessAboveAIEventData tirednessAboveData; // 0x58
	public ThreatDetectedAIEventData threatDetectedData; // 0x60
	public TargetDetectedAIEventData targetDetectedData; // 0x68
	public AmmoBelowAIEventData ammoBelowData; // 0x70
	public ChanceAIEventData chanceData; // 0x78
	public TimeSinceThreatAIEventData timeSinceThreatData; // 0x80
	public AggressionTimerAIEventData aggressionTimerData; // 0x88
	public InRangeOfHomeAIEventData inRangeOfHomeData; // 0x90

	// Methods

	// RVA: 0x2008AB0 Offset: 0x2007EB0 VA: 0x182008AB0
	public static void ResetToPool(AIEventData instance) { }

	// RVA: 0x2008E70 Offset: 0x2008270 VA: 0x182008E70
	public void ResetToPool() { }

	// RVA: 0x20089F0 Offset: 0x2007DF0 VA: 0x1820089F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2006B80 Offset: 0x2005F80 VA: 0x182006B80
	public void CopyTo(AIEventData instance) { }

	// RVA: 0x2006FA0 Offset: 0x20063A0 VA: 0x182006FA0
	public AIEventData Copy() { }

	// RVA: 0x2008070 Offset: 0x2007470 VA: 0x182008070
	public static AIEventData Deserialize(Stream stream) { }

	// RVA: 0x20077D0 Offset: 0x2006BD0 VA: 0x1820077D0
	public static AIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2007FE0 Offset: 0x20073E0 VA: 0x182007FE0
	public static AIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20087D0 Offset: 0x2007BD0 VA: 0x1820087D0
	public static AIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2008A70 Offset: 0x2007E70 VA: 0x182008A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200B0F0 Offset: 0x200A4F0 VA: 0x18200B0F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200B110 Offset: 0x200A510 VA: 0x18200B110 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIEventData previous) { }

	// RVA: 0x2008A90 Offset: 0x2007E90 VA: 0x182008A90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20088F0 Offset: 0x2007CF0 VA: 0x1820088F0
	public static AIEventData Deserialize(byte[] buffer, AIEventData instance, bool isDelta = False) { }

	// RVA: 0x20080F0 Offset: 0x20074F0 VA: 0x1820080F0
	public static AIEventData Deserialize(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x2007020 Offset: 0x2006420 VA: 0x182007020
	public static AIEventData DeserializeLengthDelimited(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x2007850 Offset: 0x2006C50 VA: 0x182007850
	public static AIEventData DeserializeLength(Stream stream, int length, AIEventData instance, bool isDelta) { }

	// RVA: 0x2009230 Offset: 0x2008630 VA: 0x182009230
	public static void SerializeDelta(Stream stream, AIEventData instance, AIEventData previous) { }

	// RVA: 0x200A300 Offset: 0x2009700 VA: 0x18200A300
	public static void Serialize(Stream stream, AIEventData instance) { }

	// RVA: 0x200B0E0 Offset: 0x200A4E0 VA: 0x18200B0E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x200B0F0 Offset: 0x200A4F0 VA: 0x18200B0F0
	public void ToProto(Stream stream) { }

	// RVA: 0x200A1F0 Offset: 0x20095F0 VA: 0x18200A1F0
	public static byte[] SerializeToBytes(AIEventData instance) { }

	// RVA: 0x200A140 Offset: 0x2009540 VA: 0x18200A140
	public static void SerializeLengthDelimited(Stream stream, AIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class NPCTalking : NPCShopKeeper, IConversationProvider // TypeDefIndex: 8425
{	// Fields
	private Option __menuOption_Menu_Talk; // 0x7F0
	public ConversationData[] conversations; // 0x848
	public NPCTalking.NPCConversationResultAction[] conversationResultActions; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7C2670 Offset: 0x7C1A70 VA: 0x1807C2670 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7C35E0 Offset: 0x7C29E0 VA: 0x1807C35E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7C29A0 Offset: 0x7C1DA0 VA: 0x1807C29A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7C2440 Offset: 0x7C1840 VA: 0x1807C2440
	public int GetConversationIndex(string conversationName) { }

	// RVA: 0x7C2500 Offset: 0x7C1900 VA: 0x1807C2500 Slot: 158
	public virtual string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0x7C25B0 Offset: 0x7C19B0 VA: 0x1807C25B0
	public ConversationData GetConversation(string conversationName) { }

	// RVA: 0x7C2570 Offset: 0x7C1970 VA: 0x1807C2570
	public ConversationData GetConversation(int index) { }

	// RVA: 0x7C2400 Offset: 0x7C1800 VA: 0x1807C2400 Slot: 159
	public virtual ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0 Slot: 157
	public bool ProviderBusy() { }

	[BaseEntity.Menu] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.Description] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.Icon] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	// RVA: 0x7C2950 Offset: 0x7C1D50 VA: 0x1807C2950
	public void Menu_Talk(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	// RVA: 0x7C2360 Offset: 0x7C1760 VA: 0x1807C2360 Slot: 155
	public void DoAction(string action) { }

	// RVA: 0x7C2530 Offset: 0x7C1930 VA: 0x1807C2530 Slot: 156
	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7C22B0 Offset: 0x7C16B0 VA: 0x1807C22B0
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C23B0 Offset: 0x7C17B0 VA: 0x1807C23B0 Slot: 154
	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7C21E0 Offset: 0x7C15E0 VA: 0x1807C21E0
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C3510 Offset: 0x7C2910 VA: 0x1807C3510 Slot: 153
	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7C21D0 Offset: 0x7C15D0 VA: 0x1807C21D0
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C1E30 Offset: 0x7C1230 VA: 0x1807C1E30
	public void .ctor() { }

}

public class NPCTalking.NPCConversationResultAction // TypeDefIndex: 8426
{	// Fields
	public string action; // 0x10
	public int scrapCost; // 0x18
	public string broadcastMessage; // 0x20
	public float broadcastRange; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class NPCVendingOrder : ScriptableObject // TypeDefIndex: 8722
{	// Fields
	public NPCVendingOrder.Entry[] orders; // 0x18

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class NPCVendingOrder.Entry // TypeDefIndex: 8723
{	// Fields
	public ItemDefinition sellItem; // 0x10
	public int sellItemAmount; // 0x18
	public bool sellItemAsBP; // 0x1C
	public ItemDefinition currencyItem; // 0x20
	public int currencyAmount; // 0x28
	public bool currencyAsBP; // 0x2C
	[TooltipAttribute] // RVA: 0x77710 Offset: 0x76B10 VA: 0x180077710
	public int weight; // 0x30
	public int refillAmount; // 0x34
	public float refillDelay; // 0x38

	// Methods

	// RVA: 0x7B3460 Offset: 0x7B2860 VA: 0x1807B3460
	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{	// Fields
	public NPCVendingOrder[] orderList; // 0x18

	// Methods

	// RVA: 0x7C3710 Offset: 0x7C2B10 VA: 0x1807C3710
	public int GetIndex(NPCVendingOrder sample) { }

	// RVA: 0x7C36D0 Offset: 0x7C2AD0 VA: 0x1807C36D0
	public NPCVendingOrder GetFromIndex(int index) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class NPCVendingMachine : VendingMachine // TypeDefIndex: 8725
{	// Fields
	public NPCVendingOrder vendingOrders; // 0x5C8

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 156
	public override bool ShouldShowAdminPanel() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 158
	protected override bool CanRotate() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 159
	public override bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x7C3670 Offset: 0x7C2A70 VA: 0x1807C3670
	public void .ctor() { }

}

public class NPCDwelling : BaseEntity // TypeDefIndex: 8821
{	// Fields
	public NPCSpawner npcSpawner; // 0x168
	public float NPCSpawnChance; // 0x170
	public SpawnGroup[] spawnGroups; // 0x178
	public AIMovePoint[] movePoints; // 0x180
	public AICoverPoint[] coverPoints; // 0x188

	// Methods

	// RVA: 0x7C1A10 Offset: 0x7C0E10 VA: 0x1807C1A10
	public void .ctor() { }

}

public class NPCMissionProvider : NPCTalking, IMissionProvider // TypeDefIndex: 8849
{	// Fields
	public MissionManifest manifest; // 0x858

	// Methods

	// RVA: 0x548730 Offset: 0x547B30 VA: 0x180548730 Slot: 160
	public uint ProviderID() { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0 Slot: 161
	public Vector3 ProviderPosition() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 162
	public BaseEntity Entity() { }

	// RVA: 0x7C1E30 Offset: 0x7C1230 VA: 0x1807C1E30
	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{	// Fields
	public EntityRef invisibleVendingMachineRef; // 0x7D8
	public InvisibleVendingMachine machine; // 0x7E8

	// Methods

	// RVA: 0x7C1F90 Offset: 0x7C1390 VA: 0x1807C1F90
	public InvisibleVendingMachine GetVendingMachine() { }

	// RVA: 0x7C2030 Offset: 0x7C1430 VA: 0x1807C2030
	public void OnDrawGizmos() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 152
	public override void UpdateProtectionFromClothing() { }

	// RVA: 0x7C1E30 Offset: 0x7C1230 VA: 0x1807C1E30
	public void .ctor() { }

}

public class NPCPlayerCorpse : PlayerCorpse // TypeDefIndex: 8867
{	// Methods

	// RVA: 0x7C1F20 Offset: 0x7C1320 VA: 0x1807C1F20
	public void .ctor() { }

}

public class AICoverPoint : AIPoint // TypeDefIndex: 8903
{	// Fields
	public float coverDot; // 0x20

	// Methods

	// RVA: 0xA8C310 Offset: 0xA8B710 VA: 0x180A8C310
	public void OnDrawGizmos() { }

	// RVA: 0xA8C960 Offset: 0xA8BD60 VA: 0x180A8C960
	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{	// Methods

	[ContextMenu] // RVA: 0xC1E00 Offset: 0xC1200 VA: 0x1800C1E00
	// RVA: 0xA8B8C0 Offset: 0xA8ACC0 VA: 0x180A8B8C0
	public void PlaceCoverPoints() { }

	// RVA: 0xA8BFF0 Offset: 0xA8B3F0 VA: 0x180A8BFF0
	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	// RVA: 0xA8BC80 Offset: 0xA8B080 VA: 0x180A8BC80
	private void PlacePoint(AICoverPointTool.TestResult result) { }

	// RVA: 0xA8BEC0 Offset: 0xA8B2C0 VA: 0x180A8BEC0
	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	// RVA: 0xA8B6F0 Offset: 0xA8AAF0 VA: 0x180A8B6F0
	public bool HitsCover(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private struct AICoverPointTool.TestResult // TypeDefIndex: 8905
{	// Fields
	public Vector3 Position; // 0x0
	public bool Valid; // 0xC
	public bool Forward; // 0xD
	public bool Right; // 0xE
	public bool Backward; // 0xF
	public bool Left; // 0x10

}

public class AIInformationCell // TypeDefIndex: 8906
{	// Fields
	public Bounds BoundingBox; // 0x10
	public List<AIInformationCell> NeighbourCells; // 0x28
	public AIInformationCellContents<AIMovePoint> MovePoints; // 0x30
	public AIInformationCellContents<AICoverPoint> CoverPoints; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <X>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Z>k__BackingField; // 0x44

	// Properties
	public int X { get; }
	public int Z { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_Z() { }

	// RVA: 0xA8E2F0 Offset: 0xA8D6F0 VA: 0x180A8E2F0
	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	// RVA: 0xA8DED0 Offset: 0xA8D2D0 VA: 0x180A8DED0
	public void DebugDraw(Color color, bool points, float scale = 1) { }

}

public class AIInformationCellContents<T> // TypeDefIndex: 8907
{	// Fields
	public HashSet<T> Items; // 0x0

	// Properties
	public int Count { get; }
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55390 Offset: 0xD54790 VA: 0x180D55390
	|-AIInformationCellContents<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3850 Offset: 0x15D2C50 VA: 0x1815D3850
	|-AIInformationCellContents<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3650 Offset: 0x15D2A50 VA: 0x1815D3650
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3620 Offset: 0x15D2A20 VA: 0x1815D3620
	|-AIInformationCellContents<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D35F0 Offset: 0x15D29F0 VA: 0x1815D35F0
	|-AIInformationCellContents<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D37A0 Offset: 0x15D2BA0 VA: 0x1815D37A0
	|-AIInformationCellContents<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D37D0 Offset: 0x15D2BD0 VA: 0x1815D37D0
	|-AIInformationCellContents<AICoverPoint>..ctor
	|-AIInformationCellContents<AIMovePoint>..ctor
	|-AIInformationCellContents<object>..ctor
	*/

}

public class AIInformationGrid : MonoBehaviour // TypeDefIndex: 8908
{	// Fields
	public int CellSize; // 0x18
	public Bounds BoundingBox; // 0x1C
	public AIInformationCell[] Cells; // 0x38
	private Vector3 origin; // 0x40
	private int xCellCount; // 0x4C
	private int zCellCount; // 0x50
	private const int maxPointResults = 2048;
	private AIMovePoint[] movePointResults; // 0x58
	private AICoverPoint[] coverPointResults; // 0x60
	private const int maxCellResults = 512;
	private AIInformationCell[] resultCells; // 0x68

	// Methods

	[ContextMenu] // RVA: 0xC35F0 Offset: 0xC29F0 VA: 0x1800C35F0
	// RVA: 0xA8EFD0 Offset: 0xA8E3D0 VA: 0x180A8EFD0
	public void Init() { }

	// RVA: 0xA8ED10 Offset: 0xA8E110 VA: 0x180A8ED10
	private int GetIndex(int x, int z) { }

	// RVA: 0xA8E640 Offset: 0xA8DA40 VA: 0x180A8E640
	public AIInformationCell CellAt(int x, int z) { }

	// RVA: 0xA8ED20 Offset: 0xA8E120 VA: 0x180A8ED20
	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA8EA60 Offset: 0xA8DE60 VA: 0x180A8EA60
	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA8E850 Offset: 0xA8DC50 VA: 0x180A8E850
	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount) { }

	// RVA: 0xA8E730 Offset: 0xA8DB30 VA: 0x180A8E730
	public AIInformationCell GetCell(Vector3 position) { }

	// RVA: 0xA8E680 Offset: 0xA8DA80 VA: 0x180A8E680
	public void OnDrawGizmos() { }

	// RVA: 0xA8E680 Offset: 0xA8DA80 VA: 0x180A8E680
	public void DebugDraw() { }

	// RVA: 0xA8F5D0 Offset: 0xA8E9D0 VA: 0x180A8F5D0
	public void .ctor() { }

}

public class AIInformationGridTester : MonoBehaviour // TypeDefIndex: 8909
{	// Fields
	public AIInformationGrid Grid; // 0x18
	public float Range; // 0x20

	// Methods

	// RVA: 0xA8E470 Offset: 0xA8D870 VA: 0x180A8E470
	public void OnDrawGizmos() { }

	// RVA: 0x4C4CC0 Offset: 0x4C40C0 VA: 0x1804C4CC0
	public void .ctor() { }

}

public class AIInformationZone : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8910
{	// Fields
	public bool ShouldSleepAI; // 0x18
	public bool Virtual; // 0x19
	public bool UseCalculatedCoverDistances; // 0x1A
	public static List<AIInformationZone> zones; // 0x0
	public List<AICoverPoint> coverPoints; // 0x20
	public List<AIMovePoint> movePoints; // 0x28
	private AICoverPoint[] coverPointArray; // 0x30
	private AIMovePoint[] movePointArray; // 0x38
	public List<NavMeshLink> navMeshLinks; // 0x40
	public List<AIMovePointPath> paths; // 0x48
	public Bounds bounds; // 0x50
	private AIInformationGrid grid; // 0x68

	// Methods

	// RVA: 0xA8F6D0 Offset: 0xA8EAD0 VA: 0x180A8F6D0
	public void .ctor() { }

	// RVA: 0xA8F670 Offset: 0xA8EA70 VA: 0x180A8F670
	private static void .cctor() { }

}

public class AIMovePoint : AIPoint // TypeDefIndex: 8911
{	// Fields
	public ListDictionary<AIMovePoint, float> distances; // 0x20
	public ListDictionary<AICoverPoint, float> distancesToCover; // 0x28
	public float radius; // 0x30
	public float WaitTime; // 0x34
	public List<Transform> LookAtPoints; // 0x38

	// Methods

	// RVA: 0xA906D0 Offset: 0xA8FAD0 VA: 0x180A906D0
	public void OnDrawGizmos() { }

	// RVA: 0xA903A0 Offset: 0xA8F7A0 VA: 0x180A903A0
	public void DrawLookAtPoints() { }

	// RVA: 0xA90380 Offset: 0xA8F780 VA: 0x180A90380
	public void Clear() { }

	// RVA: 0xA902E0 Offset: 0xA8F6E0 VA: 0x180A902E0
	public void AddLookAtPoint(Transform transform) { }

	// RVA: 0xA90690 Offset: 0xA8FA90 VA: 0x180A90690
	public bool HasLookAtPoints() { }

	// RVA: 0xA90620 Offset: 0xA8FA20 VA: 0x180A90620
	public Transform GetRandomLookAtPoint() { }

	// RVA: 0xA90780 Offset: 0xA8FB80 VA: 0x180A90780
	public void .ctor() { }

}

public class AIMovePoint.DistTo // TypeDefIndex: 8912
{	// Fields
	public float distance; // 0x10
	public AIMovePoint target; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class AIMovePointPath : MonoBehaviour // TypeDefIndex: 8913
{	// Fields
	public Color DebugPathColor; // 0x18
	public AIMovePointPath.Mode LoopMode; // 0x28
	public List<AIMovePoint> Points; // 0x30

	// Methods

	// RVA: 0xA8F9B0 Offset: 0xA8EDB0 VA: 0x180A8F9B0
	public void Clear() { }

	// RVA: 0xA8F950 Offset: 0xA8ED50 VA: 0x180A8F950
	public void AddPoint(AIMovePoint point) { }

	// RVA: 0xA8FC20 Offset: 0xA8F020 VA: 0x180A8FC20
	public AIMovePoint FindNearestPoint(Vector3 position) { }

	// RVA: 0xA8FA00 Offset: 0xA8EE00 VA: 0x180A8FA00
	public int FindNearestPointIndex(Vector3 position) { }

	// RVA: 0xA8FD80 Offset: 0xA8F180 VA: 0x180A8FD80
	public AIMovePoint GetPointAtIndex(int index) { }

	// RVA: 0xA8FCB0 Offset: 0xA8F0B0 VA: 0x180A8FCB0
	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	// RVA: 0xA8FEF0 Offset: 0xA8F2F0 VA: 0x180A8FEF0
	private void OnDrawGizmos() { }

	// RVA: 0xA8FDF0 Offset: 0xA8F1F0 VA: 0x180A8FDF0
	private void OnDrawGizmosSelected() { }

	[ContextMenu] // RVA: 0xC3690 Offset: 0xC2A90 VA: 0x1800C3690
	// RVA: 0xA8F8B0 Offset: 0xA8ECB0 VA: 0x180A8F8B0
	public void AddChildPoints() { }

	// RVA: 0xA90260 Offset: 0xA8F660 VA: 0x180A90260
	public void .ctor() { }

}

public enum AIMovePointPath.Mode // TypeDefIndex: 8914
{	// Fields
	public int value__; // 0x0
	public const AIMovePointPath.Mode Loop = 0;
	public const AIMovePointPath.Mode Reverse = 1;

}

public enum AIMovePointPath.PathDirection // TypeDefIndex: 8915
{	// Fields
	public int value__; // 0x0
	public const AIMovePointPath.PathDirection Forwards = 0;
	public const AIMovePointPath.PathDirection Backwards = 1;

}

public class AIPoint : BaseMonoBehaviour // TypeDefIndex: 8916
{	// Fields
	private BaseEntity currentUser; // 0x18

	// Methods

	// RVA: 0xA909B0 Offset: 0xA8FDB0 VA: 0x180A909B0
	public bool InUse() { }

	// RVA: 0xA90A10 Offset: 0xA8FE10 VA: 0x180A90A10
	public bool IsUsedBy(BaseEntity user) { }

	// RVA: 0xA90820 Offset: 0xA8FC20 VA: 0x180A90820
	public bool CanBeUsedBy(BaseEntity user) { }

	// RVA: 0xA90B10 Offset: 0xA8FF10 VA: 0x180A90B10
	public void SetUsedBy(BaseEntity user, float duration = 5) { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void SetUsedBy(BaseEntity user) { }

	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0
	public void ClearUsed() { }

	// RVA: 0xA90920 Offset: 0xA8FD20 VA: 0x180A90920
	public void ClearIfUsedBy(BaseEntity user) { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public class AITraversalArea : TriggerBase // TypeDefIndex: 8917
{	// Fields
	public Transform entryPoint1; // 0x30
	public Transform entryPoint2; // 0x38
	public AITraversalWaitPoint[] waitPoints; // 0x40
	public Bounds movementArea; // 0x48
	public Transform activeEntryPoint; // 0x60
	public float nextFreeTime; // 0x68

	// Methods

	// RVA: 0xA91C40 Offset: 0xA91040 VA: 0x180A91C40
	public void OnValidate() { }

	// RVA: 0xA91770 Offset: 0xA90B70 VA: 0x180A91770 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA90F90 Offset: 0xA90390 VA: 0x180A90F90
	public bool CanTraverse(BaseEntity ent) { }

	// RVA: 0xA90FF0 Offset: 0xA903F0 VA: 0x180A90FF0
	public Transform GetClosestEntry(Vector3 position) { }

	// RVA: 0xA91640 Offset: 0xA90A40 VA: 0x180A91640
	public Transform GetFarthestEntry(Vector3 position) { }

	// RVA: 0xA91CA0 Offset: 0xA910A0 VA: 0x180A91CA0
	public void SetBusyFor(float dur = 1) { }

	// RVA: 0xA90F90 Offset: 0xA90390 VA: 0x180A90F90
	public bool CanUse(Vector3 dirFrom) { }

	// RVA: 0xA91C20 Offset: 0xA91020 VA: 0x180A91C20 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA91120 Offset: 0xA90520 VA: 0x180A91120
	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos) { }

	// RVA: 0xA90FB0 Offset: 0xA903B0 VA: 0x180A90FB0
	public bool EntityFilter(BaseEntity ent) { }

	// RVA: 0xA91C30 Offset: 0xA91030 VA: 0x180A91C30 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA91870 Offset: 0xA90C70 VA: 0x180A91870
	public void OnDrawGizmos() { }

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

public class AITraversalWaitPoint : MonoBehaviour // TypeDefIndex: 8918
{	// Fields
	public float nextFreeTime; // 0x18

	// Methods

	// RVA: 0xA91CD0 Offset: 0xA910D0 VA: 0x180A91CD0
	public bool Occupied() { }

	// RVA: 0xA91CF0 Offset: 0xA910F0 VA: 0x180A91CF0
	public void Occupy(float dur = 1) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain<BaseAnimalNPC> // TypeDefIndex: 8919
{	// Methods

	// RVA: 0x826AD0 Offset: 0x825ED0 VA: 0x180826AD0
	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{	// Fields
	public SkinnedMeshRenderer[] bodyRenderers; // 0x98
	public SkinnedMeshRenderer[] hairRenderers; // 0xA0

	// Methods

	// RVA: 0x827150 Offset: 0x826550 VA: 0x180827150
	public void .ctor() { }

}

public class AIThinkManager : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8929
{	// Methods

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public class ScientistBrain : BaseAIBrain<HumanNPC> // TypeDefIndex: 8933
{	// Methods

	// RVA: 0x49DF00 Offset: 0x49D300 VA: 0x18049DF00
	public void .ctor() { }

}

public class ScientistNPC : HumanNPC, IAIMounted // TypeDefIndex: 8934
{	// Fields
	public GameObjectRef[] RadioChatterEffects; // 0x850
	public GameObjectRef[] DeathEffects; // 0x858
	public string deathStatName; // 0x860
	public Vector2 IdleChatterRepeatRange; // 0x868
	public ScientistNPC.RadioChatterType radioChatterType; // 0x870

	// Methods

	// RVA: 0x49DF40 Offset: 0x49D340 VA: 0x18049DF40
	public void .ctor() { }

}

public enum ScientistNPC.RadioChatterType // TypeDefIndex: 8935
{	// Fields
	public int value__; // 0x0
	public const ScientistNPC.RadioChatterType NONE = 0;
	public const ScientistNPC.RadioChatterType Idle = 1;
	public const ScientistNPC.RadioChatterType Alert = 2;

}

public class NPCPlayer : BasePlayer // TypeDefIndex: 8938
{	// Fields
	public AIInformationZone VirtualInfoZone; // 0x788
	public Vector3 finalDestination; // 0x790
	private float randomOffset; // 0x79C
	private Vector3 spawnPos; // 0x7A0
	public PlayerInventoryProperties[] loadouts; // 0x7B0
	public LayerMask movementMask; // 0x7B8
	public bool LegacyNavigation; // 0x7BC
	public NavMeshAgent NavAgent; // 0x7C0
	public float damageScale; // 0x7C8
	public float shortRange; // 0x7CC
	public float attackLengthMaxShortRangeScale; // 0x7D0

	// Properties
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x7C1E30 Offset: 0x7C1230 VA: 0x1807C1E30
	public void .ctor() { }

}

public class NPCNavigator : BaseNavigator // TypeDefIndex: 8953
{	// Methods

	// RVA: 0x7C1EC0 Offset: 0x7C12C0 VA: 0x1807C1EC0
	public void .ctor() { }

}

public class NPCPlayerNavigator : BaseNavigator // TypeDefIndex: 8954
{	// Methods

	// RVA: 0x7C1F30 Offset: 0x7C1330 VA: 0x1807C1F30
	public void .ctor() { }

}

public class NPCPlayerNavigatorTester : BaseMonoBehaviour // TypeDefIndex: 8955
{	// Fields
	public BasePathNode TargetNode; // 0x18
	private BasePathNode currentNode; // 0x20

	// Methods

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public enum AIState // TypeDefIndex: 8964
{	// Fields
	public int value__; // 0x0
	public const AIState None = 0;
	public const AIState Idle = 1;
	public const AIState Roam = 2;
	public const AIState Chase = 3;
	public const AIState Cover = 4;
	public const AIState Combat = 5;
	public const AIState Mounted = 6;
	public const AIState Exfil = 7;
	public const AIState Patrol = 8;
	public const AIState Orbit = 9;
	public const AIState Egress = 10;
	public const AIState Land = 11;
	public const AIState DropCrate = 12;
	public const AIState MoveTowards = 13;
	public const AIState Flee = 14;
	public const AIState Attack = 15;
	public const AIState Sleep = 16;
	public const AIState Reload = 17;
	public const AIState TakeCover = 18;
	public const AIState Dismounted = 19;
	public const AIState FollowPath = 20;
	public const AIState NavigateHome = 21;
	public const AIState CombatStationary = 22;
	public const AIState Cooldown = 23;
	public const AIState MoveToPoint = 24;

}

public enum AIThinkMode // TypeDefIndex: 8965
{	// Fields
	public int value__; // 0x0
	public const AIThinkMode FixedUpdate = 0;
	public const AIThinkMode Interval = 1;

}

public class AimConeUtil // TypeDefIndex: 8968
{	// Methods

	// RVA: 0xA9DE90 Offset: 0xA9D290 VA: 0x180A9DE90
	public static Vector3 GetModifiedAimConeDirection(float aimCone, Vector3 inputVec, bool anywhereInside = True) { }

	// RVA: 0xA9DDD0 Offset: 0xA9D1D0 VA: 0x180A9DDD0
	public static Quaternion GetAimConeQuat(float aimCone) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class AnimalSkin : MonoBehaviour, IClientComponent // TypeDefIndex: 9111
{	// Fields
	public SkinnedMeshRenderer[] animalMesh; // 0x18
	public AnimalMultiSkin[] animalSkins; // 0x20
	private Model model; // 0x28
	public bool dontRandomizeOnStart; // 0x30

	// Methods

	// RVA: 0x827390 Offset: 0x826790 VA: 0x180827390
	private void Start() { }

	// RVA: 0x827160 Offset: 0x826560 VA: 0x180827160
	public void ChangeSkin(int iSkin) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AnimalMultiSkin // TypeDefIndex: 9112
{	// Fields
	public Material[] multiSkin; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class AnimalAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9113
{	// Fields
	public BaseEntity Entity; // 0x18
	public BaseNpc Target; // 0x20
	public Animator Animator; // 0x28
	public MaterialEffect FootstepEffects; // 0x30
	public Transform[] Feet; // 0x38
	public SoundDefinition saddleMovementSoundDef; // 0x40
	public SoundDefinition saddleMovementSoundDefWood; // 0x48
	public SoundDefinition saddleMovementSoundDefRoadsign; // 0x50
	public AnimationCurve saddleMovementGainCurve; // 0x58
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public string BaseFolder; // 0x60
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float lastThinkTime; // 0x68
	private Vector3 previousPosition; // 0x6C
	private float previousRotationYaw; // 0x78
	private bool wasSleeping; // 0x7C

	// Methods

	// RVA: 0x8269A0 Offset: 0x825DA0 VA: 0x1808269A0
	private void Update() { }

	// RVA: 0x8268A0 Offset: 0x825CA0 VA: 0x1808268A0
	public bool ShouldPlayFootstep(AnimationEvent evt) { }

	// RVA: 0x8262B0 Offset: 0x8256B0 VA: 0x1808262B0
	private void FrontLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x826310 Offset: 0x825710 VA: 0x180826310
	private void FrontRightFootstep(AnimationEvent evt) { }

	// RVA: 0x825F90 Offset: 0x825390 VA: 0x180825F90
	private void BackLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x825FF0 Offset: 0x8253F0 VA: 0x180825FF0
	private void BackRightFootstep(AnimationEvent evt) { }

	// RVA: 0x826050 Offset: 0x825450 VA: 0x180826050
	private void Footstep(Transform tx) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void DoEffect(string effect) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void PlayEffect(string effect) { }

	// RVA: 0x8266B0 Offset: 0x825AB0 VA: 0x1808266B0
	public void PlaySound(string soundName) { }

	// RVA: 0x826660 Offset: 0x825A60 VA: 0x180826660
	public void PlaySoundDef(SoundDefinition def) { }

	// RVA: 0x826370 Offset: 0x825770 VA: 0x180826370
	private void PlaySaddleMovementSound() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AnimalFootIK : MonoBehaviour // TypeDefIndex: 9115
{	// Fields
	public Transform[] Feet; // 0x18
	public Animator animator; // 0x20
	public float maxWeightDistance; // 0x28
	public float minWeightDistance; // 0x2C
	public float actualFootOffset; // 0x30

	// Methods

	// RVA: 0x826B40 Offset: 0x825F40 VA: 0x180826B40
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Start() { }

	// RVA: 0x826B10 Offset: 0x825F10 VA: 0x180826B10
	public AvatarIKGoal GoalFromIndex(int index) { }

	// RVA: 0x826C70 Offset: 0x826070 VA: 0x180826C70
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x827130 Offset: 0x826530 VA: 0x180827130
	public void .ctor() { }

}

public class NPCFootstepEffects : BaseFootstepEffect // TypeDefIndex: 9354
{	// Fields
	public string impactEffectDirectory; // 0x30
	public Transform frontLeftFoot; // 0x38
	public Transform frontRightFoot; // 0x40
	public Transform backLeftFoot; // 0x48
	public Transform backRightFoot; // 0x50

	// Methods

	// RVA: 0x7C1CB0 Offset: 0x7C10B0 VA: 0x1807C1CB0
	private void FrontLeftFootstep() { }

	// RVA: 0x7C1D00 Offset: 0x7C1100 VA: 0x1807C1D00
	private void FrontRightFootstep() { }

	// RVA: 0x7C1A70 Offset: 0x7C0E70 VA: 0x1807C1A70
	private void BackLeftFootstep() { }

	// RVA: 0x7C1AC0 Offset: 0x7C0EC0 VA: 0x1807C1AC0
	private void BackRightFootstep() { }

	// RVA: 0x7C1B10 Offset: 0x7C0F10 VA: 0x1807C1B10
	private void Footstep(Vector3 vFootPos) { }

	// RVA: 0x7C1D50 Offset: 0x7C1150 VA: 0x1807C1D50
	private void SetupFootstep(GameObject effect) { }

	// RVA: 0x7C1DE0 Offset: 0x7C11E0 VA: 0x1807C1DE0
	public void .ctor() { }

}

public class AIBrainSenses // TypeDefIndex: 9376
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class AIDesignSO : BaseScriptableObject // TypeDefIndex: 9377
{	// Fields
	public string Filename; // 0x20

	// Methods

	// RVA: 0x6A7040 Offset: 0x6A6440 VA: 0x1806A7040
	public void .ctor() { }

}

public class AIDesign // TypeDefIndex: 9378
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIDesignScope <Scope>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Description>k__BackingField; // 0x18
	public List<AIState> AvailableStates; // 0x20
	public int DefaultStateContainerID; // 0x28
	private Dictionary<int, AIStateContainer> stateContainers; // 0x30

	// Properties
	public AIDesignScope Scope { get; set; }
	public string Description { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public AIDesignScope get_Scope() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Description(string value) { }

	// RVA: 0xA8CC80 Offset: 0xA8C080 VA: 0x180A8CC80
	public void SetAvailableStates(List<AIState> states) { }

	// RVA: 0xA8CC20 Offset: 0xA8C020 VA: 0x180A8CC20
	public void Load(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA8CA70 Offset: 0xA8BE70 VA: 0x180A8CA70
	private void InitStateContainers(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA8C970 Offset: 0xA8BD70 VA: 0x180A8C970
	public AIStateContainer GetDefaultStateContainer() { }

	// RVA: 0xA8C9F0 Offset: 0xA8BDF0 VA: 0x180A8C9F0
	public AIStateContainer GetStateContainerByID(int id) { }

	// RVA: 0xA8CD10 Offset: 0xA8C110 VA: 0x180A8CD10
	public AIDesign ToProto(int currentStateID) { }

	// RVA: 0xA8D040 Offset: 0xA8C440 VA: 0x180A8D040
	public void .ctor() { }

}

public static class AIDesigns // TypeDefIndex: 9379
{	// Fields
	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; // 0x2B0AA98

	// Methods

	// RVA: 0xA8D0E0 Offset: 0xA8C4E0 VA: 0x180A8D0E0
	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	// RVA: 0xA8D3D0 Offset: 0xA8C7D0 VA: 0x180A8D3D0
	public static void RefreshCache(string designName, AIDesign design) { }

	// RVA: 0xA8D1A0 Offset: 0xA8C5A0 VA: 0x180A8D1A0
	private static AIDesign GetByName(string designName) { }

	// RVA: 0xA8D4A0 Offset: 0xA8C8A0 VA: 0x180A8D4A0
	private static void .cctor() { }

}

public enum AIEventType // TypeDefIndex: 9380
{	// Fields
	public int value__; // 0x0
	public const AIEventType Timer = 0;
	public const AIEventType PlayerDetected = 1;
	public const AIEventType StateError = 2;
	public const AIEventType Attacked = 3;
	public const AIEventType StateFinished = 4;
	public const AIEventType InAttackRange = 5;
	public const AIEventType HealthBelow = 6;
	public const AIEventType InRange = 7;
	public const AIEventType PerformedAttack = 8;
	public const AIEventType TirednessAbove = 9;
	public const AIEventType HungerAbove = 10;
	public const AIEventType ThreatDetected = 11;
	public const AIEventType TargetDetected = 12;
	public const AIEventType AmmoBelow = 13;
	public const AIEventType BestTargetDetected = 14;
	public const AIEventType IsVisible = 15;
	public const AIEventType AttackTick = 16;
	public const AIEventType IsMounted = 17;
	public const AIEventType And = 18;
	public const AIEventType Chance = 19;
	public const AIEventType TargetLost = 20;
	public const AIEventType TimeSinceThreat = 21;
	public const AIEventType OnPositionMemorySet = 22;
	public const AIEventType AggressionTimer = 23;
	public const AIEventType Reloading = 24;
	public const AIEventType InRangeOfHome = 25;

}

public class AIEvents // TypeDefIndex: 9381
{	// Fields
	public AIMemory Memory; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CurrentInputMemorySlot>k__BackingField; // 0x18
	private List<BaseAIEvent> events; // 0x20
	private IAIEventListener eventListener; // 0x28
	private AIBrainSenses senses; // 0x30
	private int currentEventIndex; // 0x38
	private bool inBlock; // 0x3C

	// Properties
	public int CurrentInputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	private void set_CurrentInputMemorySlot(int value) { }

	// RVA: 0xA8D8F0 Offset: 0xA8CCF0 VA: 0x180A8D8F0
	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses) { }

	// RVA: 0xA8D9E0 Offset: 0xA8CDE0 VA: 0x180A8D9E0
	private void RemoveAll() { }

	// RVA: 0xA8D500 Offset: 0xA8C900 VA: 0x180A8D500
	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner) { }

	// RVA: 0xA8D700 Offset: 0xA8CB00 VA: 0x180A8D700
	private void Add(BaseAIEvent aiEvent) { }

	// RVA: 0xA8DA30 Offset: 0xA8CE30 VA: 0x180A8DA30
	public void Tick(float deltaTime, StateStatus stateStatus) { }

	// RVA: 0xA8D800 Offset: 0xA8CC00 VA: 0x180A8D800
	private int FindNextEventBlock() { }

	// RVA: 0xA8DCF0 Offset: 0xA8D0F0 VA: 0x180A8DCF0
	public void .ctor() { }

}

public class AIMemory // TypeDefIndex: 9382
{	// Fields
	public AIMemoryBank<BaseEntity> Entity; // 0x10
	public AIMemoryBank<Vector3> Position; // 0x18
	public AIMemoryBank<AIPoint> AIPoint; // 0x20

	// Methods

	// RVA: 0xA8F7D0 Offset: 0xA8EBD0 VA: 0x180A8F7D0
	public void .ctor() { }

}

public class AIMemoryBank<T> // TypeDefIndex: 9387
{	// Fields
	private MemoryBankType type; // 0x0
	private T[] slots; // 0x0
	private float[] slotSetTimestamps; // 0x0
	private int slotCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3D10 Offset: 0x15D3110 VA: 0x1815D3D10
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D39C0 Offset: 0x15D2DC0 VA: 0x1815D39C0
	|-AIMemoryBank<object>.Init
	|
	|-RVA: 0x15D3A70 Offset: 0x15D2E70 VA: 0x1815D3A70
	|-AIMemoryBank<Vector3>.Init
	*/

	// RVA: -1 Offset: -1
	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3BE0 Offset: 0x15D2FE0 VA: 0x1815D3BE0
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-RVA: 0x15D3C70 Offset: 0x15D3070 VA: 0x1815D3C70
	|-AIMemoryBank<Vector3>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D38F0 Offset: 0x15D2CF0 VA: 0x1815D38F0
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-RVA: 0x15D3940 Offset: 0x15D2D40 VA: 0x1815D3940
	|-AIMemoryBank<Vector3>.Get
	*/

	// RVA: -1 Offset: -1
	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3880 Offset: 0x15D2C80 VA: 0x1815D3880
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	// RVA: -1 Offset: -1
	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3B20 Offset: 0x15D2F20 VA: 0x1815D3B20
	|-AIMemoryBank<object>.Remove
	|
	|-RVA: 0x15D3B80 Offset: 0x15D2F80 VA: 0x1815D3B80
	|-AIMemoryBank<Vector3>.Remove
	*/

}

public class AIStateContainer // TypeDefIndex: 9421
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIState <State>k__BackingField; // 0x14
	public List<BaseAIEvent> Events; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <InputMemorySlot>k__BackingField; // 0x20

	// Properties
	public int ID { get; set; }
	public AIState State { get; set; }
	public int InputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public AIState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	private void set_InputMemorySlot(int value) { }

	// RVA: 0xA90BD0 Offset: 0xA8FFD0 VA: 0x180A90BD0
	public void Init(AIStateContainer container, BaseEntity owner) { }

	// RVA: 0xA90DC0 Offset: 0xA901C0 VA: 0x180A90DC0
	public AIStateContainer ToProto() { }

	// RVA: 0xA90F80 Offset: 0xA90380 VA: 0x180A90F80
	public void .ctor() { }

}

public enum AIDesignScope // TypeDefIndex: 9424
{	// Fields
	public int value__; // 0x0
	public const AIDesignScope Default = 0;
	public const AIDesignScope EntityServerWide = 1;
	public const AIDesignScope EntityInstance = 2;

}

public class NPCAutoTurret : AutoTurret // TypeDefIndex: 9576
{	// Fields
	public Transform centerMuzzle; // 0x768
	public Transform muzzleLeft; // 0x770
	public Transform muzzleRight; // 0x778
	private bool useLeftMuzzle; // 0x780

	// Methods

	// RVA: 0x7C1A00 Offset: 0x7C0E00 VA: 0x1807C1A00
	public void .ctor() { }

}

public class AIHelicopterAnimation : MonoBehaviour // TypeDefIndex: 9597
{	// Fields
	public PatrolHelicopterAI _ai; // 0x18
	public float swayAmount; // 0x20
	public float lastStrafeScalar; // 0x24
	public float lastForwardBackScalar; // 0x28
	public float degreeMax; // 0x2C
	public Vector3 lastPosition; // 0x30
	public float oldMoveSpeed; // 0x3C
	public float smoothRateOfChange; // 0x40
	public float flareAmount; // 0x44

	// Methods

	// RVA: 0xA8DE50 Offset: 0xA8D250 VA: 0x180A8DE50
	public void .ctor() { }

}

public class NPCSpawner : SpawnGroup // TypeDefIndex: 10003
{	// Fields
	public int AdditionalLOSBlockingLayer; // 0x48
	public MonumentNavMesh monumentNavMesh; // 0x50
	public bool shouldFillOnSpawn; // 0x58
	[HeaderAttribute] // RVA: 0xACFD0 Offset: 0xAC3D0 VA: 0x1800ACFD0
	public AIInformationZone VirtualInfoZone; // 0x60
	[HeaderAttribute] // RVA: 0xAE350 Offset: 0xAD750 VA: 0x1800AE350
	public AIMovePointPath Path; // 0x68
	public BasePath AStarGraph; // 0x70
	[HeaderAttribute] // RVA: 0xAE7A0 Offset: 0xADBA0 VA: 0x1800AE7A0
	public bool UseStatModifiers; // 0x78
	public float SenseRange; // 0x7C
	public float TargetLostRange; // 0x80
	public float AttackRangeMultiplier; // 0x84
	public float ListenRange; // 0x88
	public float CanUseHealingItemsChance; // 0x8C
	[HeaderAttribute] // RVA: 0xAFC00 Offset: 0xAF000 VA: 0x1800AFC00
	public PlayerInventoryProperties[] Loadouts; // 0x90

	// Methods

	// RVA: 0x7C21A0 Offset: 0x7C15A0 VA: 0x1807C21A0
	public void .ctor() { }

}

public class AI : ConsoleSystem // TypeDefIndex: 11876
{	// Fields
	[ReplicatedVar] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	public static bool allowdesigning; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool designing; // 0x1
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool groundAlign; // 0x2
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float maxGroundAlignDist; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugVis; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool npc_no_foot_ik; // 0x9
	private static HitTest lookingAtNpcCache; // 0x10

	// Methods

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6C7080 Offset: 0x6C6480 VA: 0x1806C7080
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6C6EC0 Offset: 0x6C62C0 VA: 0x1806C6EC0
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6C6AE0 Offset: 0x6C5EE0 VA: 0x1806C6AE0
	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x6C6E60 Offset: 0x6C6260 VA: 0x1806C6E60
	public void .ctor() { }

	// RVA: 0x6C6DC0 Offset: 0x6C61C0 VA: 0x1806C6DC0
	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12129
{	// Fields
	[TooltipAttribute] // RVA: 0xDFF10 Offset: 0xDF310 VA: 0x1800DFF10
	public int AgentTypeIndex; // 0x18

	// Methods

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class AiManager : SingletonComponent<AiManager>, IServerComponent // TypeDefIndex: 12130
{	// Fields
	[HeaderAttribute] // RVA: 0xE0140 Offset: 0xDF540 VA: 0x1800E0140
	[SerializeField] // RVA: 0xE0140 Offset: 0xDF540 VA: 0x1800E0140
	public bool UseCover; // 0x18
	public float CoverPointVolumeCellSize; // 0x1C
	public float CoverPointVolumeCellHeight; // 0x20
	public float CoverPointRayLength; // 0x24
	public CoverPointVolume cpvPrefab; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public LayerMask DynamicCoverPointVolumeLayerMask; // 0x30
	private WorldSpaceGrid<CoverPointVolume> coverPointVolumeGrid; // 0x38

	// Methods

	// RVA: 0x4B7EC0 Offset: 0x4B72C0 VA: 0x1804B7EC0
	internal void OnEnableCover() { }

	// RVA: 0x4B7DE0 Offset: 0x4B71E0 VA: 0x1804B7DE0
	internal void OnDisableCover() { }

	// RVA: 0x4B7D50 Offset: 0x4B7150 VA: 0x1804B7D50
	public CoverPointVolume GetCoverVolumeContaining(Vector3 point) { }

	// RVA: 0x4B7F80 Offset: 0x4B7380 VA: 0x1804B7F80
	public void .ctor() { }

}

public class ScientistSpawner : SpawnGroup // TypeDefIndex: 12132
{	// Fields
	[HeaderAttribute] // RVA: 0xE0350 Offset: 0xDF750 VA: 0x1800E0350
	public bool Mobile; // 0x48
	public bool NeverMove; // 0x49
	public bool SpawnHostile; // 0x4A
	public bool OnlyAggroMarkedTargets; // 0x4B
	public bool IsPeacekeeper; // 0x4C
	public bool IsBandit; // 0x4D
	public bool IsMilitaryTunnelLab; // 0x4E
	public WaypointSet Waypoints; // 0x50
	public Transform[] LookAtInterestPointsStationary; // 0x58
	public Vector2 RadioEffectRepeatRange; // 0x60
	public Model Model; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AiLocationManager _mgr; // 0x70

	// Methods

	// RVA: 0x4C57D0 Offset: 0x4C4BD0 VA: 0x1804C57D0
	public void .ctor() { }

}

public class AiLocationManager : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{	// Fields
	public static List<AiLocationManager> Managers; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AiLocationSpawner MainSpawner; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AiLocationSpawner.SquadSpawnerLocation LocationWhenMainSpawnerIsNull; // 0x20
	public Transform CoverPointGroup; // 0x28
	public Transform PatrolPointGroup; // 0x30
	public CoverPointVolume DynamicCoverPointVolume; // 0x38
	public bool SnapCoverPointsToGround; // 0x40

	// Properties
	public AiLocationSpawner.SquadSpawnerLocation LocationType { get; }

	// Methods

	// RVA: 0x4B7C90 Offset: 0x4B7090 VA: 0x1804B7C90
	public AiLocationSpawner.SquadSpawnerLocation get_LocationType() { }

	// RVA: 0x4B7C80 Offset: 0x4B7080 VA: 0x1804B7C80
	public void .ctor() { }

	// RVA: 0x4B7C20 Offset: 0x4B7020 VA: 0x1804B7C20
	private static void .cctor() { }

}

public class AiLocationSpawner : SpawnGroup // TypeDefIndex: 12134
{	// Fields
	public AiLocationSpawner.SquadSpawnerLocation Location; // 0x48
	public AiLocationManager Manager; // 0x50
	public JunkPile Junkpile; // 0x58
	public bool IsMainSpawner; // 0x60
	public float chance; // 0x64
	private int defaultMaxPopulation; // 0x68
	private int defaultNumToSpawnPerTickMax; // 0x6C
	private int defaultNumToSpawnPerTickMin; // 0x70

	// Methods

	// RVA: 0x4B7D20 Offset: 0x4B7120 VA: 0x1804B7D20
	public void .ctor() { }

}

public enum AiLocationSpawner.SquadSpawnerLocation // TypeDefIndex: 12135
{	// Fields
	public int value__; // 0x0
	public const AiLocationSpawner.SquadSpawnerLocation MilitaryTunnels = 0;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileA = 1;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileG = 2;
	public const AiLocationSpawner.SquadSpawnerLocation CH47 = 3;
	public const AiLocationSpawner.SquadSpawnerLocation None = 4;
	public const AiLocationSpawner.SquadSpawnerLocation Compound = 5;
	public const AiLocationSpawner.SquadSpawnerLocation BanditTown = 6;
	public const AiLocationSpawner.SquadSpawnerLocation CargoShip = 7;

}

public class ScientistJunkpileSpawner : MonoBehaviour, IServerComponent // TypeDefIndex: 12139
{	// Fields
	public GameObjectRef ScientistPrefab; // 0x18
	public List<BaseCombatEntity> Spawned; // 0x20
	public BaseSpawnPoint[] SpawnPoints; // 0x28
	public int MaxPopulation; // 0x30
	public bool InitialSpawn; // 0x34
	public float MinRespawnTimeMinutes; // 0x38
	public float MaxRespawnTimeMinutes; // 0x3C
	public float MovementRadius; // 0x40
	public bool ReducedLongRangeAccuracy; // 0x44
	public ScientistJunkpileSpawner.JunkpileType SpawnType; // 0x48
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float SpawnBaseChance; // 0x4C

	// Methods

	// RVA: 0x4C5740 Offset: 0x4C4B40 VA: 0x1804C5740
	public void .ctor() { }

}

public enum ScientistJunkpileSpawner.JunkpileType // TypeDefIndex: 12140
{	// Fields
	public int value__; // 0x0
	public const ScientistJunkpileSpawner.JunkpileType A = 0;
	public const ScientistJunkpileSpawner.JunkpileType B = 1;
	public const ScientistJunkpileSpawner.JunkpileType C = 2;
	public const ScientistJunkpileSpawner.JunkpileType D = 3;
	public const ScientistJunkpileSpawner.JunkpileType E = 4;
	public const ScientistJunkpileSpawner.JunkpileType F = 5;
	public const ScientistJunkpileSpawner.JunkpileType G = 6;

}

