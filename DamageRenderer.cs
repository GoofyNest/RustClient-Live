public class DamageRenderer : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 9707
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void UpdateDamage(BaseCombatEntity bce) { }

	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	public void DrawHighlight() { }

	private void Highlight(Renderer renderer) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c__DisplayClass12_0 ) { }

}

private struct DamageRenderer.DamageShowingRenderer // TypeDefIndex: 9708
{	public Renderer renderer; // 0x0
	public int[] indices; // 0x8


	public void .ctor(Renderer renderer, int[] indices) { }

}

private struct DamageRenderer.<>c__DisplayClass12_0 // TypeDefIndex: 9709
{	public List<int> matList; // 0x0
	public DamageRenderer <>4__this; // 0x8

}

