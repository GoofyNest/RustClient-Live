public class CardReader : IOEntity // TypeDefIndex: 8543
{	// Fields
	public float accessDuration; // 0x288
	public int accessLevel; // 0x28C
	public GameObjectRef accessGrantedEffect; // 0x290
	public GameObjectRef accessDeniedEffect; // 0x298
	public GameObjectRef swipeEffect; // 0x2A0
	public Transform audioPosition; // 0x2A8
	public BaseEntity.Flags AccessLevel1; // 0x2B0
	public BaseEntity.Flags AccessLevel2; // 0x2B4
	public BaseEntity.Flags AccessLevel3; // 0x2B8

	// Methods

	// RVA: 0x717ED0 Offset: 0x7172D0 VA: 0x180717ED0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x717E60 Offset: 0x717260 VA: 0x180717E60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x717D10 Offset: 0x717110 VA: 0x180717D10
	public void ClientCardSwiped(Keycard card) { }

	// RVA: 0x717FC0 Offset: 0x7173C0 VA: 0x180717FC0
	public void .ctor() { }

}

