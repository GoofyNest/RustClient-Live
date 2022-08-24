public class XMasRefill : BaseEntity // TypeDefIndex: 8668
{
	public GameObjectRef[] giftPrefabs; 
	public List<BasePlayer> goodKids; 
	public List<Stocking> stockings; 
	public AudioSource bells; 


public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
public void PlayBells() { }

public void .ctor() { }

}

