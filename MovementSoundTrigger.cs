public class MovementSoundTrigger : TriggerBase, IClientComponentEx, ILOD // TypeDefIndex: 8998
{	public SoundDefinition softSound; // 0x30
	public SoundDefinition medSound; // 0x38
	public SoundDefinition hardSound; // 0x40
	public Collider collider; // 0x48
	private const float maxDistance = 100;
	private const float tickRate = 2;
	private LODCell cell; // 0x50
	private Dictionary<GameObject, Vector3> lastPositionByObject; // 0x58


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

