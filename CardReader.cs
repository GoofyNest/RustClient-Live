public class CardReader : IOEntity // TypeDefIndex: 10215
{
	public float accessDuration; 
	public int accessLevel; 
	public GameObjectRef accessGrantedEffect; 
	public GameObjectRef accessDeniedEffect; 
	public GameObjectRef swipeEffect; 
	public Transform audioPosition; 
	public BaseEntity.Flags AccessLevel1; 
	public BaseEntity.Flags AccessLevel2; 
	public BaseEntity.Flags AccessLevel3; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientCardSwiped(Keycard card) { }

	public void .ctor() { }

}

