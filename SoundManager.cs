public class SoundManager : SingletonComponent<SoundManager>, IClientComponent // TypeDefIndex: 9032
{	public SoundClass defaultSoundClass; // 0x18
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

	public Vector3 smoothedCameraVel { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_smoothedCameraVel(Vector3 value) { }

	protected override void Awake() { }

	public void Update() { }

	private void UpdateCameraVelocity() { }

	private void StartPendingSoundPlayers() { }

	private void StartScheduledSounds() { }

	public static void AddPendingSoundPlayer(SoundPlayer player) { }

	public static void AddBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	public static void RemoveBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	public static SoundManager.ScheduledSound ScheduleOneshot(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

	public static void CancelScheduledSound(SoundManager.ScheduledSound scheduledSound) { }

	public static Sound PlayOneshot(SoundDefinition def, GameObject targetParent, bool firstPerson = False, Vector3 position) { }

	public static Sound RequestSoundInstance(SoundDefinition def, GameObject targetParent, Vector3 position, bool firstPerson = False) { }

	private Sound CreateSoundInstance(SoundDefinition def, GameObject targetParent, bool firstPerson, float cameraDistance) { }

	private List<Sound> GetOtherLocalSoundInstances(SoundDefinition def, Vector3 pos, List<Sound> otherSounds) { }

	private GameObject GetSoundObject(SoundDefinition soundDef) { }

	public static void RecycleSound(Sound sound) { }

	public void .ctor() { }

}

public class SoundManager.ScheduledSound // TypeDefIndex: 9033
{	public SoundDefinition def; // 0x10
	public float startTime; // 0x18
	public Vector3 position; // 0x1C
	public float volumeMod; // 0x28


	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

