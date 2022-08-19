public class GrowableEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6325
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float age; // 0x18
	public int water; // 0x1C
	public float healthy; // 0x20
	public float totalAge; // 0x24
	public float growthAge; // 0x28
	public float yieldFraction; // 0x2C
	public float stageAge; // 0x30
	public int genes; // 0x34
	public float lightModifier; // 0x38
	public float waterModifier; // 0x3C
	public float groundModifier; // 0x40
	public float happiness; // 0x44
	public float temperatureModifier; // 0x48
	public float waterConsumption; // 0x4C
	public float yieldPool; // 0x50
	public bool fertilized; // 0x54
	public int previousGenes; // 0x58

	// Methods

	// RVA: 0x1D5C5A0 Offset: 0x1D5B9A0 VA: 0x181D5C5A0
	public static void ResetToPool(GrowableEntity instance) { }

	// RVA: 0x1D5C410 Offset: 0x1D5B810 VA: 0x181D5C410
	public void ResetToPool() { }

	// RVA: 0x1D5C1C0 Offset: 0x1D5B5C0 VA: 0x181D5C1C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5A920 Offset: 0x1D59D20 VA: 0x181D5A920
	public void CopyTo(GrowableEntity instance) { }

	// RVA: 0x1D5A9B0 Offset: 0x1D59DB0 VA: 0x181D5A9B0
	public GrowableEntity Copy() { }

	// RVA: 0x1D5C140 Offset: 0x1D5B540 VA: 0x181D5C140
	public static GrowableEntity Deserialize(Stream stream) { }

	// RVA: 0x1D5B160 Offset: 0x1D5A560 VA: 0x181D5B160
	public static GrowableEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5B890 Offset: 0x1D5AC90 VA: 0x181D5B890
	public static GrowableEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5BA20 Offset: 0x1D5AE20 VA: 0x181D5BA20
	public static GrowableEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D5C3D0 Offset: 0x1D5B7D0 VA: 0x181D5C3D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5D3F0 Offset: 0x1D5C7F0 VA: 0x181D5D3F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5D410 Offset: 0x1D5C810 VA: 0x181D5D410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GrowableEntity previous) { }

	// RVA: 0x1D5C3F0 Offset: 0x1D5B7F0 VA: 0x181D5C3F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5B920 Offset: 0x1D5AD20 VA: 0x181D5B920
	public static GrowableEntity Deserialize(byte[] buffer, GrowableEntity instance, bool isDelta = False) { }

	// RVA: 0x1D5BB40 Offset: 0x1D5AF40 VA: 0x181D5BB40
	public static GrowableEntity Deserialize(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D5AA90 Offset: 0x1D59E90 VA: 0x181D5AA90
	public static GrowableEntity DeserializeLengthDelimited(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D5B1E0 Offset: 0x1D5A5E0 VA: 0x181D5B1E0
	public static GrowableEntity DeserializeLength(Stream stream, int length, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D5C730 Offset: 0x1D5BB30 VA: 0x181D5C730
	public static void SerializeDelta(Stream stream, GrowableEntity instance, GrowableEntity previous) { }

	// RVA: 0x1D5D050 Offset: 0x1D5C450 VA: 0x181D5D050
	public static void Serialize(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1D5D3E0 Offset: 0x1D5C7E0 VA: 0x181D5D3E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5D3F0 Offset: 0x1D5C7F0 VA: 0x181D5D3F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5CF40 Offset: 0x1D5C340 VA: 0x181D5CF40
	public static byte[] SerializeToBytes(GrowableEntity instance) { }

	// RVA: 0x1D5CE90 Offset: 0x1D5C290 VA: 0x181D5CE90
	public static void SerializeLengthDelimited(Stream stream, GrowableEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class GrowableEntity : BaseCombatEntity, IInstanceDataReceiver // TypeDefIndex: 8395
{	// Fields
	private Option __menuOption_MenuClone; // 0x240
	private Option __menuOption_MenuPick; // 0x298
	private Option __menuOption_MenuRemove; // 0x2F0
	private TimeSince qualityUpdate; // 0x348
	private DeferredAction skinChange; // 0x350
	private GameObject skin; // 0x358
	private PlantSkin skinComponent; // 0x360
	private MaterialColorLerp materialColorLerp; // 0x368
	private float client_healthScale; // 0x370
	public PlantProperties Properties; // 0x378
	public ItemDefinition SourceItemDef; // 0x380
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PlantProperties.State <State>k__BackingField; // 0x388
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Age>k__BackingField; // 0x38C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <LightQuality>k__BackingField; // 0x390
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <GroundQuality>k__BackingField; // 0x394
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <WaterQuality>k__BackingField; // 0x398
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <WaterConsumption>k__BackingField; // 0x39C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Fertilized>k__BackingField; // 0x3A0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <TemperatureQuality>k__BackingField; // 0x3A4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <OverallQuality>k__BackingField; // 0x3A8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Yield>k__BackingField; // 0x3AC
	private float stageAge; // 0x3B0
	public GrowableGenes Genes; // 0x3B8
	private const float startingHealth = 10;

	// Properties
	public override bool HasMenuOptions { get; }
	public PlantProperties.State State { get; set; }
	public float Age { get; set; }
	public float LightQuality { get; set; }
	public float GroundQuality { get; set; }
	public float WaterQuality { get; set; }
	public float WaterConsumption { get; set; }
	public bool Fertilized { get; set; }
	public float TemperatureQuality { get; set; }
	public float OverallQuality { get; set; }
	public float Yield { get; set; }
	public float StageProgressFraction { get; }
	private PlantProperties.Stage currentStage { get; }
	public static float ThinkDeltaTime { get; }
	private float growDeltaTime { get; }
	public int CurrentPickAmount { get; }
	public float CurrentPickAmountFloat { get; }

	// Methods

	// RVA: 0x747990 Offset: 0x746D90 VA: 0x180747990 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7497E0 Offset: 0x748BE0 VA: 0x1807497E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7487C0 Offset: 0x747BC0 VA: 0x1807487C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 73
	public override bool AlwaysShowCrosshair() { }

	// RVA: 0x7478C0 Offset: 0x746CC0 VA: 0x1807478C0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1260 Offset: 0xE0660 VA: 0x1800E1260
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1260 Offset: 0xE0660 VA: 0x1800E1260
	// RVA: 0x748740 Offset: 0x747B40 VA: 0x180748740
	public void MenuPick(BasePlayer ply) { }

	// RVA: 0x748580 Offset: 0x747980 VA: 0x180748580
	public bool MenuCanPick(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1440 Offset: 0xE0840 VA: 0x1800E1440
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1440 Offset: 0xE0840 VA: 0x1800E1440
	// RVA: 0x748700 Offset: 0x747B00 VA: 0x180748700
	public void MenuClone(BasePlayer ply) { }

	// RVA: 0x748570 Offset: 0x747970 VA: 0x180748570
	public bool MenuCanClone(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE15F0 Offset: 0xE09F0 VA: 0x1800E15F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE15F0 Offset: 0xE09F0 VA: 0x1800E15F0
	// RVA: 0x748780 Offset: 0x747B80 VA: 0x180748780
	public void MenuRemove(BasePlayer ply) { }

	// RVA: 0x748680 Offset: 0x747A80 VA: 0x180748680
	public bool MenuCanRemove(BasePlayer player) { }

	// RVA: 0x748500 Offset: 0x747900 VA: 0x180748500 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x748C90 Offset: 0x748090 VA: 0x180748C90
	private void RPC_ReceiveQualityUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x747500 Offset: 0x746900 VA: 0x180747500
	private void ChangeSkin() { }

	// RVA: 0x7477F0 Offset: 0x746BF0 VA: 0x1807477F0
	private void DestroySkin() { }

	// RVA: 0x748DB0 Offset: 0x7481B0 VA: 0x180748DB0
	private void SpawnSkin() { }

	// RVA: 0x749040 Offset: 0x748440 VA: 0x180749040
	private void UpdateSkinParameters() { }

	// RVA: 0x748D00 Offset: 0x748100 VA: 0x180748D00
	private void RefreshRenderers() { }

	// RVA: 0x7478D0 Offset: 0x746CD0 VA: 0x1807478D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x748C70 Offset: 0x748070 VA: 0x180748C70 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7478F0 Offset: 0x746CF0 VA: 0x1807478F0
	public MaterialColorLerp GetMaterialColorLerp() { }

	// RVA: 0x748F40 Offset: 0x748340 VA: 0x180748F40
	public void UpdateHealthVisual() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749A50 Offset: 0x748E50 VA: 0x180749A50
	public PlantProperties.State get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C30 Offset: 0x749030 VA: 0x180749C30
	private void set_State(PlantProperties.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749680 Offset: 0x748A80 VA: 0x180749680
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749BE0 Offset: 0x748FE0 VA: 0x180749BE0
	private void set_Age(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7499A0 Offset: 0x748DA0 VA: 0x1807499A0
	public float get_LightQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C10 Offset: 0x749010 VA: 0x180749C10
	private void set_LightQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7497D0 Offset: 0x748BD0 VA: 0x1807497D0
	public float get_GroundQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C00 Offset: 0x749000 VA: 0x180749C00
	private void set_GroundQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749AE0 Offset: 0x748EE0 VA: 0x180749AE0
	public float get_WaterQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C60 Offset: 0x749060 VA: 0x180749C60
	private void set_WaterQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749AD0 Offset: 0x748ED0 VA: 0x180749AD0
	public float get_WaterConsumption() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C50 Offset: 0x749050 VA: 0x180749C50
	private void set_WaterConsumption(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7497C0 Offset: 0x748BC0 VA: 0x1807497C0
	public bool get_Fertilized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749BF0 Offset: 0x748FF0 VA: 0x180749BF0
	private void set_Fertilized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749A60 Offset: 0x748E60 VA: 0x180749A60
	public float get_TemperatureQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C40 Offset: 0x749040 VA: 0x180749C40
	private void set_TemperatureQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7499B0 Offset: 0x748DB0 VA: 0x1807499B0
	public float get_OverallQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C20 Offset: 0x749020 VA: 0x180749C20
	private void set_OverallQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749AF0 Offset: 0x748EF0 VA: 0x180749AF0
	public float get_Yield() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x749C70 Offset: 0x749070 VA: 0x180749C70
	private void set_Yield(float value) { }

	// RVA: 0x7499C0 Offset: 0x748DC0 VA: 0x1807499C0
	public float get_StageProgressFraction() { }

	// RVA: 0x749B00 Offset: 0x748F00 VA: 0x180749B00
	private PlantProperties.Stage get_currentStage() { }

	// RVA: 0x749A70 Offset: 0x748E70 VA: 0x180749A70
	public static float get_ThinkDeltaTime() { }

	// RVA: 0x749B70 Offset: 0x748F70 VA: 0x180749B70
	private float get_growDeltaTime() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 145
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0x748D90 Offset: 0x748190 VA: 0x180748D90 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7473F0 Offset: 0x7467F0 VA: 0x1807473F0
	public bool CanPick() { }

	// RVA: 0x749700 Offset: 0x748B00 VA: 0x180749700
	public int get_CurrentPickAmount() { }

	// RVA: 0x749690 Offset: 0x748A90 VA: 0x180749690
	public float get_CurrentPickAmountFloat() { }

	// RVA: 0x747450 Offset: 0x746850 VA: 0x180747450
	public bool CanTakeSeeds() { }

	// RVA: 0x747340 Offset: 0x746740 VA: 0x180747340
	public bool CanClone() { }

	// RVA: 0x748110 Offset: 0x747510 VA: 0x180748110 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7476A0 Offset: 0x746AA0 VA: 0x1807476A0
	private void ChangeState(PlantProperties.State state, bool resetAge, bool loading = False) { }

	// RVA: 0x749520 Offset: 0x748920 VA: 0x180749520
	public void .ctor() { }

}

