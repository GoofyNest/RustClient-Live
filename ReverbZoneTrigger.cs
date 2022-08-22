public class ReverbZoneTrigger : TriggerBase, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9018
{	public Collider trigger; // 0x30
	public AudioReverbZone reverbZone; // 0x38
	public float lodDistance; // 0x40
	public bool inRange; // 0x44
	public ReverbSettings reverbSettings; // 0x48
	private int initialReverbLevel; // 0x50
	private int targetReverbLevel; // 0x54
	private int currentReverbLevel; // 0x58
	private LODCell cell; // 0x60
	private AmbienceZone ambienceZone; // 0x68
	private float decayHFRatio; // 0x70
	private float decayTime; // 0x74
	private float density; // 0x78
	private float diffusion; // 0x7C
	private float HFReference; // 0x80
	private float LFReference; // 0x84
	private float maxDistance; // 0x88
	private float minDistance; // 0x8C
	private int reflections; // 0x90
	private float reflectionsDelay; // 0x94
	private int reverb; // 0x98
	private float reverbDelay; // 0x9C
	private int room; // 0xA0
	private int roomHF; // 0xA4
	private int roomLF; // 0xA8


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

