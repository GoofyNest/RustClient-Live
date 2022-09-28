public class SoundManager : SingletonComponent<SoundManager>, IClientComponent // TypeDefIndex: 10704
{
	public SoundClass defaultSoundClass; 
	public Dictionary<SoundDefinition, List<Sound>> activeSoundsByDef; 
	public List<ISoundBudgetedUpdate> budgetUpdatables; 
	public List<SoundPlayer> pendingSoundPlayers; 
	private List<SoundManager.ScheduledSound> scheduledSounds; 
	private int updatableIndex; 
	private Stopwatch watch; 
	private Vector3 prevCameraPos; 
	[CompilerGeneratedAttribute] 
	private Vector3 <smoothedCameraVel>k__BackingField; 
	private float cameraVelSmoothSpeed; 
	private List<Sound> otherLocalSounds; 

	public Vector3 smoothedCameraVel { get; set; }


	[CompilerGeneratedAttribute] 
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] 
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

public class SoundManager.ScheduledSound // TypeDefIndex: 10705
{
	public SoundDefinition def; 
	public float startTime; 
	public Vector3 position; 
	public float volumeMod; 


	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

