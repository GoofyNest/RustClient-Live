public class EffectData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6279
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint type; 
	public uint pooledstringid; 
	public int number; 
	public Vector3 origin; 
	public Vector3 normal; 
	public float scale; 
	public uint entity; 
	public uint bone; 
	public ulong source; 


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

public class EffectsBenchmarkScene : BenchmarkScene // TypeDefIndex: 9921
{
	public GameObjectRef[] effectPrefabs; 
	private int effectCountPerFrame; 
	private float timeBetweenRuns; 
	private int totalRuns; 
	private bool isFinished; 


	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DoEffectBenchmark() { }

	public override bool ShouldEnd() { }

	public void .ctor() { }

}

private sealed class EffectsBenchmarkScene.<DoEffectBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9922
{
	private int <>1__state; 
	private object <>2__current; 
	public EffectsBenchmarkScene <>4__this; 
	private int <i>5__2; 

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

public class EffectMount : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 10558
{
	public bool firstPerson; 
	public GameObject effectPrefab; 
	public GameObject spawnedEffect; 
	public GameObject mountBone; 


	private void LateUpdate() { }

	public void SetOn(bool isOn) { }

	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 10559
{
	public GameObject effect; 


	private void LateUpdate() { }

	public void .ctor() { }

}

public class Effect : EffectData // TypeDefIndex: 11002
{
	public Vector3 Up; 
	public Vector3 worldPos; 
	public Vector3 worldNrm; 
	public bool attached; 
	public Transform transform; 
	public GameObject gameObject; 
	public string pooledString; 
	public bool broadcast; 
	private static Effect reusableInstace; 


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

public enum Effect.Type // TypeDefIndex: 11003
{
	public uint value__; 
	public const Effect.Type Generic = 0;
	public const Effect.Type Projectile = 1;
	public const Effect.Type GenericGlobal = 2;

}

public static class Effect.client // TypeDefIndex: 11004
{

	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	public static void Run(string strName, GameObject obj) { }

	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 11005
{

	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 11006
{
	[HideInInspector] 
	public EffectParentToWeaponBone parentToWeaponComponent; 


	private BaseViewModel GetViewModel(Effect effect) { }

	public virtual void SetupEffect(Effect effect) { }

	private void MakeThirdPerson() { }

	private void MakeFirstPerson() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 11009
{

	[ExtensionAttribute] 
	private static void SetupEffect(GameObject go, Effect effect) { }

	private static void GenericEffectSpawn(Effect effect) { }

	private static void ProjectileEffectSpawn(Effect effect) { }

	public static void Run(Effect fx) { }

	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 11010
{

	public virtual void SetupEffect(Effect effect) { }

	private bool ApplyToViewModel() { }

	private void PositionOnObject(Transform muzzle) { }

	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 11011
{
	private static Effect effect; 


	public static void OnReceivedEffect(Message msg) { }

	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 11012
{
	public string boneName; 
	public bool singleFrame; 
	private bool isFirstPerson; 
	private Transform bone; 


	public virtual void SetupEffect(Effect effect) { }

	private void LateUpdate() { }

	private bool ApplyToViewModel() { }

	private void PositionOnObject(GameObject wm) { }

	public void ClearParent() { }

	public void .ctor() { }

}

public class EffectScaleWithCameraDistance : MonoBehaviour, IEffect // TypeDefIndex: 11013
{
	public float minScale; 
	public float maxScale; 
	public float scaleStartDistance; 
	public float scaleEndDistance; 
	[ClientVar] 
	public static bool on; 


	public virtual void SetupEffect(Effect effect) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 11527
{
	public GameObjectRef ReplacementEffect; 


	protected override void OnEnable() { }

	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 11528
{
	private static Dictionary<string, string[]> effectDictionary; 


	public static string GetParticle(string impactType, string materialName) { }

	public static string GetParticle(DamageType damageType, string materialName) { }

	public static string GetDecal(string impactType, string materialName) { }

	public static string GetDecal(DamageType damageType, string materialName) { }

	public static string GetDisplacement(string impactType, string materialName) { }

	private static string LookupEffect(string category, string effect, string material) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EffectRecycle : BaseMonoBehaviour, IClientComponent, IRagdollInhert, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 11529
{
	[FormerlySerializedAsAttribute] 
	[ReadOnlyAttribute] 
	public float detachTime; 
	[FormerlySerializedAsAttribute] 
	[ReadOnlyAttribute] 
	public float recycleTime; 
	public EffectRecycle.PlayMode playMode; 
	public EffectRecycle.ParentDestroyBehaviour onParentDestroyed; 
	private Action recycleAction; 
	private Action detachWaitRecycleAction; 


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

public enum EffectRecycle.PlayMode // TypeDefIndex: 11530
{
	public int value__; 
	public const EffectRecycle.PlayMode Once = 0;
	public const EffectRecycle.PlayMode Looped = 1;

}

public enum EffectRecycle.ParentDestroyBehaviour // TypeDefIndex: 11531
{
	public int value__; 
	public const EffectRecycle.ParentDestroyBehaviour Detach = 0;
	public const EffectRecycle.ParentDestroyBehaviour Destroy = 1;
	public const EffectRecycle.ParentDestroyBehaviour DetachWaitDestroy = 2;

}

public class EffectRecycleDetach : BaseMonoBehaviour, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 11532
{
	public float recycleTime; 
	private Action recycleAction; 


	protected void Awake() { }

	public void Recycle() { }

	private void DetachFromParent() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 11533
{
	private const float lifeTime = 60;
	private Action recycleAction; 


	protected void Awake() { }

	protected void OnEnable() { }

	public void Recycle() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

public class Effects : ConsoleSystem // TypeDefIndex: 13602
{
	private static int _antialiasing; 
	[ClientVar] 
	public static bool ao; 
	[ClientVar] 
	public static bool bloom; 
	[ClientVar] 
	public static bool lensdirt; 
	[ClientVar] 
	public static bool motionblur; 
	[ClientVar] 
	public static bool sharpen; 
	[ClientVar] 
	public static bool shafts; 
	[ClientVar] 
	public static bool vignet; 
	public const bool color = True;
	[ClientVar] 
	public static bool footsteps; 
	[ClientVar] 
	public static int maxgibs; 
	[ClientVar] 
	public static int maxGibDist; 
	[ClientVar] 
	public static int minGibLife; 
	[ClientVar] 
	public static int maxGibLife; 
	[ClientVar] 
	public static bool otherplayerslightflares; 
	[ClientVar] 
	public static bool showoutlines; 

	[ClientVar] 
	public static int antialiasing { get; set; }
	public static bool requireMotionVectors { get; }
	public static Effects.AntiAliasingType AntiAliasingMode { get; set; }


	public static int get_antialiasing() { }

	public static void set_antialiasing(int value) { }

	public static bool get_requireMotionVectors() { }

	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	public static int ClearAllGibs() { }

	[ClientVar] 
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Effects.AntiAliasingType // TypeDefIndex: 13603
{
	public int value__; 
	public const Effects.AntiAliasingType None = 0;
	public const Effects.AntiAliasingType FXAA = 1;
	public const Effects.AntiAliasingType SMAA = 2;
	public const Effects.AntiAliasingType TSSAA = 3;

}

