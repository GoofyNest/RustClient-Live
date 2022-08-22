public class ArcadeEntity : BaseMonoBehaviour // TypeDefIndex: 8759
{	public uint id; // 0x18
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

	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }


	public bool IsMapEntity() { }

	public void SendEntityMessage(string msg) { }

	public virtual bool OnEntityMessage(string msg, bool predicted = False) { }

	public void OnNewChild(ArcadeEntity newChild) { }

	public void OnChildUnparented(ArcadeEntity lostChild) { }

	public void OnNewParent() { }

	public void OnUnparented() { }

	public void Remove() { }

	public void SetArcadeParent(ArcadeEntity desiredParent) { }

	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	public virtual void OnKilled() { }

	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	public bool IsAuthorative() { }

	public void SetLocalAuthorative(bool wants) { }

	public Vector3 get_positionLocal() { }

	public void set_positionLocal(Vector3 value) { }

	public Vector3 get_positionWorld() { }

	public void set_positionWorld(Vector3 value) { }

	public void SetController(ArcadeEntityController newController) { }

	public ArcadeEntityController GetController() { }

	public virtual void AuthorativeThink(float delta) { }

	public virtual void SlaveThink(float delta) { }

	public void MarkDirty() { }

	public virtual void Initialize() { }

	public void OnDestroy() { }

	public void Shutdown() { }

	public virtual void SetArcadeGameParent(BaseArcadeGame newParent) { }

	public void SetupCollider(int type, Vector3 scale) { }

	public virtual void UpdateSave(bool force = False) { }

	public virtual void Load(ArcadeGame.arcadeEnt proto) { }

	public virtual void PostLoad() { }

	public virtual void SetPositionWorld(Vector3 newPos) { }

	public virtual void SetVisible(bool wantsVis) { }

	public virtual bool IsVisible() { }

	public void .ctor() { }

	private static void .cctor() { }

}

