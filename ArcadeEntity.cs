public class ArcadeEntity : BaseMonoBehaviour // TypeDefIndex: 10467
{
	public uint id; 
	public uint spriteID; 
	public uint soundID; 
	public bool visible; 
	public Vector3 heading; 
	public bool isEnabled; 
	public bool dirty; 
	public float alpha; 
	public BoxCollider boxCollider; 
	public bool host; 
	public bool localAuthorativeOverride; 
	public ArcadeEntity arcadeEntityParent; 
	public uint prefabID; 
	[HeaderAttribute] 
	public bool takesDamage; 
	public float health; 
	public float maxHealth; 
	public bool mapLoadedEntiy; 
	private Sprite spriteRef; 
	protected BaseArcadeGame arcadeGameParent; 
	private ArcadeEntityController controller; 
	public static uint PARENTID_INVALID; 
	public ArcadeGame.arcadeEnt savedState; 

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

