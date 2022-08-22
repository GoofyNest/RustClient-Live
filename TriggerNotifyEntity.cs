public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10033
{	public GameObject notifyTarget; // 0x30
	private INotifyEntityTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	public bool HasContents { get; }


	public bool get_HasContents() { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

