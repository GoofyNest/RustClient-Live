public class SantaSleigh : BaseEntity // TypeDefIndex: 8636
{	// Fields
	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170
	public Transform dropOrigin; // 0x178
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float altitudeAboveTerrain; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float desiredAltitude; // 0x4
	public Light bigLight; // 0x180
	public SoundPlayer hohoho; // 0x188
	public float hohohospacing; // 0x190
	public float hohoho_additional_spacing; // 0x194

	// Methods

	// RVA: 0x49C600 Offset: 0x49BA00 VA: 0x18049C600 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x49C5D0 Offset: 0x49B9D0 VA: 0x18049C5D0
	public void ClientPlayHoHoHo() { }

	// RVA: 0x49C9D0 Offset: 0x49BDD0 VA: 0x18049C9D0
	public void Update() { }

	// RVA: 0x49CB70 Offset: 0x49BF70 VA: 0x18049CB70
	public void .ctor() { }

	// RVA: 0x49CB20 Offset: 0x49BF20 VA: 0x18049CB20
	private static void .cctor() { }

}

