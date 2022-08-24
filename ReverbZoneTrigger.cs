public class ReverbZoneTrigger : TriggerBase, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9018
{
	public Collider trigger; 
	public AudioReverbZone reverbZone; 
	public float lodDistance; 
	public bool inRange; 
	public ReverbSettings reverbSettings; 
	private int initialReverbLevel; 
	private int targetReverbLevel; 
	private int currentReverbLevel; 
	private LODCell cell; 
	private AmbienceZone ambienceZone; 
	private float decayHFRatio; 
	private float decayTime; 
	private float density; 
	private float diffusion; 
	private float HFReference; 
	private float LFReference; 
	private float maxDistance; 
	private float minDistance; 
	private int reflections; 
	private float reflectionsDelay; 
	private int reverb; 
	private float reverbDelay; 
	private int room; 
	private int roomHF; 
	private int roomLF; 


	protected void Awake() { }

	protected void OnEnable() { }

	protected override void OnDisable() { }

	public void DoUpdate() { }

	private void ApplyReverbSettings() { }

	private void DisableReverbZone() { }

	private void EnableReverbZone() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	public bool IsSyncedToParent() { }

	public void .ctor() { }

}

