public class BushEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 11424
{
	public GameObjectRef prefab;
	public bool globalBillboard;


	public override void InitShared() { }

	public override bool ShouldLerp() { }

	protected override void ClientInit(Entity info) { }

	internal override void DoNetworkDestroy() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

