public class DamageRenderer : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 11449
{
	[SerializeField]
	private List<Material> damageShowingMats;
	[SerializeField]
	private float maxDamageOpacity;
	[SerializeField]
	[HideInInspector]
	private List<DamageRenderer.DamageShowingRenderer> damageShowingRenderers;
	[SerializeField]
	[HideInInspector]
	private List<GlassPane> damageShowingGlassRenderers;
	private float prevHealth;
	private bool prevIsDead;
	private Color damageColour;
	private static MaterialPropertyBlock materialPB;
	private static MaterialPropertyBlock glassMaterialPB;
	public static int detailColorID;
	private static Material highlightMaterial;


	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void UpdateDamage(BaseCombatEntity bce) { }

	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	public void DrawHighlight() { }

	private void Highlight(Renderer renderer) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c

}

private struct DamageRenderer.DamageShowingRenderer // TypeDefIndex: 11450
{
	public Renderer renderer;
	public int[] indices;


	public void .ctor(Renderer renderer, int[] indices) { }

}

private struct DamageRenderer.<>c__DisplayClass12_0 // TypeDefIndex: 11451
{
	public List<int> matList;
	public DamageRenderer <>4__this;

}

