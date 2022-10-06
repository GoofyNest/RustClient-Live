public class GrowableEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6329
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int state; 
	public float age; 
	public int water; 
	public float healthy; 
	public float totalAge; 
	public float growthAge; 
	public float yieldFraction; 
	public float stageAge; 
	public int genes; 
	public float lightModifier; 
	public float waterModifier; 
	public float groundModifier; 
	public float happiness; 
	public float temperatureModifier; 
	public float waterConsumption; 
	public float yieldPool; 
	public bool fertilized; 
	public int previousGenes; 


	public static void ResetToPool(GrowableEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GrowableEntity instance) { }

	public GrowableEntity Copy() { }

	public static GrowableEntity Deserialize(Stream stream) { }

	public static GrowableEntity DeserializeLengthDelimited(Stream stream) { }

	public static GrowableEntity DeserializeLength(Stream stream, int length) { }

	public static GrowableEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GrowableEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GrowableEntity Deserialize(byte[] buffer, GrowableEntity instance, bool isDelta = False) { }

	public static GrowableEntity Deserialize(Stream stream, GrowableEntity instance, bool isDelta) { }

	public static GrowableEntity DeserializeLengthDelimited(Stream stream, GrowableEntity instance, bool isDelta) { }

	public static GrowableEntity DeserializeLength(Stream stream, int length, GrowableEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GrowableEntity instance, GrowableEntity previous) { }

	public static void Serialize(Stream stream, GrowableEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GrowableEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, GrowableEntity instance) { }

	public void .ctor() { }

}

public class GrowableEntity : BaseCombatEntity, IInstanceDataReceiver // TypeDefIndex: 10100
{
	private Option __menuOption_MenuClone; 
	private Option __menuOption_MenuPick; 
	private Option __menuOption_MenuRemove; 
	private TimeSince qualityUpdate; 
	private DeferredAction skinChange; 
	private GameObject skin; 
	private PlantSkin skinComponent; 
	private MaterialColorLerp materialColorLerp; 
	private float client_healthScale; 
	public PlantProperties Properties; 
	public ItemDefinition SourceItemDef; 
	[CompilerGeneratedAttribute] 
	private PlantProperties.State <State>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Age>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <LightQuality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <GroundQuality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <WaterQuality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <WaterConsumption>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Fertilized>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <TemperatureQuality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <OverallQuality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Yield>k__BackingField; 
	private float stageAge; 
	public GrowableGenes Genes; 
	private const float startingHealth = 10;

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


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool AlwaysShowCrosshair() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuPick(BasePlayer ply) { }

	public bool MenuCanPick(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuClone(BasePlayer ply) { }

	public bool MenuCanClone(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuRemove(BasePlayer ply) { }

	public bool MenuCanRemove(BasePlayer player) { }

	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] 
	private void RPC_ReceiveQualityUpdate(BaseEntity.RPCMessage msg) { }

	private void ChangeSkin() { }

	private void DestroySkin() { }

	private void SpawnSkin() { }

	private void UpdateSkinParameters() { }

	private void RefreshRenderers() { }

	protected override void DoClientDestroy() { }

	public override void PostNetworkUpdate() { }

	public MaterialColorLerp GetMaterialColorLerp() { }

	public void UpdateHealthVisual() { }

	[CompilerGeneratedAttribute] 
	public PlantProperties.State get_State() { }

	[CompilerGeneratedAttribute] 
	private void set_State(PlantProperties.State value) { }

	[CompilerGeneratedAttribute] 
	public float get_Age() { }

	[CompilerGeneratedAttribute] 
	private void set_Age(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_LightQuality() { }

	[CompilerGeneratedAttribute] 
	private void set_LightQuality(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_GroundQuality() { }

	[CompilerGeneratedAttribute] 
	private void set_GroundQuality(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_WaterQuality() { }

	[CompilerGeneratedAttribute] 
	private void set_WaterQuality(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_WaterConsumption() { }

	[CompilerGeneratedAttribute] 
	private void set_WaterConsumption(float value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Fertilized() { }

	[CompilerGeneratedAttribute] 
	private void set_Fertilized(bool value) { }

	[CompilerGeneratedAttribute] 
	public float get_TemperatureQuality() { }

	[CompilerGeneratedAttribute] 
	private void set_TemperatureQuality(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_OverallQuality() { }

	[CompilerGeneratedAttribute] 
	private void set_OverallQuality(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_Yield() { }

	[CompilerGeneratedAttribute] 
	private void set_Yield(float value) { }

	public float get_StageProgressFraction() { }

	private PlantProperties.Stage get_currentStage() { }

	public static float get_ThinkDeltaTime() { }

	private float get_growDeltaTime() { }

	public void ReceiveInstanceData(Item.InstanceData data) { }

	public override void ResetState() { }

	public bool CanPick() { }

	public int get_CurrentPickAmount() { }

	public float get_CurrentPickAmountFloat() { }

	public bool CanTakeSeeds() { }

	public bool CanClone() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void ChangeState(PlantProperties.State state, bool resetAge, bool loading = False) { }

	public void .ctor() { }

}

