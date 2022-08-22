public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10031
{	public GameObject notifyTarget; // 0x30
	private INotifyTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	public bool HasContents { get; }


	public bool get_HasContents() { }

	internal override void OnObjects() { }

	internal override void OnEmpty() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

