public class ArcadeEntityController : BaseMonoBehaviour // TypeDefIndex: 8760
{	// Fields
	public BaseArcadeGame parentGame; // 0x18
	public ArcadeEntity arcadeEntity; // 0x20
	public ArcadeEntity sourceEntity; // 0x28
	private bool authorative; // 0x30

	// Properties
	public Vector3 heading { get; set; }
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }

	// Methods

	// RVA: 0x82A010 Offset: 0x829410 VA: 0x18082A010
	public Vector3 get_heading() { }

	// RVA: 0x82A0E0 Offset: 0x8294E0 VA: 0x18082A0E0
	public void set_heading(Vector3 value) { }

	// RVA: 0x82A040 Offset: 0x829440 VA: 0x18082A040
	public Vector3 get_positionLocal() { }

	// RVA: 0x82A110 Offset: 0x829510 VA: 0x18082A110
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x82A090 Offset: 0x829490 VA: 0x18082A090
	public Vector3 get_positionWorld() { }

	// RVA: 0x82A160 Offset: 0x829560 VA: 0x18082A160
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x829A90 Offset: 0x828E90 VA: 0x180829A90
	public void SetOwnerGame(BaseArcadeGame ownerGame) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void Initialize() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool IsAuthorative() { }

	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	public void SetAuthorative(bool wants) { }

	// RVA: 0x829F40 Offset: 0x829340 VA: 0x180829F40
	public void SetSprite(Sprite newSprite) { }

	// RVA: 0x829F90 Offset: 0x829390 VA: 0x180829F90 Slot: 7
	public virtual void Shutdown() { }

	// RVA: 0x829E90 Offset: 0x829290 VA: 0x180829E90
	public void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x829930 Offset: 0x828D30 VA: 0x180829930
	public void SetHeading(Vector3 heading) { }

	// RVA: 0x829E20 Offset: 0x829220 VA: 0x180829E20
	public void SetPositionLocal(Vector3 newPos) { }

	// RVA: 0x829900 Offset: 0x828D00 VA: 0x180829900
	public void OnDisable() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

