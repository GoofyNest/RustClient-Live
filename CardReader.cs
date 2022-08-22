public class CardReader : IOEntity // TypeDefIndex: 8543
{	public float accessDuration; // 0x288
	public int accessLevel; // 0x28C
	public GameObjectRef accessGrantedEffect; // 0x290
	public GameObjectRef accessDeniedEffect; // 0x298
	public GameObjectRef swipeEffect; // 0x2A0
	public Transform audioPosition; // 0x2A8
	public BaseEntity.Flags AccessLevel1; // 0x2B0
	public BaseEntity.Flags AccessLevel2; // 0x2B4
	public BaseEntity.Flags AccessLevel3; // 0x2B8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientCardSwiped(Keycard card) { }

	public void .ctor() { }

}

