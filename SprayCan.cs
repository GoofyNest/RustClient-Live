public class SprayCan : HeldEntity // TypeDefIndex: 8641
{	public const float MaxFreeSprayDistanceFromStart = 10;
	public const float MaxFreeSprayStartingDistance = 3;
	private SprayCanSpray_Freehand paintingLine; // 0x1F8
	public const BaseEntity.Flags IsFreeSpraying = 128;
	private bool isSpraying; // 0x200
	private bool spawnedLine; // 0x201
	private Vector3 sprayStartPos; // 0x204
	private Vector3 lastPos; // 0x210
	private int colourIndex; // 0x21C
	private int widthIndex; // 0x220
	private BaseEntity sprayingEntity; // 0x228
	private List<AlignedLineDrawer.LinePoint> points; // 0x230
	private TimeSince sprayStarted; // 0x238
	private TimeSince sprayEnded; // 0x23C
	private static Translate.Phrase[] ColourNamePhrases; // 0x0
	private static Translate.Phrase[] ColourDescriptionPhrases; // 0x8
	private static Translate.Phrase[] SpraySizePhrases; // 0x10
	public SoundDefinition SpraySound; // 0x240
	public GameObjectRef SkinSelectPanel; // 0x248
	public float SprayCooldown; // 0x250
	public float ConditionLossPerSpray; // 0x254
	public float ConditionLossPerReskin; // 0x258
	public GameObjectRef LinePrefab; // 0x260
	public Color[] SprayColours; // 0x268
	public float[] SprayWidths; // 0x270
	public ParticleSystem worldSpaceSprayFx; // 0x278
	public GameObjectRef ReskinEffect; // 0x280
	public ItemDefinition SprayDecalItem; // 0x288
	public GameObjectRef SprayDecalEntityRef; // 0x290
	public SteamInventoryItem FreeSprayUnlockItem; // 0x298
	public ParticleSystem.MinMaxGradient DecalSprayGradient; // 0x2A0
	public SoundDefinition SprayLoopDef; // 0x2D8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SprayCan.SprayMode <currentMode>k__BackingField; // 0x2E0
	private int selectedDecalSkin; // 0x2E4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool UseAccurateMeshSnapping; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool DebugMeshSnapping; // 0x19
	private static int paramAttack; // 0x1C
	private static int paramAttackHold; // 0x20
	private TimeSince timeDeployed; // 0x2E8
	private Sound sprayLoop; // 0x2F0

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

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	public static bool get_HasOpenedColourWheel() { }

	private static void set_HasOpenedColourWheel(bool value) { }

	public static bool get_HasOpenedSizeWheel() { }

	private static void set_HasOpenedSizeWheel(bool value) { }

	private bool ShouldUseMeshSampling(Collider c) { }

	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	public bool CanSprayFreehand(BasePlayer player) { }

	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentMode(SprayCan.SprayMode value) { }

	public override void OnInput() { }

	private void OpenReskinOptions(BasePlayer player) { }

	public bool CanOpenReskinMenu(BasePlayer player) { }

	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	private void PlayVMAttack() { }

	private void ToggleVMHold(bool state) { }

	private void SetVmSprayColour(Color c) { }

	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__63_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__63_1(BasePlayer ply) { }

}

private enum SprayCan.SprayFailReason // TypeDefIndex: 8642
{	public int value__; // 0x0
	public const SprayCan.SprayFailReason None = 0;
	public const SprayCan.SprayFailReason MountedBlocked = 1;
	public const SprayCan.SprayFailReason IOConnection = 2;
	public const SprayCan.SprayFailReason LineOfSight = 3;
	public const SprayCan.SprayFailReason SkinNotOwned = 4;
	public const SprayCan.SprayFailReason InvalidItem = 5;

}

public enum SprayCan.SprayMode // TypeDefIndex: 8643
{	public int value__; // 0x0
	public const SprayCan.SprayMode FreeHand = 0;
	public const SprayCan.SprayMode Decal = 1;

}

private sealed class SprayCan.<>c__DisplayClass20_0 // TypeDefIndex: 8644
{	public int index; // 0x10
	public SprayCan <>4__this; // 0x18


	public void .ctor() { }

	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 8645
{	public int index; // 0x10
	public SprayCan <>4__this; // 0x18


	public void .ctor() { }

	internal void <FreePaintInput>b__3(BasePlayer ply) { }

}

private struct SprayCan.<>c__DisplayClass33_0 // TypeDefIndex: 8646
{	public SprayCan <>4__this; // 0x0
	public BasePlayer player; // 0x8
	public Vector3 point; // 0x10

}

private sealed class SprayCan.<>c__DisplayClass63_0 // TypeDefIndex: 8647
{	public ItemSkinDirectory.Skin skin; // 0x10
	public SprayCan <>4__this; // 0x30


	public void .ctor() { }

	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass64_0 // TypeDefIndex: 8648
{	public SprayCan <>4__this; // 0x10
	public BaseEntity targetEntity; // 0x18


	public void .ctor() { }

	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

