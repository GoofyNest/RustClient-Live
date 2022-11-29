public class BaseBulb : MonoBehaviour // TypeDefIndex: 10546
{
	public Renderer bulbRenderer; 
	private static readonly int timeOffsetHash; 
	private static readonly int bulbIndexHash; 
	private static readonly int modeHash; 
	private AdvancedChristmasLights.AnimationType currentAnimationType; 
	private float timeOffset; 
	private int bulbIndex; 
	private bool isOn; 
	private MaterialPropertyBlock materialPropertyBlock; 


	public virtual void SetOn(bool wantsOn) { }

	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	private void UpdateMaterialProperties() { }

	public void .ctor() { }

	private static void .cctor() { }

}

