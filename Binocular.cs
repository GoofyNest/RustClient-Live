public class Binocular : AttackEntity // TypeDefIndex: 9461
{	// Fields
	public float[] fovs; // 0x280
	public GameObjectRef fovChangeEffect; // 0x288
	public float smoothSpeed; // 0x290
	private bool vmVisible; // 0x294
	private bool isAiming; // 0x295
	private float timeAiming; // 0x298
	private int currentFovIndex; // 0x29C

	// Methods

	// RVA: 0x52B510 Offset: 0x52A910 VA: 0x18052B510
	public bool IsAiming() { }

	// RVA: 0x52B530 Offset: 0x52A930 VA: 0x18052B530 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x52BA80 Offset: 0x52AE80 VA: 0x18052BA80 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x52B220 Offset: 0x52A620 VA: 0x18052B220
	public void ClearOverlays() { }

	// RVA: 0x52B610 Offset: 0x52AA10 VA: 0x18052B610 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x52B280 Offset: 0x52A680 VA: 0x18052B280
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x52BD50 Offset: 0x52B150 VA: 0x18052BD50
	public void SetViewmodelVisiblity(bool visible) { }

	// RVA: 0x52BAF0 Offset: 0x52AEF0 VA: 0x18052BAF0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x52BE60 Offset: 0x52B260 VA: 0x18052BE60
	public void .ctor() { }

}

