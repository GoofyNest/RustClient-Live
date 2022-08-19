public class EffectData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6278
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint type; // 0x14
	public uint pooledstringid; // 0x18
	public int number; // 0x1C
	public Vector3 origin; // 0x20
	public Vector3 normal; // 0x2C
	public float scale; // 0x38
	public uint entity; // 0x3C
	public uint bone; // 0x40
	public ulong source; // 0x48

	// Methods

	// RVA: 0x2015510 Offset: 0x2014910 VA: 0x182015510
	public static void ResetToPool(EffectData instance) { }

	// RVA: 0x2015610 Offset: 0x2014A10 VA: 0x182015610
	public void ResetToPool() { }

	// RVA: 0x2015010 Offset: 0x2014410 VA: 0x182015010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2013630 Offset: 0x2012A30 VA: 0x182013630
	public void CopyTo(EffectData instance) { }

	// RVA: 0x2013690 Offset: 0x2012A90 VA: 0x182013690
	public EffectData Copy() { }

	// RVA: 0x2014920 Offset: 0x2013D20 VA: 0x182014920
	public static EffectData Deserialize(Stream stream) { }

	// RVA: 0x2013750 Offset: 0x2012B50 VA: 0x182013750
	public static EffectData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2013C00 Offset: 0x2013000 VA: 0x182013C00
	public static EffectData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20144D0 Offset: 0x20138D0 VA: 0x1820144D0
	public static EffectData Deserialize(byte[] buffer) { }

	// RVA: 0x2015190 Offset: 0x2014590 VA: 0x182015190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2016220 Offset: 0x2015620 VA: 0x182016220 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2016240 Offset: 0x2015640 VA: 0x182016240 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EffectData previous) { }

	// RVA: 0x20154F0 Offset: 0x20148F0 VA: 0x1820154F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2014090 Offset: 0x2013490 VA: 0x182014090
	public static EffectData Deserialize(byte[] buffer, EffectData instance, bool isDelta = False) { }

	// RVA: 0x2014CB0 Offset: 0x20140B0 VA: 0x182014CB0
	public static EffectData Deserialize(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x20137D0 Offset: 0x2012BD0 VA: 0x1820137D0
	public static EffectData DeserializeLengthDelimited(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x2013C90 Offset: 0x2013090 VA: 0x182013C90
	public static EffectData DeserializeLength(Stream stream, int length, EffectData instance, bool isDelta) { }

	// RVA: 0x2015710 Offset: 0x2014B10 VA: 0x182015710
	public static void SerializeDelta(Stream stream, EffectData instance, EffectData previous) { }

	// RVA: 0x2015ED0 Offset: 0x20152D0 VA: 0x182015ED0
	public static void Serialize(Stream stream, EffectData instance) { }

	// RVA: 0x2016210 Offset: 0x2015610 VA: 0x182016210
	public byte[] ToProtoBytes() { }

	// RVA: 0x2016220 Offset: 0x2015620 VA: 0x182016220
	public void ToProto(Stream stream) { }

	// RVA: 0x2015DC0 Offset: 0x20151C0 VA: 0x182015DC0
	public static byte[] SerializeToBytes(EffectData instance) { }

	// RVA: 0x2015D10 Offset: 0x2015110 VA: 0x182015D10
	public static void SerializeLengthDelimited(Stream stream, EffectData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EffectsBenchmarkScene : BenchmarkScene // TypeDefIndex: 8251
{	// Fields
	public GameObjectRef[] effectPrefabs; // 0x40
	private int effectCountPerFrame; // 0x48
	private float timeBetweenRuns; // 0x4C
	private int totalRuns; // 0x50
	private bool isFinished; // 0x54

	// Methods

	// RVA: 0xABA190 Offset: 0xAB9590 VA: 0x180ABA190 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA0E90 Offset: 0xA0290 VA: 0x1800A0E90
	// RVA: 0xABA110 Offset: 0xAB9510 VA: 0x180ABA110
	private IEnumerator DoEffectBenchmark() { }

	// RVA: 0xABA180 Offset: 0xAB9580 VA: 0x180ABA180 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0xABA200 Offset: 0xAB9600 VA: 0x180ABA200
	public void .ctor() { }

}

private sealed class EffectsBenchmarkScene.<DoEffectBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8252
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EffectsBenchmarkScene <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0xAC0E60 Offset: 0xAC0260 VA: 0x180AC0E60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC1120 Offset: 0xAC0520 VA: 0x180AC1120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EffectMount : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8886
{	// Fields
	public bool firstPerson; // 0x20
	public GameObject effectPrefab; // 0x28
	public GameObject spawnedEffect; // 0x30
	public GameObject mountBone; // 0x38

	// Methods

	// RVA: 0xAB6280 Offset: 0xAB5680 VA: 0x180AB6280
	private void LateUpdate() { }

	// RVA: 0xAB64D0 Offset: 0xAB58D0 VA: 0x180AB64D0
	public void SetOn(bool isOn) { }

	// RVA: 0xAB66E0 Offset: 0xAB5AE0 VA: 0x180AB66E0
	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8887
{	// Fields
	public GameObject effect; // 0x20

	// Methods

	// RVA: 0xAB77E0 Offset: 0xAB6BE0 VA: 0x180AB77E0
	private void LateUpdate() { }

	// RVA: 0xAB7A10 Offset: 0xAB6E10 VA: 0x180AB7A10
	public void .ctor() { }

}

public class Effect : EffectData // TypeDefIndex: 9330
{	// Fields
	public Vector3 Up; // 0x50
	public Vector3 worldPos; // 0x5C
	public Vector3 worldNrm; // 0x68
	public bool attached; // 0x74
	public Transform transform; // 0x78
	public GameObject gameObject; // 0x80
	public string pooledString; // 0x88
	public bool broadcast; // 0x90
	private static Effect reusableInstace; // 0x0

	// Methods

	// RVA: 0x6E4730 Offset: 0x6E3B30 VA: 0x1806E4730
	public void .ctor() { }

	// RVA: 0xAB9F20 Offset: 0xAB9320 VA: 0x180AB9F20
	public void .ctor(string effectName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABA050 Offset: 0xAB9450 VA: 0x180ABA050
	public void .ctor(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xAB8DA0 Offset: 0xAB81A0 VA: 0x180AB8DA0
	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xAB8C90 Offset: 0xAB8090 VA: 0x180AB8C90
	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xAB90A0 Offset: 0xAB84A0 VA: 0x180AB90A0
	public bool NetworkConstruct() { }

	// RVA: 0xAB8BC0 Offset: 0xAB7FC0 VA: 0x180AB8BC0
	public void Clear() { }

	// RVA: 0xAB9D80 Offset: 0xAB9180 VA: 0x180AB9D80
	public static void Strip(GameObject obj) { }

	// RVA: 0xAB9EC0 Offset: 0xAB92C0 VA: 0x180AB9EC0
	private static void .cctor() { }

}

public enum Effect.Type // TypeDefIndex: 9331
{	// Fields
	public uint value__; // 0x0
	public const Effect.Type Generic = 0;
	public const Effect.Type Projectile = 1;
	public const Effect.Type GenericGlobal = 2;

}

public static class Effect.client // TypeDefIndex: 9332
{	// Methods

	// RVA: 0xAC2310 Offset: 0xAC1710 VA: 0x180AC2310
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC2610 Offset: 0xAC1A10 VA: 0x180AC2610
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC2440 Offset: 0xAC1840 VA: 0x180AC2440
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	// RVA: 0xAC2780 Offset: 0xAC1B80 VA: 0x180AC2780
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	// RVA: 0xAC20B0 Offset: 0xAC14B0 VA: 0x180AC20B0
	public static void Run(string strName, GameObject obj) { }

	// RVA: 0xAC1820 Offset: 0xAC0C20 VA: 0x180AC1820
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC1A70 Offset: 0xAC0E70 VA: 0x180AC1A70
	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 9333
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC2F10 Offset: 0xAC2310 VA: 0x180AC2F10
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC2F10 Offset: 0xAC2310 VA: 0x180AC2F10
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC2990 Offset: 0xAC1D90 VA: 0x180AC2990
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC29C0 Offset: 0xAC1DC0 VA: 0x180AC29C0
	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9334
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x18

	// Methods

	// RVA: 0xAB3D60 Offset: 0xAB3160 VA: 0x180AB3D60
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0xAB4400 Offset: 0xAB3800 VA: 0x180AB4400 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB4300 Offset: 0xAB3700 VA: 0x180AB4300
	private void MakeThirdPerson() { }

	// RVA: 0xAB41A0 Offset: 0xAB35A0 VA: 0x180AB41A0
	private void MakeFirstPerson() { }

	// RVA: 0xAB43A0 Offset: 0xAB37A0 VA: 0x180AB43A0 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 9337
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAB5E50 Offset: 0xAB5250 VA: 0x180AB5E50
	private static void SetupEffect(GameObject go, Effect effect) { }

	// RVA: 0xAB5AC0 Offset: 0xAB4EC0 VA: 0x180AB5AC0
	private static void GenericEffectSpawn(Effect effect) { }

	// RVA: 0xAB5AF0 Offset: 0xAB4EF0 VA: 0x180AB5AF0
	private static void ProjectileEffectSpawn(Effect effect) { }

	// RVA: 0xAB5E00 Offset: 0xAB5200 VA: 0x180AB5E00
	public static void Run(Effect fx) { }

	// RVA: 0xAB58F0 Offset: 0xAB4CF0 VA: 0x180AB58F0
	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0xAB5050 Offset: 0xAB4450 VA: 0x180AB5050
	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	// RVA: 0xAB5770 Offset: 0xAB4B70 VA: 0x180AB5770
	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 9338
{	// Methods

	// RVA: 0xAB6980 Offset: 0xAB5D80 VA: 0x180AB6980 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB6720 Offset: 0xAB5B20 VA: 0x180AB6720
	private bool ApplyToViewModel() { }

	// RVA: 0xAB6930 Offset: 0xAB5D30 VA: 0x180AB6930
	private void PositionOnObject(Transform muzzle) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 9339
{	// Fields
	private static Effect effect; // 0x2B0AA98

	// Methods

	// RVA: 0xAB6B00 Offset: 0xAB5F00 VA: 0x180AB6B00
	public static void OnReceivedEffect(Message msg) { }

	// RVA: 0xAB6E00 Offset: 0xAB6200 VA: 0x180AB6E00
	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 9340
{	// Fields
	public string boneName; // 0x18
	public bool singleFrame; // 0x20
	private bool isFirstPerson; // 0x21
	private Transform bone; // 0x28

	// Methods

	// RVA: 0xAB76D0 Offset: 0xAB6AD0 VA: 0x180AB76D0 Slot: 7
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB7150 Offset: 0xAB6550 VA: 0x180AB7150
	private void LateUpdate() { }

	// RVA: 0xAB6E60 Offset: 0xAB6260 VA: 0x180AB6E60
	private bool ApplyToViewModel() { }

	// RVA: 0xAB73A0 Offset: 0xAB67A0 VA: 0x180AB73A0
	private void PositionOnObject(GameObject wm) { }

	// RVA: 0xAB7120 Offset: 0xAB6520 VA: 0x180AB7120
	public void ClearParent() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public class EffectScaleWithCameraDistance : MonoBehaviour, IEffect // TypeDefIndex: 9341
{	// Fields
	public float minScale; // 0x18
	public float maxScale; // 0x1C
	public float scaleStartDistance; // 0x20
	public float scaleEndDistance; // 0x24
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool on; // 0x0

	// Methods

	// RVA: 0xAB8700 Offset: 0xAB7B00 VA: 0x180AB8700 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB8B90 Offset: 0xAB7F90 VA: 0x180AB8B90
	public void .ctor() { }

	// RVA: 0xAB8B50 Offset: 0xAB7F50 VA: 0x180AB8B50
	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 9853
{	// Fields
	public GameObjectRef ReplacementEffect; // 0x38

	// Methods

	// RVA: 0xAB4670 Offset: 0xAB3A70 VA: 0x180AB4670 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 9854
{	// Fields
	private static Dictionary<string, string[]> effectDictionary; // 0x2182

	// Methods

	// RVA: 0xAB4D80 Offset: 0xAB4180 VA: 0x180AB4D80
	public static string GetParticle(string impactType, string materialName) { }

	// RVA: 0xAB4C60 Offset: 0xAB4060 VA: 0x180AB4C60
	public static string GetParticle(DamageType damageType, string materialName) { }

	// RVA: 0xAB4A60 Offset: 0xAB3E60 VA: 0x180AB4A60
	public static string GetDecal(string impactType, string materialName) { }

	// RVA: 0xAB4AD0 Offset: 0xAB3ED0 VA: 0x180AB4AD0
	public static string GetDecal(DamageType damageType, string materialName) { }

	// RVA: 0xAB4BF0 Offset: 0xAB3FF0 VA: 0x180AB4BF0
	public static string GetDisplacement(string impactType, string materialName) { }

	// RVA: 0xAB4DF0 Offset: 0xAB41F0 VA: 0x180AB4DF0
	private static string LookupEffect(string category, string effect, string material) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class EffectRecycle : BaseMonoBehaviour, IClientComponent, IRagdollInhert, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9855
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	[ReadOnlyAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	public float detachTime; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	[ReadOnlyAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	public float recycleTime; // 0x1C
	public EffectRecycle.PlayMode playMode; // 0x20
	public EffectRecycle.ParentDestroyBehaviour onParentDestroyed; // 0x24
	private Action recycleAction; // 0x28
	private Action detachWaitRecycleAction; // 0x30

	// Methods

	// RVA: 0xAB7F50 Offset: 0xAB7350 VA: 0x180AB7F50
	protected void Awake() { }

	// RVA: 0xAB8120 Offset: 0xAB7520 VA: 0x180AB8120
	private float GetParticleSystemLength() { }

	// RVA: 0xAB8380 Offset: 0xAB7780 VA: 0x180AB8380
	private float GetSoundLength() { }

	// RVA: 0xAB82A0 Offset: 0xAB76A0 VA: 0x180AB82A0
	private float GetScreenShakeLength() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 9
	public virtual Transform RagdollInhertTransform() { }

	// RVA: 0xAB8560 Offset: 0xAB7960 VA: 0x180AB8560 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xAB8660 Offset: 0xAB7A60 VA: 0x180AB8660 Slot: 7
	public void Recycle() { }

	// RVA: 0xAB8000 Offset: 0xAB7400 VA: 0x180AB8000
	private void DetachFromParent() { }

	// RVA: 0xAB80D0 Offset: 0xAB74D0 VA: 0x180AB80D0
	private void DetachWaitRecycle() { }

	// RVA: 0xAB8600 Offset: 0xAB7A00 VA: 0x180AB8600 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public enum EffectRecycle.PlayMode // TypeDefIndex: 9856
{	// Fields
	public int value__; // 0x0
	public const EffectRecycle.PlayMode Once = 0;
	public const EffectRecycle.PlayMode Looped = 1;

}

public enum EffectRecycle.ParentDestroyBehaviour // TypeDefIndex: 9857
{	// Fields
	public int value__; // 0x0
	public const EffectRecycle.ParentDestroyBehaviour Detach = 0;
	public const EffectRecycle.ParentDestroyBehaviour Destroy = 1;
	public const EffectRecycle.ParentDestroyBehaviour DetachWaitDestroy = 2;

}

public class EffectRecycleDetach : BaseMonoBehaviour, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9858
{	// Fields
	public float recycleTime; // 0x18
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xAB7A50 Offset: 0xAB6E50 VA: 0x180AB7A50
	protected void Awake() { }

	// RVA: 0xAB7C80 Offset: 0xAB7080 VA: 0x180AB7C80 Slot: 6
	public void Recycle() { }

	// RVA: 0xAB7AD0 Offset: 0xAB6ED0 VA: 0x180AB7AD0
	private void DetachFromParent() { }

	// RVA: 0xAB7BA0 Offset: 0xAB6FA0 VA: 0x180AB7BA0 Slot: 7
	public void OnParentDestroying() { }

	// RVA: 0xAB7D10 Offset: 0xAB7110 VA: 0x180AB7D10
	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9859
{	// Fields
	private const float lifeTime = 60;
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xAB7D20 Offset: 0xAB7120 VA: 0x180AB7D20
	protected void Awake() { }

	// RVA: 0xAB7DA0 Offset: 0xAB71A0 VA: 0x180AB7DA0
	protected void OnEnable() { }

	// RVA: 0xAB7EC0 Offset: 0xAB72C0 VA: 0x180AB7EC0 Slot: 8
	public void Recycle() { }

	// RVA: 0xAB7E20 Offset: 0xAB7220 VA: 0x180AB7E20 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

public class Effects : ConsoleSystem // TypeDefIndex: 11906
{	// Fields
	private static int _antialiasing; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool ao; // 0x4
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool bloom; // 0x5
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool lensdirt; // 0x6
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool motionblur; // 0x7
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool sharpen; // 0x8
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool shafts; // 0x9
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool vignet; // 0xA
	public const bool color = True;
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool footsteps; // 0xB
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int maxgibs; // 0xC
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int maxGibDist; // 0x10
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int minGibLife; // 0x14
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int maxGibLife; // 0x18
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool otherplayerslightflares; // 0x1C
	[ClientVar] // RVA: 0x97F90 Offset: 0x97390 VA: 0x180097F90
	public static bool showoutlines; // 0x1D

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int antialiasing { get; set; }
	public static bool requireMotionVectors { get; }
	public static Effects.AntiAliasingType AntiAliasingMode { get; set; }

	// Methods

	// RVA: 0x6D9DC0 Offset: 0x6D91C0 VA: 0x1806D9DC0
	public static int get_antialiasing() { }

	// RVA: 0x6DA070 Offset: 0x6D9470 VA: 0x1806DA070
	public static void set_antialiasing(int value) { }

	// RVA: 0x6D9E20 Offset: 0x6D9220 VA: 0x1806D9E20
	public static bool get_requireMotionVectors() { }

	// RVA: 0x6D9D20 Offset: 0x6D9120 VA: 0x1806D9D20
	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	// RVA: 0x6D9F90 Offset: 0x6D9390 VA: 0x1806D9F90
	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	// RVA: 0x6D9840 Offset: 0x6D8C40 VA: 0x1806D9840
	public static int ClearAllGibs() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D9AF0 Offset: 0x6D8EF0 VA: 0x1806D9AF0
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D9CC0 Offset: 0x6D90C0 VA: 0x1806D9CC0
	public void .ctor() { }

	// RVA: 0x6D9B80 Offset: 0x6D8F80 VA: 0x1806D9B80
	private static void .cctor() { }

}

public enum Effects.AntiAliasingType // TypeDefIndex: 11907
{	// Fields
	public int value__; // 0x0
	public const Effects.AntiAliasingType None = 0;
	public const Effects.AntiAliasingType FXAA = 1;
	public const Effects.AntiAliasingType SMAA = 2;
	public const Effects.AntiAliasingType TSSAA = 3;

}

