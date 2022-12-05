public class Landmine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong triggeredID;


	public static void ResetToPool(Landmine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Landmine instance) { }

	public Landmine Copy() { }

	public static Landmine Deserialize(Stream stream) { }

	public static Landmine DeserializeLengthDelimited(Stream stream) { }

	public static Landmine DeserializeLength(Stream stream, int length) { }

	public static Landmine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Landmine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Landmine Deserialize(byte[] buffer, Landmine instance, bool isDelta = False) { }

	public static Landmine Deserialize(Stream stream, Landmine instance, bool isDelta) { }

	public static Landmine DeserializeLengthDelimited(Stream stream, Landmine instance, bool isDelta) { }

	public static Landmine DeserializeLength(Stream stream, int length, Landmine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Landmine instance, Landmine previous) { }

	public static void Serialize(Stream stream, Landmine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Landmine instance) { }

	public static void SerializeLengthDelimited(Stream stream, Landmine instance) { }

	public void .ctor() { }

}

public class BearTrap : BaseTrap // TypeDefIndex: 10084
{
	private Option __menuOption_Arm_Beartrap;
	protected Animator animator;
	private bool initialized;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool Armed() { }

	public override void InitShared() { }

	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Arm_Beartrap(BasePlayer player) { }

	public bool Menu_Arm_ShowIf(BasePlayer player) { }

	public override void ClientOnEnable() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

public class Landmine : BaseTrap // TypeDefIndex: 10123
{
	private Option __menuOption_Arm_Landmine;
	public GameObjectRef explosionEffect;
	public GameObjectRef triggeredEffect;
	public float minExplosionRadius;
	public float explosionRadius;
	public bool blocked;
	private ulong triggerPlayerID;
	public List<DamageTypeEntry> damageTypes;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool Triggered() { }

	public bool Armed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Arm_Landmine(BasePlayer player) { }

	public bool Menu_Disarm_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class GunTrap : StorageContainer // TypeDefIndex: 10296
{
	public GameObjectRef gun_fire_effect;
	public GameObjectRef bulletEffect;
	public GameObjectRef triggeredEffect;
	public Transform muzzlePos;
	public Transform eyeTransform;
	public int numPellets;
	public int aimCone;
	public float sensorRadius;
	public ItemDefinition ammoType;
	public TargetTrigger trigger;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override string Categorize() { }

	public bool IsTriggered() { }

	public Vector3 GetEyePosition() { }

	[BaseEntity.RPC_Client]
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

}

public static class GunTrap.GunTrapFlags // TypeDefIndex: 10297
{
	public const BaseEntity.Flags Triggered = 128;

}

public class BaseTrap : DecayEntity // TypeDefIndex: 11427
{

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void .ctor() { }

}

public class BaseTrapTrigger : TriggerBase // TypeDefIndex: 11428
{
	public BaseTrap _trap;


	public void .ctor() { }

}

public class BearTrapTrigger : BaseTrapTrigger // TypeDefIndex: 11429
{

	public void .ctor() { }

}

public class SurvivalFishTrap : WildlifeTrap // TypeDefIndex: 11430
{

	public override void TrappedEffect() { }

	public void .ctor() { }

}

public class TrappableWildlife : ScriptableObject // TypeDefIndex: 11431
{
	public GameObjectRef worldObject;
	public ItemDefinition inventoryObject;
	public int minToCatch;
	public int maxToCatch;
	public List<TrappableWildlife.BaitType> baitTypes;
	public int caloriesForInterest;
	public float successRate;
	public float xpScale;


	public void .ctor() { }

}

public class TrappableWildlife.BaitType // TypeDefIndex: 11432
{
	public float successRate;
	public ItemDefinition bait;
	public int minForInterest;
	public int maxToConsume;


	public void .ctor() { }

}

public class WildlifeTrap : StorageContainer // TypeDefIndex: 11433
{
	public float tickRate;
	public GameObjectRef trappedEffect;
	public float trappedEffectRepeatRate;
	public float trapSuccessRate;
	public List<ItemDefinition> ignoreBait;
	public List<WildlifeTrap.WildlifeWeight> targetWildlife;
	protected float nextEffectTime;


	public bool HasCatch() { }

	public bool IsTrapActive() { }

	public override void ResetState() { }

	public void Update() { }

	public virtual void TrappedEffect() { }

	public void .ctor() { }

}

public static class WildlifeTrap.WildlifeTrapFlags // TypeDefIndex: 11434
{
	public const BaseEntity.Flags Occupied = 128;

}

public class WildlifeTrap.WildlifeWeight // TypeDefIndex: 11435
{
	public TrappableWildlife wildlife;
	public int weight;


	public void .ctor() { }

}

public class Bootstrap : SingletonComponent<Bootstrap> // TypeDefIndex: 11564
{
	internal static bool bootstrapInitRun;
	public static bool isErrored;
	public string messageString;
	public CanvasGroup BootstrapUiCanvas;
	public GameObject errorPanel;
	public TextMeshProUGUI errorText;
	public TextMeshProUGUI statusText;
	private TimeSince timeSinceVisible;
	private static GameObject _engineUi;
	private static GameObject _gameUi;
	private static GameObject _menuUi;
	private static string lastWrittenValue;

	public static bool needsSetup { get; }
	public static bool isPresent { get; }


	public static bool get_needsSetup() { }

	public static bool get_isPresent() { }

	public static void RunDefaults() { }

	public static void Init_Tier0() { }

	public static void Init_Systems() { }

	public static void Init_Config() { }

	public static void NetworkInitRaknet() { }

	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay) { }

	[IteratorStateMachineAttribute]
	private IEnumerator Start() { }

	public static GameObject LoadEngineUI() { }

	public static GameObject LoadGameUI() { }

	public static GameObject LoadMenuUI() { }

	private static GameObject InstantiatePrefabPersistent(string path) { }

	public static void ToggleUIHack() { }

	public static void SetUIVisible(bool visible) { }

	[IteratorStateMachineAttribute]
	private IEnumerator ClientStartup() { }

	protected void Update() { }

	private void StartupShared() { }

	public void ThrowError(string error) { }

	public void ExitGame() { }

	[IteratorStateMachineAttribute]
	public static IEnumerator LoadingUpdate(string str) { }

	public static void WriteToLog(string str) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Bootstrap.<>c // TypeDefIndex: 11565
{
	public static readonly Bootstrap.<>c <>9;
	public static Func<string, GameObject> <>9__13_0;
	public static Action <>9__13_1;
	public static Func<bool> <>9__13_2;
	public static Func<int> <>9__14_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal GameObject <Init_Tier0>

	internal void <Init_Tier0>

	internal bool <Init_Tier0>

	internal int <Init_Systems>

}

private sealed class Bootstrap.<Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11566
{
	private int <>1__state;
	private object <>2__current;
	public Bootstrap <>4__this;
	private BenchmarkTimer <timer>5__2;
	private AssetBundleBackend <newBackend>5__3;
	private BenchmarkTimer <>7__wrap3;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<ClientStartup>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11567
{
	private int <>1__state;
	private object <>2__current;
	public Bootstrap <>4__this;
	private BenchmarkTimer <>7__wrap1;
	private AsyncOperation <op>5__3;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<LoadingUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11568
{
	private int <>1__state;
	private object <>2__current;
	public string str;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

