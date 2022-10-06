public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6366
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<EggHunt.EggHunter> hunters; 


	public static void ResetToPool(EggHunt instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EggHunt instance) { }

	public EggHunt Copy() { }

	public static EggHunt Deserialize(Stream stream) { }

	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	public static EggHunt DeserializeLength(Stream stream, int length) { }

	public static EggHunt Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	public static void Serialize(Stream stream, EggHunt instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EggHunt instance) { }

	public static void SerializeLengthDelimited(Stream stream, EggHunt instance) { }

	public void .ctor() { }

}

public class EggHunt.EggHunter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string displayName; 
	public int numEggs; 
	public ulong playerID; 


	public static void ResetToPool(EggHunt.EggHunter instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EggHunt.EggHunter instance) { }

	public EggHunt.EggHunter Copy() { }

	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	public static void SerializeLengthDelimited(Stream stream, EggHunt.EggHunter instance) { }

	public void .ctor() { }

}

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 10487
{
	public GameObject[] eggAmmo; 


	public void OnEnable() { }

	public void OnDisable() { }

	public void OnInventoryChanged() { }

	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 10488
{
	public Renderer[] eggRenderers; 


	public void Show(int index) { }

	public void HideAll() { }

	public void .ctor() { }

}

public class EggHuntEvent : BaseHuntEvent // TypeDefIndex: 10489
{
	public float warmupTime; 
	public float cooldownTime; 
	public float warnTime; 
	public float timeAlive; 
	public static EggHuntEvent serverEvent; 
	public static EggHuntEvent clientEvent; 
	public static float durationSeconds; 
	private Dictionary<ulong, EggHuntEvent.EggHunter> _eggHunters; 
	public List<EggHuntEvent.EggHunter> clientTopHunters; 


	public bool IsEventActive() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public override void DestroyShared() { }

	public void Update() { }

	public float GetTimeRemaining() { }

	public static bool ShowNotification() { }

	public static float GetWarmupSecondsLeft() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EggHuntEvent.EggHunter // TypeDefIndex: 10490
{
	public ulong userid; 
	public string displayName; 
	public int numEggs; 


	public void .ctor() { }

}

public class EggHuntNote : MonoBehaviour, IClientComponent // TypeDefIndex: 10496
{
	public CanvasGroup mainGroup; 
	public CanvasGroup timerGroup; 
	public Text timerText; 


	public void Update() { }

	public void .ctor() { }

}

