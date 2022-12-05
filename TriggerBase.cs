public class TriggerBase : BaseMonoBehaviour // TypeDefIndex: 11771
{
	public LayerMask interestLayers;
	public HashSet<GameObject> contents;
	public HashSet<BaseEntity> entityContents;

	public bool HasAnyContents { get; }
	public bool HasAnyEntityContents { get; }


	public bool get_HasAnyContents() { }

	public bool get_HasAnyEntityContents() { }

	internal virtual GameObject InterestedInObject(GameObject obj) { }

	protected virtual void OnDisable() { }

	internal virtual void OnEntityEnter(BaseEntity ent) { }

	internal virtual void OnEntityLeave(BaseEntity ent) { }

	internal virtual void OnObjectAdded(GameObject obj, Collider col) { }

	internal virtual void OnObjectRemoved(GameObject obj) { }

	internal void RemoveInvalidEntities() { }

	internal bool CheckEntity(BaseEntity ent) { }

	internal virtual void OnObjects() { }

	internal virtual void OnEmpty() { }

	public void RemoveObject(GameObject obj) { }

	public void RemoveEntity(BaseEntity ent) { }

	public void OnTriggerEnter(Collider collider) { }

	internal virtual bool SkipOnTriggerExit(Collider collider) { }

	public void OnTriggerExit(Collider collider) { }

	private void OnTriggerExit(GameObject targetObj) { }

	public void .ctor() { }

}

