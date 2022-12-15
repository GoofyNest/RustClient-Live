public class WireTool : HeldEntity // TypeDefIndex: 10390
{
	public Sprite InputSprite;
	public Sprite OutputSprite;
	public Sprite ClearSprite;
	public static float maxWireLength;
	private const int maxLineNodes = 16;
	public GameObjectRef plugEffect;
	public GameObjectRef ioLine;
	public IOEntity.IOType wireType;
	public float RadialMenuHoldTime;
	public static Translate.Phrase Default;
	public static Translate.Phrase DefaultDesc;
	public static Translate.Phrase Red;
	public static Translate.Phrase RedDesc;
	public static Translate.Phrase Green;
	public static Translate.Phrase GreenDesc;
	public static Translate.Phrase Blue;
	public static Translate.Phrase BlueDesc;
	public static Translate.Phrase Yellow;
	public static Translate.Phrase YellowDesc;
	public static Translate.Phrase LightBlue;
	public static Translate.Phrase LightBlueDesc;
	public static Translate.Phrase Orange;
	public static Translate.Phrase OrangeDesc;
	public static Translate.Phrase Purple;
	public static Translate.Phrase PurpleDesc;
	public static Translate.Phrase White;
	public static Translate.Phrase WhiteDesc;
	public static Translate.Phrase Pink;
	public static Translate.Phrase PinkDesc;
	public WireTool.PendingPlug_t pending;
	private const float lineThickness = 0,02;
	private bool wantsCrosshair;
	private ClientIOLine pendingLine;
	private WireTool.WireColour currentColour;
	private float nextClearSendTime;
	private float nextColorChangeTime;
	private float remainingDist;
	private bool validSurface;
	private bool couldBuild;
	private bool isSolo;
	private float reloadDownTime;
	private float clearProgress;

	public bool CanChangeColours { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	public void AddClearConnections(List<Option> opts) { }

	public List<Option> GetIOOptions(IOEntity source) { }

	public bool get_CanChangeColours() { }

	public void ClearPendingPlug() { }

	public bool HasPendingPlug() { }

	public bool PendingPlugIsInput() { }

	public bool PendingPlugIsType(IOEntity.IOType type) { }

	public bool PendingPlugIsOutput() { }

	public Vector3 PendingPlugWorldPos() { }

	public static bool CanPlayerUseWires(BasePlayer player) { }

	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	public bool PendingPlugRoot() { }

	public bool HasPendingWire() { }

	public float GetPendingLengthRemaining() { }

	public int GetWireClicksRemaining() { }

	public bool ValidSurface() { }

	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	public void ClientRequestColorChange(IOEntity ent, int slot, bool input, WireTool.WireColour color) { }

	public IOEntity GetLookingAtIOEnt() { }

	public override void OnHolster() { }

	public override void OnDeploy() { }

	public bool WantsInputList() { }

	public bool WantsOutputList() { }

	public void ClearClicked() { }

	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	public void ClientAttemptConnection(bool input, int index) { }

	public void BeginLine(Vector3 startWorldPos) { }

	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	public void EndLine(bool destroy = False) { }

	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	public override bool NeedsCrosshair() { }

	public static void RefreshDirectionalVisibility() { }

	public override void OnInput() { }

	public float GetClearProgress() { }

	private void SetCurrentColour(WireTool.WireColour newColour) { }

	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private void <AddClearConnections>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

	[CompilerGeneratedAttribute]
	private void <OnInput>

}

public enum WireTool.WireColour // TypeDefIndex: 10391
{
	public int value__;
	public const WireTool.WireColour Default = 0;
	public const WireTool.WireColour Red = 1;
	public const WireTool.WireColour Green = 2;
	public const WireTool.WireColour Blue = 3;
	public const WireTool.WireColour Yellow = 4;
	public const WireTool.WireColour Pink = 5;
	public const WireTool.WireColour Purple = 6;
	public const WireTool.WireColour Orange = 7;
	public const WireTool.WireColour White = 8;
	public const WireTool.WireColour LightBlue = 9;
	public const WireTool.WireColour Count = 10;

}

public struct WireTool.PendingPlug_t // TypeDefIndex: 10392
{
	public IOEntity ent;
	public bool input;
	public int index;
	public GameObject tempLine;

}

private sealed class WireTool.<>c__DisplayClass4_0 // TypeDefIndex: 10393
{
	public WireTool <>4__this;
	public bool input;
	public int index;


	public void .ctor() { }

	internal void <AddIOOption>

}

private sealed class WireTool.<>c // TypeDefIndex: 10394
{
	public static readonly WireTool.<>c <>9;
	public static Func<Collider, bool> <>9__44_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CanPlayerUseWires>

}

