public class ArcadeEntity : BaseMonoBehaviour // TypeDefIndex: 8759
{	// Fields
	public uint id; // 0x18
	public uint spriteID; // 0x1C
	public uint soundID; // 0x20
	public bool visible; // 0x24
	public Vector3 heading; // 0x28
	public bool isEnabled; // 0x34
	public bool dirty; // 0x35
	public float alpha; // 0x38
	public BoxCollider boxCollider; // 0x40
	public bool host; // 0x48
	public bool localAuthorativeOverride; // 0x49
	public ArcadeEntity arcadeEntityParent; // 0x50
	public uint prefabID; // 0x58
	[HeaderAttribute] // RVA: 0xBE300 Offset: 0xBD700 VA: 0x1800BE300
	public bool takesDamage; // 0x5C
	public float health; // 0x60
	public float maxHealth; // 0x64
	public bool mapLoadedEntiy; // 0x68
	private Sprite spriteRef; // 0x70
	protected BaseArcadeGame arcadeGameParent; // 0x78
	private ArcadeEntityController controller; // 0x80
	public static uint PARENTID_INVALID; // 0x0
	public ArcadeGame.arcadeEnt savedState; // 0x88

	// Properties
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }

	// Methods

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool IsMapEntity() { }

	// RVA: 0x82B260 Offset: 0x82A660 VA: 0x18082B260
	public void SendEntityMessage(string msg) { }

	// RVA: 0x82AB50 Offset: 0x829F50 VA: 0x18082AB50 Slot: 6
	public virtual bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnNewChild(ArcadeEntity newChild) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnChildUnparented(ArcadeEntity lostChild) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnNewParent() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnUnparented() { }

	// RVA: 0x82AED0 Offset: 0x82A2D0 VA: 0x18082AED0
	public void Remove() { }

	// RVA: 0x82B310 Offset: 0x82A710 VA: 0x18082B310
	public void SetArcadeParent(ArcadeEntity desiredParent) { }

	// RVA: 0x82A230 Offset: 0x829630 VA: 0x18082A230 Slot: 7
	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void OnKilled() { }

	// RVA: 0x82A1B0 Offset: 0x8295B0 VA: 0x18082A1B0
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x82A5C0 Offset: 0x8299C0 VA: 0x18082A5C0
	public bool IsAuthorative() { }

	// RVA: 0x82B450 Offset: 0x82A850 VA: 0x18082B450
	public void SetLocalAuthorative(bool wants) { }

	// RVA: 0x82BB00 Offset: 0x82AF00 VA: 0x18082BB00
	public Vector3 get_positionLocal() { }

	// RVA: 0x82BB50 Offset: 0x82AF50 VA: 0x18082BB50
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 get_positionWorld() { }

	// RVA: 0x82BBA0 Offset: 0x82AFA0 VA: 0x18082BBA0
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	public void SetController(ArcadeEntityController newController) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public ArcadeEntityController GetController() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void AuthorativeThink(float delta) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void SlaveThink(float delta) { }

	// RVA: 0x82AAC0 Offset: 0x829EC0 VA: 0x18082AAC0
	public void MarkDirty() { }

	// RVA: 0x82A270 Offset: 0x829670 VA: 0x18082A270 Slot: 11
	public virtual void Initialize() { }

	// RVA: 0x82AAD0 Offset: 0x829ED0 VA: 0x18082AAD0
	public void OnDestroy() { }

	// RVA: 0x82B530 Offset: 0x82A930 VA: 0x18082B530
	public void Shutdown() { }

	// RVA: 0x82B2A0 Offset: 0x82A6A0 VA: 0x18082B2A0 Slot: 12
	public virtual void SetArcadeGameParent(BaseArcadeGame newParent) { }

	// RVA: 0x82B4F0 Offset: 0x82A8F0 VA: 0x18082B4F0
	public void SetupCollider(int type, Vector3 scale) { }

	// RVA: 0x82B7C0 Offset: 0x82ABC0 VA: 0x18082B7C0 Slot: 13
	public virtual void UpdateSave(bool force = False) { }

	// RVA: 0x82A670 Offset: 0x829A70 VA: 0x18082A670 Slot: 14
	public virtual void Load(ArcadeGame.arcadeEnt proto) { }

	// RVA: 0x82AB60 Offset: 0x829F60 VA: 0x18082AB60 Slot: 15
	public virtual void PostLoad() { }

	// RVA: 0x82B460 Offset: 0x82A860 VA: 0x18082B460 Slot: 16
	public virtual void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	public virtual void SetVisible(bool wantsVis) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	public virtual bool IsVisible() { }

	// RVA: 0x82BA90 Offset: 0x82AE90 VA: 0x18082BA90
	public void .ctor() { }

	// RVA: 0x82BA50 Offset: 0x82AE50 VA: 0x18082BA50
	private static void .cctor() { }

}

