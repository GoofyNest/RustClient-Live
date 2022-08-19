public class DecalCull : LODComponent // TypeDefIndex: 9925
{	// Fields
	public float Distance; // 0x80
	private DeferredDecal decal; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x8E5CF0 Offset: 0x8E50F0 VA: 0x1808E5CF0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x8E5D40 Offset: 0x8E5140 VA: 0x1808E5D40 Slot: 13
	protected override void Show() { }

	// RVA: 0x8E5CC0 Offset: 0x8E50C0 VA: 0x1808E5CC0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C4810 Offset: 0x4C3C10 VA: 0x1804C4810 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C46C0 Offset: 0x4C3AC0 VA: 0x1804C46C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x8E5D70 Offset: 0x8E5170 VA: 0x1808E5D70
	public void .ctor() { }

}

