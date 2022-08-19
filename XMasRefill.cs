public class XMasRefill : BaseEntity // TypeDefIndex: 8668
{	// Fields
	public GameObjectRef[] giftPrefabs; // 0x168
	public List<BasePlayer> goodKids; // 0x170
	public List<Stocking> stockings; // 0x178
	public AudioSource bells; // 0x180

	// Methods

	// RVA: 0x1A930B0 Offset: 0x1A924B0 VA: 0x181A930B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A93480 Offset: 0x1A92880 VA: 0x181A93480
	public void PlayBells() { }

	// RVA: 0x1A934B0 Offset: 0x1A928B0 VA: 0x181A934B0
	public void .ctor() { }

}

