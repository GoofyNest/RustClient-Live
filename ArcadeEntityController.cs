public class ArcadeEntityController : BaseMonoBehaviour // TypeDefIndex: 8760
{	public BaseArcadeGame parentGame; // 0x18
	public ArcadeEntity arcadeEntity; // 0x20
	public ArcadeEntity sourceEntity; // 0x28
	private bool authorative; // 0x30

	public Vector3 heading { get; set; }
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }


	public Vector3 get_heading() { }

	public void set_heading(Vector3 value) { }

	public Vector3 get_positionLocal() { }

	public void set_positionLocal(Vector3 value) { }

	public Vector3 get_positionWorld() { }

	public void set_positionWorld(Vector3 value) { }

	public void SetOwnerGame(BaseArcadeGame ownerGame) { }

	public virtual void Initialize() { }

	public bool IsAuthorative() { }

	public void SetAuthorative(bool wants) { }

	public void SetSprite(Sprite newSprite) { }

	public virtual void Shutdown() { }

	public void SetPositionWorld(Vector3 newPos) { }

	public void SetHeading(Vector3 heading) { }

	public void SetPositionLocal(Vector3 newPos) { }

	public void OnDisable() { }

	public void .ctor() { }

}

