public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10040
{
	public GameObject notifyTarget; 
	private INotifyEntityTrigger toNotify; 
	public bool runClientside; 
	public bool runServerside; 

	public bool HasContents { get; }


	public bool get_HasContents() { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

