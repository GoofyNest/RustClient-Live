public class GameObjectLOD : LODComponent // TypeDefIndex: 9926
{	// Fields
	public float Distance; // 0x80
	public GameObject TargetGameObject; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x6F6070 Offset: 0x6F5470 VA: 0x1806F6070 Slot: 13
	protected override void Show() { }

	// RVA: 0x6F5FE0 Offset: 0x6F53E0 VA: 0x1806F5FE0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C4810 Offset: 0x4C3C10 VA: 0x1804C4810 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C46C0 Offset: 0x4C3AC0 VA: 0x1804C46C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x6F6100 Offset: 0x6F5500 VA: 0x1806F6100
	public void .ctor() { }

}

