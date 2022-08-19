public class SoundManager : SingletonComponent<SoundManager>, IClientComponent // TypeDefIndex: 9032
{	// Fields
	public SoundClass defaultSoundClass; // 0x18
	public Dictionary<SoundDefinition, List<Sound>> activeSoundsByDef; // 0x20
	public List<ISoundBudgetedUpdate> budgetUpdatables; // 0x28
	public List<SoundPlayer> pendingSoundPlayers; // 0x30
	private List<SoundManager.ScheduledSound> scheduledSounds; // 0x38
	private int updatableIndex; // 0x40
	private Stopwatch watch; // 0x48
	private Vector3 prevCameraPos; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <smoothedCameraVel>k__BackingField; // 0x5C
	private float cameraVelSmoothSpeed; // 0x68
	private List<Sound> otherLocalSounds; // 0x70

	// Properties
	public Vector3 smoothedCameraVel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA74B30 Offset: 0xA73F30 VA: 0x180A74B30
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA74B50 Offset: 0xA73F50 VA: 0x180A74B50
	private void set_smoothedCameraVel(Vector3 value) { }

	// RVA: 0xA71CB0 Offset: 0xA710B0 VA: 0x180A71CB0 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA74330 Offset: 0xA73730 VA: 0x180A74330
	public void Update() { }

	// RVA: 0xA74030 Offset: 0xA73430 VA: 0x180A74030
	private void UpdateCameraVelocity() { }

	// RVA: 0xA73D10 Offset: 0xA73110 VA: 0x180A73D10
	private void StartPendingSoundPlayers() { }

	// RVA: 0xA73E20 Offset: 0xA73220 VA: 0x180A73E20
	private void StartScheduledSounds() { }

	// RVA: 0xA71BC0 Offset: 0xA70FC0 VA: 0x180A71BC0
	public static void AddPendingSoundPlayer(SoundPlayer player) { }

	// RVA: 0xA71AD0 Offset: 0xA70ED0 VA: 0x180A71AD0
	public static void AddBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA72CE0 Offset: 0xA720E0 VA: 0x180A72CE0
	public static void RemoveBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA73BB0 Offset: 0xA72FB0 VA: 0x180A73BB0
	public static SoundManager.ScheduledSound ScheduleOneshot(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

	// RVA: 0xA71D20 Offset: 0xA71120 VA: 0x180A71D20
	public static void CancelScheduledSound(SoundManager.ScheduledSound scheduledSound) { }

	// RVA: 0xA72770 Offset: 0xA71B70 VA: 0x180A72770
	public static Sound PlayOneshot(SoundDefinition def, GameObject targetParent, bool firstPerson = False, Vector3 position) { }

	// RVA: 0xA72DD0 Offset: 0xA721D0 VA: 0x180A72DD0
	public static Sound RequestSoundInstance(SoundDefinition def, GameObject targetParent, Vector3 position, bool firstPerson = False) { }

	// RVA: 0xA71E10 Offset: 0xA71210 VA: 0x180A71E10
	private Sound CreateSoundInstance(SoundDefinition def, GameObject targetParent, bool firstPerson, float cameraDistance) { }

	// RVA: 0xA72400 Offset: 0xA71800 VA: 0x180A72400
	private List<Sound> GetOtherLocalSoundInstances(SoundDefinition def, Vector3 pos, List<Sound> otherSounds) { }

	// RVA: 0xA72630 Offset: 0xA71A30 VA: 0x180A72630
	private GameObject GetSoundObject(SoundDefinition soundDef) { }

	// RVA: 0xA72A50 Offset: 0xA71E50 VA: 0x180A72A50
	public static void RecycleSound(Sound sound) { }

	// RVA: 0xA749C0 Offset: 0xA73DC0 VA: 0x180A749C0
	public void .ctor() { }

}

public class SoundManager.ScheduledSound // TypeDefIndex: 9033
{	// Fields
	public SoundDefinition def; // 0x10
	public float startTime; // 0x18
	public Vector3 position; // 0x1C
	public float volumeMod; // 0x28

	// Methods

	// RVA: 0xA6FF80 Offset: 0xA6F380 VA: 0x180A6FF80
	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

