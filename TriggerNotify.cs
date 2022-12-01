public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 11782
{
	public GameObject notifyTarget;
	private INotifyTrigger toNotify;
	public bool runClientside;
	public bool runServerside;

	public bool HasContents { get; }


	public bool get_HasContents() { }

	internal override void OnObjects() { }

	internal override void OnEmpty() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

