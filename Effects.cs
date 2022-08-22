public class EffectData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6278
{	public bool ShouldPool; // 0x10
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


	public static void ResetToPool(EffectData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EffectData instance) { }

	public EffectData Copy() { }

	public static EffectData Deserialize(Stream stream) { }

	public static EffectData DeserializeLengthDelimited(Stream stream) { }

	public static EffectData DeserializeLength(Stream stream, int length) { }

	public static EffectData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EffectData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EffectData Deserialize(byte[] buffer, EffectData instance, bool isDelta = False) { }

	public static EffectData Deserialize(Stream stream, EffectData instance, bool isDelta) { }

	public static EffectData DeserializeLengthDelimited(Stream stream, EffectData instance, bool isDelta) { }

	public static EffectData DeserializeLength(Stream stream, int length, EffectData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EffectData instance, EffectData previous) { }

	public static void Serialize(Stream stream, EffectData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EffectData instance) { }

	public static void SerializeLengthDelimited(Stream stream, EffectData instance) { }

	public void .ctor() { }

}

public class EffectsBenchmarkScene : BenchmarkScene // TypeDefIndex: 8251
{	public GameObjectRef[] effectPrefabs; // 0x40
	private int effectCountPerFrame; // 0x48
	private float timeBetweenRuns; // 0x4C
	private int totalRuns; // 0x50
	private bool isFinished; // 0x54


	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA0E90 Offset: 0xA0290 VA: 0x1800A0E90
	private IEnumerator DoEffectBenchmark() { }

	public override bool ShouldEnd() { }

	public void .ctor() { }

}

private sealed class EffectsBenchmarkScene.<DoEffectBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8252
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EffectsBenchmarkScene <>4__this; // 0x20
	private int <i>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EffectMount : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8886
{	public bool firstPerson; // 0x20
	public GameObject effectPrefab; // 0x28
	public GameObject spawnedEffect; // 0x30
	public GameObject mountBone; // 0x38


	private void LateUpdate() { }

	public void SetOn(bool isOn) { }

	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8887
{	public GameObject effect; // 0x20


	private void LateUpdate() { }

	public void .ctor() { }

}

public class Effect : EffectData // TypeDefIndex: 9330
{	public Vector3 Up; // 0x50
	public Vector3 worldPos; // 0x5C
	public Vector3 worldNrm; // 0x68
	public bool attached; // 0x74
	public Transform transform; // 0x78
	public GameObject gameObject; // 0x80
	public string pooledString; // 0x88
	public bool broadcast; // 0x90
	private static Effect reusableInstace; // 0x0


	public void .ctor() { }

	public void .ctor(string effectName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	public void .ctor(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	public bool NetworkConstruct() { }

	public void Clear() { }

	public static void Strip(GameObject obj) { }

	private static void .cctor() { }

}

public enum Effect.Type // TypeDefIndex: 9331
{	public uint value__; // 0x0
	public const Effect.Type Generic = 0;
	public const Effect.Type Projectile = 1;
	public const Effect.Type GenericGlobal = 2;

}

public static class Effect.client // TypeDefIndex: 9332
{
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	public static void Run(string strName, GameObject obj) { }

	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 9333
{
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9334
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x18


	private BaseViewModel GetViewModel(Effect effect) { }

	public virtual void SetupEffect(Effect effect) { }

	private void MakeThirdPerson() { }

	private void MakeFirstPerson() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 9337
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void SetupEffect(GameObject go, Effect effect) { }

	private static void GenericEffectSpawn(Effect effect) { }

	private static void ProjectileEffectSpawn(Effect effect) { }

	public static void Run(Effect fx) { }

	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 9338
{
	public virtual void SetupEffect(Effect effect) { }

	private bool ApplyToViewModel() { }

	private void PositionOnObject(Transform muzzle) { }

	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 9339
{	private static Effect effect; // 0x2B0AA98


	public static void OnReceivedEffect(Message msg) { }

	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 9340
{	public string boneName; // 0x18
	public bool singleFrame; // 0x20
	private bool isFirstPerson; // 0x21
	private Transform bone; // 0x28


	public virtual void SetupEffect(Effect effect) { }

	private void LateUpdate() { }

	private bool ApplyToViewModel() { }

	private void PositionOnObject(GameObject wm) { }

	public void ClearParent() { }

	public void .ctor() { }

}

public class EffectScaleWithCameraDistance : MonoBehaviour, IEffect // TypeDefIndex: 9341
{	public float minScale; // 0x18
	public float maxScale; // 0x1C
	public float scaleStartDistance; // 0x20
	public float scaleEndDistance; // 0x24
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool on; // 0x0


	public virtual void SetupEffect(Effect effect) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 9853
{	public GameObjectRef ReplacementEffect; // 0x38


	protected override void OnEnable() { }

	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 9854
{	private static Dictionary<string, string[]> effectDictionary; // 0x2182


	public static string GetParticle(string impactType, string materialName) { }

	public static string GetParticle(DamageType damageType, string materialName) { }

	public static string GetDecal(string impactType, string materialName) { }

	public static string GetDecal(DamageType damageType, string materialName) { }

	public static string GetDisplacement(string impactType, string materialName) { }

	private static string LookupEffect(string category, string effect, string material) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EffectRecycle : BaseMonoBehaviour, IClientComponent, IRagdollInhert, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9855
{	[FormerlySerializedAsAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	[ReadOnlyAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	public float detachTime; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	[ReadOnlyAttribute] // RVA: 0x9F480 Offset: 0x9E880 VA: 0x18009F480
	public float recycleTime; // 0x1C
	public EffectRecycle.PlayMode playMode; // 0x20
	public EffectRecycle.ParentDestroyBehaviour onParentDestroyed; // 0x24
	private Action recycleAction; // 0x28
	private Action detachWaitRecycleAction; // 0x30


	protected void Awake() { }

	private float GetParticleSystemLength() { }

	private float GetSoundLength() { }

	private float GetScreenShakeLength() { }

	public virtual Transform RagdollInhertTransform() { }

	protected virtual void OnEnable() { }

	public void Recycle() { }

	private void DetachFromParent() { }

	private void DetachWaitRecycle() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

public enum EffectRecycle.PlayMode // TypeDefIndex: 9856
{	public int value__; // 0x0
	public const EffectRecycle.PlayMode Once = 0;
	public const EffectRecycle.PlayMode Looped = 1;

}

public enum EffectRecycle.ParentDestroyBehaviour // TypeDefIndex: 9857
{	public int value__; // 0x0
	public const EffectRecycle.ParentDestroyBehaviour Detach = 0;
	public const EffectRecycle.ParentDestroyBehaviour Destroy = 1;
	public const EffectRecycle.ParentDestroyBehaviour DetachWaitDestroy = 2;

}

public class EffectRecycleDetach : BaseMonoBehaviour, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9858
{	public float recycleTime; // 0x18
	private Action recycleAction; // 0x20


	protected void Awake() { }

	public void Recycle() { }

	private void DetachFromParent() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9859
{	private const float lifeTime = 60;
	private Action recycleAction; // 0x20


	protected void Awake() { }

	protected void OnEnable() { }

	public void Recycle() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

public class Effects : ConsoleSystem // TypeDefIndex: 11906
{	private static int _antialiasing; // 0x0
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

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int antialiasing { get; set; }
	public static bool requireMotionVectors { get; }
	public static Effects.AntiAliasingType AntiAliasingMode { get; set; }


	public static int get_antialiasing() { }

	public static void set_antialiasing(int value) { }

	public static bool get_requireMotionVectors() { }

	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	public static int ClearAllGibs() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Effects.AntiAliasingType // TypeDefIndex: 11907
{	public int value__; // 0x0
	public const Effects.AntiAliasingType None = 0;
	public const Effects.AntiAliasingType FXAA = 1;
	public const Effects.AntiAliasingType SMAA = 2;
	public const Effects.AntiAliasingType TSSAA = 3;

}

