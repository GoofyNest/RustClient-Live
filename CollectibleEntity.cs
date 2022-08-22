public class CollectibleEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 8550
{	public Translate.Phrase itemName; // 0x168
	public ItemAmount[] itemList; // 0x170
	public GameObjectRef pickupEffect; // 0x178
	public float xpScale; // 0x180


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool ShouldLerp() { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

