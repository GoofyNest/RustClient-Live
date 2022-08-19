public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18

	// Methods

	// RVA: 0x1E6B530 Offset: 0x1E6A930 VA: 0x181E6B530
	public static void ResetToPool(EggHunt instance) { }

	// RVA: 0x1E6B6E0 Offset: 0x1E6AAE0 VA: 0x181E6B6E0
	public void ResetToPool() { }

	// RVA: 0x1E6B2B0 Offset: 0x1E6A6B0 VA: 0x181E6B2B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6A400 Offset: 0x1E69800 VA: 0x181E6A400
	public void CopyTo(EggHunt instance) { }

	// RVA: 0x1E6A5A0 Offset: 0x1E699A0 VA: 0x181E6A5A0
	public EggHunt Copy() { }

	// RVA: 0x1E6B110 Offset: 0x1E6A510 VA: 0x181E6B110
	public static EggHunt Deserialize(Stream stream) { }

	// RVA: 0x1E6A7A0 Offset: 0x1E69BA0 VA: 0x181E6A7A0
	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6AD90 Offset: 0x1E6A190 VA: 0x181E6AD90
	public static EggHunt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6B190 Offset: 0x1E6A590 VA: 0x181E6B190
	public static EggHunt Deserialize(byte[] buffer) { }

	// RVA: 0x1E6B4F0 Offset: 0x1E6A8F0 VA: 0x181E6B4F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6BE20 Offset: 0x1E6B220 VA: 0x181E6BE20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6BE40 Offset: 0x1E6B240 VA: 0x181E6BE40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	// RVA: 0x1E6B510 Offset: 0x1E6A910 VA: 0x181E6B510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6B010 Offset: 0x1E6A410 VA: 0x181E6B010
	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	// RVA: 0x1E6AE20 Offset: 0x1E6A220 VA: 0x181E6AE20
	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6A820 Offset: 0x1E69C20 VA: 0x181E6A820
	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6AAF0 Offset: 0x1E69EF0 VA: 0x181E6AAF0
	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6B890 Offset: 0x1E6AC90 VA: 0x181E6B890
	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	// RVA: 0x1E6BC30 Offset: 0x1E6B030 VA: 0x181E6BC30
	public static void Serialize(Stream stream, EggHunt instance) { }

	// RVA: 0x1E6BE10 Offset: 0x1E6B210 VA: 0x181E6BE10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6BE20 Offset: 0x1E6B220 VA: 0x181E6BE20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6BB20 Offset: 0x1E6AF20 VA: 0x181E6BB20
	public static byte[] SerializeToBytes(EggHunt instance) { }

	// RVA: 0x1E6BA70 Offset: 0x1E6AE70 VA: 0x181E6BA70
	public static void SerializeLengthDelimited(Stream stream, EggHunt instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EggHunt.EggHunter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6363
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public int numEggs; // 0x20
	public ulong playerID; // 0x28

	// Methods

	// RVA: 0x1E6D0B0 Offset: 0x1E6C4B0 VA: 0x181E6D0B0
	public static void ResetToPool(EggHunt.EggHunter instance) { }

	// RVA: 0x1E6D160 Offset: 0x1E6C560 VA: 0x181E6D160
	public void ResetToPool() { }

	// RVA: 0x1E6CE50 Offset: 0x1E6C250 VA: 0x181E6CE50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6BE60 Offset: 0x1E6B260 VA: 0x181E6BE60
	public void CopyTo(EggHunt.EggHunter instance) { }

	// RVA: 0x1E6BEB0 Offset: 0x1E6B2B0 VA: 0x181E6BEB0
	public EggHunt.EggHunter Copy() { }

	// RVA: 0x1E6C9A0 Offset: 0x1E6BDA0 VA: 0x181E6C9A0
	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	// RVA: 0x1E6BF40 Offset: 0x1E6B340 VA: 0x181E6BF40
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6C4C0 Offset: 0x1E6B8C0 VA: 0x181E6C4C0
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6CBA0 Offset: 0x1E6BFA0 VA: 0x181E6CBA0
	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	// RVA: 0x1E6CED0 Offset: 0x1E6C2D0 VA: 0x181E6CED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6D730 Offset: 0x1E6CB30 VA: 0x181E6D730 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6D750 Offset: 0x1E6CB50 VA: 0x181E6D750 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	// RVA: 0x1E6D090 Offset: 0x1E6C490 VA: 0x181E6D090 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6C550 Offset: 0x1E6B950 VA: 0x181E6C550
	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	// RVA: 0x1E6C7E0 Offset: 0x1E6BBE0 VA: 0x181E6C7E0
	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E6BFC0 Offset: 0x1E6B3C0 VA: 0x181E6BFC0
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E6C250 Offset: 0x1E6B650 VA: 0x181E6C250
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E6D210 Offset: 0x1E6C610 VA: 0x181E6D210
	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	// RVA: 0x1E6D5B0 Offset: 0x1E6C9B0 VA: 0x181E6D5B0
	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1E6D720 Offset: 0x1E6CB20 VA: 0x181E6D720
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6D730 Offset: 0x1E6CB30 VA: 0x181E6D730
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6D4A0 Offset: 0x1E6C8A0 VA: 0x181E6D4A0
	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	// RVA: 0x1E6D3F0 Offset: 0x1E6C7F0 VA: 0x181E6D3F0
	public static void SerializeLengthDelimited(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 8779
{	// Fields
	public GameObject[] eggAmmo; // 0x18

	// Methods

	// RVA: 0xABA2F0 Offset: 0xAB96F0 VA: 0x180ABA2F0
	public void OnEnable() { }

	// RVA: 0xABA270 Offset: 0xAB9670 VA: 0x180ABA270
	public void OnDisable() { }

	// RVA: 0xABA370 Offset: 0xAB9770 VA: 0x180ABA370 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 8780
{	// Fields
	public Renderer[] eggRenderers; // 0x18

	// Methods

	// RVA: 0xABB100 Offset: 0xABA500 VA: 0x180ABB100
	public void Show(int index) { }

	// RVA: 0xABB0A0 Offset: 0xABA4A0 VA: 0x180ABB0A0
	public void HideAll() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class EggHuntEvent : BaseHuntEvent // TypeDefIndex: 8781
{	// Fields
	public float warmupTime; // 0x178
	public float cooldownTime; // 0x17C
	public float warnTime; // 0x180
	public float timeAlive; // 0x184
	public static EggHuntEvent serverEvent; // 0x0
	public static EggHuntEvent clientEvent; // 0x8
	public static float durationSeconds; // 0x10
	private Dictionary<ulong, EggHuntEvent.EggHunter> _eggHunters; // 0x188
	public List<EggHuntEvent.EggHunter> clientTopHunters; // 0x190

	// Methods

	// RVA: 0xABA810 Offset: 0xAB9C10 VA: 0x180ABA810
	public bool IsEventActive() { }

	// RVA: 0xABA8C0 Offset: 0xAB9CC0 VA: 0x180ABA8C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABA570 Offset: 0xAB9970 VA: 0x180ABA570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xABA600 Offset: 0xAB9A00 VA: 0x180ABA600 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xABAB70 Offset: 0xAB9F70 VA: 0x180ABAB70
	public void Update() { }

	// RVA: 0xABA6B0 Offset: 0xAB9AB0 VA: 0x180ABA6B0
	public float GetTimeRemaining() { }

	// RVA: 0xABAAB0 Offset: 0xAB9EB0 VA: 0x180ABAAB0
	public static bool ShowNotification() { }

	// RVA: 0xABA720 Offset: 0xAB9B20 VA: 0x180ABA720
	public static float GetWarmupSecondsLeft() { }

	// RVA: 0xABAC30 Offset: 0xABA030 VA: 0x180ABAC30
	public void .ctor() { }

	// RVA: 0xABABB0 Offset: 0xAB9FB0 VA: 0x180ABABB0
	private static void .cctor() { }

}

public class EggHuntEvent.EggHunter // TypeDefIndex: 8782
{	// Fields
	public ulong userid; // 0x10
	public string displayName; // 0x18
	public int numEggs; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class EggHuntNote : MonoBehaviour, IClientComponent // TypeDefIndex: 8788
{	// Fields
	public CanvasGroup mainGroup; // 0x18
	public CanvasGroup timerGroup; // 0x20
	public Text timerText; // 0x28

	// Methods

	// RVA: 0xABACF0 Offset: 0xABA0F0 VA: 0x180ABACF0
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

