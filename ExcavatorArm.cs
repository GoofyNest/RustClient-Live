public class ExcavatorArm : BaseEntity // TypeDefIndex: 10111
{
	private Option __menuOption_Menu_TargetHQM;
	private Option __menuOption_Menu_TargetMetal;
	private Option __menuOption_Menu_TargetStone;
	private Option __menuOption_Menu_TargetSulfur;
	public float yaw1;
	public float yaw2;
	public Transform wheel;
	public float wheelSpeed;
	public float turnSpeed;
	public Transform miningOffset;
	public GameObjectRef bounceEffect;
	public LightGroupAtTime lights;
	public Material conveyorMaterial;
	public float beltSpeedMax;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public List<ExcavatorOutputPile> outputPiles;
	public SoundDefinition miningStartButtonSoundDef;
	[HeaderAttribute]
	public ItemAmount[] resourcesToMine;
	public float resourceProductionTickRate;
	public float timeForFullResources;
	private ItemAmount[] pendingResources;
	public Translate.Phrase excavatorPhrase;
	private float wheelRotation;
	private float nextBounceTime;
	private float currentWheelTurnSpeed;
	private float currentBeltSpeed;
	private float currentBeltOffset;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPowered() { }

	public bool IsMining() { }

	public override float GetExtrapolationTime() { }

	public override void PostNetworkUpdate() { }

	public void SetLightStatus(bool wantsOn) { }

	public void Update() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TargetHQM(BasePlayer player) { }

	public bool Menu_TargetHQM_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TargetSulfur(BasePlayer player) { }

	public bool Menu_TargetSulfur_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TargetStone(BasePlayer player) { }

	public bool Menu_TargetStone_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TargetMetal(BasePlayer player) { }

	public bool Menu_TargetMetal_ShowIf(BasePlayer player) { }

	private void PlayMiningStartButtonSound(Vector3 position) { }

	public void .ctor() { }

}

