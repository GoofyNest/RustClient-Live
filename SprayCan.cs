public class SprayCan : HeldEntity // TypeDefIndex: 10350
{
	public const float MaxFreeSprayDistanceFromStart = 10;
	public const float MaxFreeSprayStartingDistance = 3;
	private SprayCanSpray_Freehand paintingLine; 
	public const BaseEntity.Flags IsFreeSpraying = 128;
	private bool isSpraying; 
	private bool spawnedLine; 
	private Vector3 sprayStartPos; 
	private Vector3 lastPos; 
	private int colourIndex; 
	private int widthIndex; 
	private BaseEntity sprayingEntity; 
	private List<AlignedLineDrawer.LinePoint> points; 
	private TimeSince sprayStarted; 
	private TimeSince sprayEnded; 
	private static Translate.Phrase[] ColourNamePhrases; 
	private static Translate.Phrase[] ColourDescriptionPhrases; 
	private static Translate.Phrase[] SpraySizePhrases; 
	public SoundDefinition SpraySound; 
	public GameObjectRef SkinSelectPanel; 
	public float SprayCooldown; 
	public float ConditionLossPerSpray; 
	public float ConditionLossPerReskin; 
	public GameObjectRef LinePrefab; 
	public Color[] SprayColours; 
	public float[] SprayWidths; 
	public ParticleSystem worldSpaceSprayFx; 
	public GameObjectRef ReskinEffect; 
	public ItemDefinition SprayDecalItem; 
	public GameObjectRef SprayDecalEntityRef; 
	public SteamInventoryItem FreeSprayUnlockItem; 
	public ParticleSystem.MinMaxGradient DecalSprayGradient; 
	public SoundDefinition SprayLoopDef; 
	public static Translate.Phrase FreeSprayNamePhrase; 
	public static Translate.Phrase FreeSprayDescPhrase; 
	[CompilerGeneratedAttribute] 
	private SprayCan.SprayMode <currentMode>k__BackingField; 
	private int selectedDecalSkin; 
	[ClientVar] 
	public static bool UseAccurateMeshSnapping; 
	[ClientVar] 
	public static bool DebugMeshSnapping; 
	private static int paramAttack; 
	private static int paramAttackHold; 
	private TimeSince timeDeployed; 
	private Sound sprayLoop; 

	private Color SelectedSprayColour { get; }
	public static bool HasOpenedColourWheel { get; set; }
	public static bool HasOpenedSizeWheel { get; set; }
	public SprayCan.SprayMode currentMode { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private Color get_SelectedSprayColour() { }

	private void FreePaintInput(BasePlayer player, bool sprayInput) { }

	private bool HasSprayDecalAttachment(BasePlayer player) { }

	private Ray SprayRay(BasePlayer player) { }

	private bool GetSprayPosition(BasePlayer player, out Vector3 pos, out Vector3 normal, out Vector3 upPos, out BaseEntity hitEntity, out Collider hitCollider) { }

	public void RegisterInProcessSpray(SprayCanSpray_Freehand spray, List<AlignedLineDrawer.LinePoint> setPoints) { }

	[BaseEntity.RPC_Client] 
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	public static bool get_HasOpenedColourWheel() { }

	private static void set_HasOpenedColourWheel(bool value) { }

	public static bool get_HasOpenedSizeWheel() { }

	private static void set_HasOpenedSizeWheel(bool value) { }

	private bool ShouldUseMeshSampling(Collider c) { }

	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	public bool CanSprayFreehand(BasePlayer player) { }

	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] 
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] 
	private void set_currentMode(SprayCan.SprayMode value) { }

	public override void OnInput() { }

	private void OpenReskinOptions(BasePlayer player) { }

	public bool CanOpenReskinMenu(BasePlayer player) { }

	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	private void PlayVMAttack() { }

	private void ToggleVMHold(bool state) { }

	private void SetVmSprayColour(Color c) { }

	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] 
	private void Client_ReskinResult(BaseEntity.RPCMessage msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public override void OnDeployed() { }

	public override bool NeedsCrosshair() { }

	private bool CanEntityBeRespawned(BaseEntity targetEntity, out SprayCan.SprayFailReason reason) { }

	public static bool GetItemDefinitionForEntity(BaseEntity be, out ItemDefinition def, bool useRedirect = True) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] 
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] 
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] 
	private void <OnInput>b__65_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] 
	private void <OnInput>b__65_1(BasePlayer ply) { }

}

private enum SprayCan.SprayFailReason // TypeDefIndex: 10351
{
	public int value__; 
	public const SprayCan.SprayFailReason None = 0;
	public const SprayCan.SprayFailReason MountedBlocked = 1;
	public const SprayCan.SprayFailReason IOConnection = 2;
	public const SprayCan.SprayFailReason LineOfSight = 3;
	public const SprayCan.SprayFailReason SkinNotOwned = 4;
	public const SprayCan.SprayFailReason InvalidItem = 5;

}

public enum SprayCan.SprayMode // TypeDefIndex: 10352
{
	public int value__; 
	public const SprayCan.SprayMode FreeHand = 0;
	public const SprayCan.SprayMode Decal = 1;

}

private sealed class SprayCan.<>c__DisplayClass20_0 // TypeDefIndex: 10353
{
	public int index; 
	public SprayCan <>4__this; 


	public void .ctor() { }

	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 10354
{
	public int index; 
	public SprayCan <>4__this; 


	public void .ctor() { }

	internal void <FreePaintInput>b__3(BasePlayer ply) { }

}

private struct SprayCan.<>c__DisplayClass33_0 // TypeDefIndex: 10355
{
	public SprayCan <>4__this; 
	public BasePlayer player; 
	public Vector3 point; 

}

private sealed class SprayCan.<>c__DisplayClass65_0 // TypeDefIndex: 10356
{
	public ItemSkinDirectory.Skin skin; 
	public SprayCan <>4__this; 


	public void .ctor() { }

	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass66_0 // TypeDefIndex: 10357
{
	public SprayCan <>4__this; 
	public BaseEntity targetEntity; 


	public void .ctor() { }

	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

