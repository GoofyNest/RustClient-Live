public class WorldModelOutline : OutlineObject // TypeDefIndex: 10094
{	// Fields
	private CoverageQueries.Query query; // 0x30
	private const float coverageRadius = 0,06;
	private float currentOcclusion; // 0x38

	// Methods

	// RVA: 0x8AAFE0 Offset: 0x8AA3E0 VA: 0x1808AAFE0 Slot: 7
	public override Color GetColor() { }

	// RVA: 0x8AB4B0 Offset: 0x8AA8B0 VA: 0x1808AB4B0
	public void OnEnable() { }

	// RVA: 0x8AB420 Offset: 0x8AA820 VA: 0x1808AB420
	public void OnDisable() { }

	// RVA: 0x8AAFB0 Offset: 0x8AA3B0 VA: 0x1808AAFB0 Slot: 5
	public override void BecomeVisible() { }

	// RVA: 0x8AAFA0 Offset: 0x8AA3A0 VA: 0x1808AAFA0 Slot: 6
	public override void BecomeInvisible() { }

	// RVA: 0x8AB920 Offset: 0x8AAD20 VA: 0x1808AB920 Slot: 9
	public override bool ShouldDisplay() { }

	// RVA: 0x8AB370 Offset: 0x8AA770 VA: 0x1808AB370 Slot: 10
	public virtual float GetSmoothOcclusion() { }

	// RVA: 0x8AB5D0 Offset: 0x8AA9D0 VA: 0x1808AB5D0 Slot: 11
	public virtual float SampleOcclusion() { }

	// RVA: 0x8AB840 Offset: 0x8AAC40 VA: 0x1808AB840 Slot: 4
	public override float SampleVisibility() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

