public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18


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

public class EggHunt.EggHunter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6363
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public int numEggs; // 0x20
	public ulong playerID; // 0x28


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

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 8779
{	public GameObject[] eggAmmo; // 0x18


	public void OnEnable() { }

	public void OnDisable() { }

	public void OnInventoryChanged() { }

	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 8780
{	public Renderer[] eggRenderers; // 0x18


	public void Show(int index) { }

	public void HideAll() { }

	public void .ctor() { }

}

public class EggHuntEvent : BaseHuntEvent // TypeDefIndex: 8781
{	public float warmupTime; // 0x178
	public float cooldownTime; // 0x17C
	public float warnTime; // 0x180
	public float timeAlive; // 0x184
	public static EggHuntEvent serverEvent; // 0x0
	public static EggHuntEvent clientEvent; // 0x8
	public static float durationSeconds; // 0x10
	private Dictionary<ulong, EggHuntEvent.EggHunter> _eggHunters; // 0x188
	public List<EggHuntEvent.EggHunter> clientTopHunters; // 0x190


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

public class EggHuntEvent.EggHunter // TypeDefIndex: 8782
{	public ulong userid; // 0x10
	public string displayName; // 0x18
	public int numEggs; // 0x20


	public void .ctor() { }

}

public class EggHuntNote : MonoBehaviour, IClientComponent // TypeDefIndex: 8788
{	public CanvasGroup mainGroup; // 0x18
	public CanvasGroup timerGroup; // 0x20
	public Text timerText; // 0x28


	public void Update() { }

	public void .ctor() { }

}

