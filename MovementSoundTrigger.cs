public class MovementSoundTrigger : TriggerBase, IClientComponentEx, ILOD // TypeDefIndex: 10729
{
	public SoundDefinition softSound;
	public SoundDefinition medSound;
	public SoundDefinition hardSound;
	public Collider collider;
	private const float maxDistance = 100;
	private const float tickRate = 2;
	private LODCell cell;
	private Dictionary<GameObject, Vector3> lastPositionByObject;


	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnObjects() { }

	internal override void OnEmpty() { }

	internal override void OnObjectRemoved(GameObject obj) { }

	internal override void OnObjectAdded(GameObject obj, Collider col) { }

	private void OnTick() { }

	protected void OnEnable() { }

	protected override void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	private void PlaySound(GameObject obj, float speed = 0) { }

	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	public void .ctor() { }

}

