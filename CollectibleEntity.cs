public class CollectibleEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 10270
{
	public Translate.Phrase itemName; 
	public ItemAmount[] itemList; 
	public GameObjectRef pickupEffect; 
	public float xpScale; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool ShouldLerp() { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <GetMenuItems>

}

