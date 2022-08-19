public class Landmine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6326
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong triggeredID; // 0x18

	// Methods

	// RVA: 0x1F18240 Offset: 0x1F17640 VA: 0x181F18240
	public static void ResetToPool(Landmine instance) { }

	// RVA: 0x1F182C0 Offset: 0x1F176C0 VA: 0x181F182C0
	public void ResetToPool() { }

	// RVA: 0x1F18110 Offset: 0x1F17510 VA: 0x181F18110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F17770 Offset: 0x1F16B70 VA: 0x181F17770
	public void CopyTo(Landmine instance) { }

	// RVA: 0x1F17790 Offset: 0x1F16B90 VA: 0x181F17790
	public Landmine Copy() { }

	// RVA: 0x1F17D30 Offset: 0x1F17130 VA: 0x181F17D30
	public static Landmine Deserialize(Stream stream) { }

	// RVA: 0x1F17A20 Offset: 0x1F16E20 VA: 0x181F17A20
	public static Landmine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F17AA0 Offset: 0x1F16EA0 VA: 0x181F17AA0
	public static Landmine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F17FF0 Offset: 0x1F173F0 VA: 0x181F17FF0
	public static Landmine Deserialize(byte[] buffer) { }

	// RVA: 0x1F18200 Offset: 0x1F17600 VA: 0x181F18200
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F18790 Offset: 0x1F17B90 VA: 0x181F18790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F18860 Offset: 0x1F17C60 VA: 0x181F18860 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Landmine previous) { }

	// RVA: 0x1F18220 Offset: 0x1F17620 VA: 0x181F18220 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F17EF0 Offset: 0x1F172F0 VA: 0x181F17EF0
	public static Landmine Deserialize(byte[] buffer, Landmine instance, bool isDelta = False) { }

	// RVA: 0x1F17DB0 Offset: 0x1F171B0 VA: 0x181F17DB0
	public static Landmine Deserialize(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F17800 Offset: 0x1F16C00 VA: 0x181F17800
	public static Landmine DeserializeLengthDelimited(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F17B30 Offset: 0x1F16F30 VA: 0x181F17B30
	public static Landmine DeserializeLength(Stream stream, int length, Landmine instance, bool isDelta) { }

	// RVA: 0x1F18340 Offset: 0x1F17740 VA: 0x181F18340
	public static void SerializeDelta(Stream stream, Landmine instance, Landmine previous) { }

	// RVA: 0x1F186B0 Offset: 0x1F17AB0 VA: 0x181F186B0
	public static void Serialize(Stream stream, Landmine instance) { }

	// RVA: 0x1F18780 Offset: 0x1F17B80 VA: 0x181F18780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F18790 Offset: 0x1F17B90 VA: 0x181F18790
	public void ToProto(Stream stream) { }

	// RVA: 0x1F18500 Offset: 0x1F17900 VA: 0x181F18500
	public static byte[] SerializeToBytes(Landmine instance) { }

	// RVA: 0x1F18450 Offset: 0x1F17850 VA: 0x181F18450
	public static void SerializeLengthDelimited(Stream stream, Landmine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BearTrap : BaseTrap // TypeDefIndex: 8362
{	// Fields
	private Option __menuOption_Arm_Beartrap; // 0x258
	protected Animator animator; // 0x2B0
	private bool initialized; // 0x2B8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5273E0 Offset: 0x5267E0 VA: 0x1805273E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x527910 Offset: 0x526D10 VA: 0x180527910 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x527810 Offset: 0x526C10 VA: 0x180527810 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool Armed() { }

	// RVA: 0x5276E0 Offset: 0x526AE0 VA: 0x1805276E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x5272C0 Offset: 0x5266C0 VA: 0x1805272C0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD6D0 Offset: 0xCCAD0 VA: 0x1800CD6D0
	[BaseEntity.Menu.Description] // RVA: 0xCD6D0 Offset: 0xCCAD0 VA: 0x1800CD6D0
	[BaseEntity.Menu.Icon] // RVA: 0xCD6D0 Offset: 0xCCAD0 VA: 0x1800CD6D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD6D0 Offset: 0xCCAD0 VA: 0x1800CD6D0
	// RVA: 0x527280 Offset: 0x526680 VA: 0x180527280
	public void Arm_Beartrap(BasePlayer player) { }

	// RVA: 0x5277F0 Offset: 0x526BF0 VA: 0x1805277F0
	public bool Menu_Arm_ShowIf(BasePlayer player) { }

	// RVA: 0x527320 Offset: 0x526720 VA: 0x180527320 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x527740 Offset: 0x526B40 VA: 0x180527740 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x527900 Offset: 0x526D00 VA: 0x180527900
	public void .ctor() { }

}

public class Landmine : BaseTrap // TypeDefIndex: 8402
{	// Fields
	private Option __menuOption_Arm_Landmine; // 0x258
	public GameObjectRef explosionEffect; // 0x2B0
	public GameObjectRef triggeredEffect; // 0x2B8
	public float minExplosionRadius; // 0x2C0
	public float explosionRadius; // 0x2C4
	public bool blocked; // 0x2C8
	private ulong triggerPlayerID; // 0x2D0
	public List<DamageTypeEntry> damageTypes; // 0x2D8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6BC150 Offset: 0x6BB550 VA: 0x1806BC150 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6BC7F0 Offset: 0x6BBBF0 VA: 0x1806BC7F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6BC680 Offset: 0x6BBA80 VA: 0x1806BC680 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6BC770 Offset: 0x6BBB70 VA: 0x1806BC770
	public bool Triggered() { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool Armed() { }

	// RVA: 0x6BC4A0 Offset: 0x6BB8A0 VA: 0x1806BC4A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xE9E20 Offset: 0xE9220 VA: 0x1800E9E20
	[BaseEntity.Menu.Description] // RVA: 0xE9E20 Offset: 0xE9220 VA: 0x1800E9E20
	[BaseEntity.Menu.Icon] // RVA: 0xE9E20 Offset: 0xE9220 VA: 0x1800E9E20
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9E20 Offset: 0xE9220 VA: 0x1800E9E20
	// RVA: 0x6BC110 Offset: 0x6BB510 VA: 0x1806BC110
	public void Arm_Landmine(BasePlayer player) { }

	// RVA: 0x6BC610 Offset: 0x6BBA10 VA: 0x1806BC610
	public bool Menu_Disarm_ShowIf(BasePlayer player) { }

	// RVA: 0x6BC780 Offset: 0x6BBB80 VA: 0x1806BC780
	public void .ctor() { }

}

public class GunTrap : StorageContainer // TypeDefIndex: 8572
{	// Fields
	public GameObjectRef gun_fire_effect; // 0x3D0
	public GameObjectRef bulletEffect; // 0x3D8
	public GameObjectRef triggeredEffect; // 0x3E0
	public Transform muzzlePos; // 0x3E8
	public Transform eyeTransform; // 0x3F0
	public int numPellets; // 0x3F8
	public int aimCone; // 0x3FC
	public float sensorRadius; // 0x400
	public ItemDefinition ammoType; // 0x408
	public TargetTrigger trigger; // 0x410

	// Methods

	// RVA: 0x74B380 Offset: 0x74A780 VA: 0x18074B380 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x74B310 Offset: 0x74A710 VA: 0x18074B310 Slot: 122
	public override string Categorize() { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsTriggered() { }

	// RVA: 0x74B340 Offset: 0x74A740 VA: 0x18074B340
	public Vector3 GetEyePosition() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x74AF80 Offset: 0x74A380 VA: 0x18074AF80
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x74B7D0 Offset: 0x74ABD0 VA: 0x18074B7D0
	public void .ctor() { }

}

public static class GunTrap.GunTrapFlags // TypeDefIndex: 8573
{	// Fields
	public const BaseEntity.Flags Triggered = 128;

}

public class BaseTrap : DecayEntity // TypeDefIndex: 9684
{	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x911490 Offset: 0x910890 VA: 0x180911490
	public void .ctor() { }

}

public class BaseTrapTrigger : TriggerBase // TypeDefIndex: 9685
{	// Fields
	public BaseTrap _trap; // 0x30

	// Methods

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

public class BearTrapTrigger : BaseTrapTrigger // TypeDefIndex: 9686
{	// Methods

	// RVA: 0x527270 Offset: 0x526670 VA: 0x180527270
	public void .ctor() { }

}

public class SurvivalFishTrap : WildlifeTrap // TypeDefIndex: 9687
{	// Methods

	// RVA: 0x7A4190 Offset: 0x7A3590 VA: 0x1807A4190 Slot: 155
	public override void TrappedEffect() { }

	// RVA: 0x7A43C0 Offset: 0x7A37C0 VA: 0x1807A43C0
	public void .ctor() { }

}

public class TrappableWildlife : ScriptableObject // TypeDefIndex: 9688
{	// Fields
	public GameObjectRef worldObject; // 0x18
	public ItemDefinition inventoryObject; // 0x20
	public int minToCatch; // 0x28
	public int maxToCatch; // 0x2C
	public List<TrappableWildlife.BaitType> baitTypes; // 0x30
	public int caloriesForInterest; // 0x38
	public float successRate; // 0x3C
	public float xpScale; // 0x40

	// Methods

	// RVA: 0x9F6650 Offset: 0x9F5A50 VA: 0x1809F6650
	public void .ctor() { }

}

public class TrappableWildlife.BaitType // TypeDefIndex: 9689
{	// Fields
	public float successRate; // 0x10
	public ItemDefinition bait; // 0x18
	public int minForInterest; // 0x20
	public int maxToConsume; // 0x24

	// Methods

	// RVA: 0x9E6F20 Offset: 0x9E6320 VA: 0x1809E6F20
	public void .ctor() { }

}

public class WildlifeTrap : StorageContainer // TypeDefIndex: 9690
{	// Fields
	public float tickRate; // 0x3D0
	public GameObjectRef trappedEffect; // 0x3D8
	public float trappedEffectRepeatRate; // 0x3E0
	public float trapSuccessRate; // 0x3E4
	public List<ItemDefinition> ignoreBait; // 0x3E8
	public List<WildlifeTrap.WildlifeWeight> targetWildlife; // 0x3F0
	protected float nextEffectTime; // 0x3F8

	// Methods

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool HasCatch() { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool IsTrapActive() { }

	// RVA: 0x89FA50 Offset: 0x89EE50 VA: 0x18089FA50 Slot: 27
	public override void ResetState() { }

	// RVA: 0x89FC10 Offset: 0x89F010 VA: 0x18089FC10
	public void Update() { }

	// RVA: 0x89FA80 Offset: 0x89EE80 VA: 0x18089FA80 Slot: 155
	public virtual void TrappedEffect() { }

	// RVA: 0x89FC50 Offset: 0x89F050 VA: 0x18089FC50
	public void .ctor() { }

}

public static class WildlifeTrap.WildlifeTrapFlags // TypeDefIndex: 9691
{	// Fields
	public const BaseEntity.Flags Occupied = 128;

}

public class WildlifeTrap.WildlifeWeight // TypeDefIndex: 9692
{	// Fields
	public TrappableWildlife wildlife; // 0x10
	public int weight; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Bootstrap : SingletonComponent<Bootstrap> // TypeDefIndex: 9819
{	// Fields
	internal static bool bootstrapInitRun; // 0x0
	public static bool isErrored; // 0x1
	public string messageString; // 0x18
	public CanvasGroup BootstrapUiCanvas; // 0x20
	public GameObject errorPanel; // 0x28
	public TextMeshProUGUI errorText; // 0x30
	public TextMeshProUGUI statusText; // 0x38
	private TimeSince timeSinceVisible; // 0x40
	private static GameObject _engineUi; // 0x8
	private static GameObject _gameUi; // 0x10
	private static GameObject _menuUi; // 0x18
	private static string lastWrittenValue; // 0x20

	// Properties
	public static bool needsSetup { get; }
	public static bool isPresent { get; }

	// Methods

	// RVA: 0x5352B0 Offset: 0x5346B0 VA: 0x1805352B0
	public static bool get_needsSetup() { }

	// RVA: 0x535210 Offset: 0x534610 VA: 0x180535210
	public static bool get_isPresent() { }

	// RVA: 0x534A20 Offset: 0x533E20 VA: 0x180534A20
	public static void RunDefaults() { }

	// RVA: 0x533E20 Offset: 0x533220 VA: 0x180533E20
	public static void Init_Tier0() { }

	// RVA: 0x533930 Offset: 0x532D30 VA: 0x180533930
	public static void Init_Systems() { }

	// RVA: 0x5337F0 Offset: 0x532BF0 VA: 0x1805337F0
	public static void Init_Config() { }

	// RVA: 0x534980 Offset: 0x533D80 VA: 0x180534980
	public static void NetworkInitRaknet() { }

	// RVA: 0x5349D0 Offset: 0x533DD0 VA: 0x1805349D0
	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay) { }

	[IteratorStateMachineAttribute] // RVA: 0x99D10 Offset: 0x99110 VA: 0x180099D10
	// RVA: 0x534E80 Offset: 0x534280 VA: 0x180534E80
	private IEnumerator Start() { }

	// RVA: 0x534790 Offset: 0x533B90 VA: 0x180534790
	public static GameObject LoadEngineUI() { }

	// RVA: 0x534810 Offset: 0x533C10 VA: 0x180534810
	public static GameObject LoadGameUI() { }

	// RVA: 0x534890 Offset: 0x533C90 VA: 0x180534890
	public static GameObject LoadMenuUI() { }

	// RVA: 0x534650 Offset: 0x533A50 VA: 0x180534650
	private static GameObject InstantiatePrefabPersistent(string path) { }

	// RVA: 0x534FE0 Offset: 0x5343E0 VA: 0x180534FE0
	public static void ToggleUIHack() { }

	// RVA: 0x534B70 Offset: 0x533F70 VA: 0x180534B70
	public static void SetUIVisible(bool visible) { }

	[IteratorStateMachineAttribute] // RVA: 0x99EB0 Offset: 0x992B0 VA: 0x180099EB0
	// RVA: 0x533700 Offset: 0x532B00 VA: 0x180533700
	private IEnumerator ClientStartup() { }

	// RVA: 0x535040 Offset: 0x534440 VA: 0x180535040
	protected void Update() { }

	// RVA: 0x534EF0 Offset: 0x5342F0 VA: 0x180534EF0
	private void StartupShared() { }

	// RVA: 0x534F00 Offset: 0x534300 VA: 0x180534F00
	public void ThrowError(string error) { }

	// RVA: 0x533770 Offset: 0x532B70 VA: 0x180533770
	public void ExitGame() { }

	[IteratorStateMachineAttribute] // RVA: 0x9A100 Offset: 0x99500 VA: 0x18009A100
	// RVA: 0x534910 Offset: 0x533D10 VA: 0x180534910
	public static IEnumerator LoadingUpdate(string str) { }

	// RVA: 0x5350C0 Offset: 0x5344C0 VA: 0x1805350C0
	public static void WriteToLog(string str) { }

	// RVA: 0x5351A0 Offset: 0x5345A0 VA: 0x1805351A0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class Bootstrap.<>c // TypeDefIndex: 9820
{	// Fields
	public static readonly Bootstrap.<>c <>9; // 0x0
	public static Func<string, GameObject> <>9__13_0; // 0x8
	public static Action <>9__13_1; // 0x10
	public static Func<bool> <>9__13_2; // 0x18
	public static Func<int> <>9__14_0; // 0x20

	// Methods

	// RVA: 0x542B80 Offset: 0x541F80 VA: 0x180542B80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x542980 Offset: 0x541D80 VA: 0x180542980
	internal GameObject <Init_Tier0>b__13_0(string str) { }

	// RVA: 0x542A00 Offset: 0x541E00 VA: 0x180542A00
	internal void <Init_Tier0>b__13_1() { }

	// RVA: 0x542A10 Offset: 0x541E10 VA: 0x180542A10
	internal bool <Init_Tier0>b__13_2() { }

	// RVA: 0x542930 Offset: 0x541D30 VA: 0x180542930
	internal int <Init_Systems>b__14_0() { }

}

private sealed class Bootstrap.<Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9821
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <timer>5__2; // 0x28
	private AssetBundleBackend <newBackend>5__3; // 0x30
	private BenchmarkTimer <>7__wrap3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x542680 Offset: 0x541A80 VA: 0x180542680 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5413D0 Offset: 0x5407D0 VA: 0x1805413D0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x542840 Offset: 0x541C40 VA: 0x180542840
	private void <>m__Finally1() { }

	// RVA: 0x542890 Offset: 0x541C90 VA: 0x180542890
	private void <>m__Finally2() { }

	// RVA: 0x5428E0 Offset: 0x541CE0 VA: 0x1805428E0
	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x542630 Offset: 0x541A30 VA: 0x180542630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<ClientStartup>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9822
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <>7__wrap1; // 0x28
	private AsyncOperation <op>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x53E4E0 Offset: 0x53D8E0 VA: 0x18053E4E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x53CB60 Offset: 0x53BF60 VA: 0x18053CB60 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x53E6A0 Offset: 0x53DAA0 VA: 0x18053E6A0
	private void <>m__Finally1() { }

	// RVA: 0x53E6F0 Offset: 0x53DAF0 VA: 0x18053E6F0
	private void <>m__Finally2() { }

	// RVA: 0x53E740 Offset: 0x53DB40 VA: 0x18053E740
	private void <>m__Finally3() { }

	// RVA: 0x53E790 Offset: 0x53DB90 VA: 0x18053E790
	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x53E490 Offset: 0x53D890 VA: 0x18053E490 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<LoadingUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9823
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string str; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x53E7E0 Offset: 0x53DBE0 VA: 0x18053E7E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x53E990 Offset: 0x53DD90 VA: 0x18053E990 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

