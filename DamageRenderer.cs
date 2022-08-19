public class DamageRenderer : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 9707
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<Material> damageShowingMats; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxDamageOpacity; // 0x20
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private List<DamageRenderer.DamageShowingRenderer> damageShowingRenderers; // 0x28
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private List<GlassPane> damageShowingGlassRenderers; // 0x30
	private float prevHealth; // 0x38
	private bool prevIsDead; // 0x3C
	private Color damageColour; // 0x40
	private static MaterialPropertyBlock materialPB; // 0x0
	private static MaterialPropertyBlock glassMaterialPB; // 0x8
	public static int detailColorID; // 0x10
	private static Material highlightMaterial; // 0x18

	// Methods

	// RVA: 0x523890 Offset: 0x522C90 VA: 0x180523890 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5247D0 Offset: 0x523BD0 VA: 0x1805247D0
	public void UpdateDamage(BaseCombatEntity bce) { }

	// RVA: 0x524710 Offset: 0x523B10 VA: 0x180524710
	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	// RVA: 0x524050 Offset: 0x523450 VA: 0x180524050
	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	// RVA: 0x524450 Offset: 0x523850 VA: 0x180524450
	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	// RVA: 0x523090 Offset: 0x522490 VA: 0x180523090
	public void DrawHighlight() { }

	// RVA: 0x5232B0 Offset: 0x5226B0 VA: 0x1805232B0
	private void Highlight(Renderer renderer) { }

	// RVA: 0x524910 Offset: 0x523D10 VA: 0x180524910
	public void .ctor() { }

	// RVA: 0x5248C0 Offset: 0x523CC0 VA: 0x1805248C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5245D0 Offset: 0x5239D0 VA: 0x1805245D0
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c__DisplayClass12_0 ) { }

}

private struct DamageRenderer.DamageShowingRenderer // TypeDefIndex: 9708
{	// Fields
	public Renderer renderer; // 0x0
	public int[] indices; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	public void .ctor(Renderer renderer, int[] indices) { }

}

private struct DamageRenderer.<>c__DisplayClass12_0 // TypeDefIndex: 9709
{	// Fields
	public List<int> matList; // 0x0
	public DamageRenderer <>4__this; // 0x8

}

