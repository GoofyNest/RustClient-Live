public class BaseBulb : MonoBehaviour // TypeDefIndex: 8824
{	public Renderer bulbRenderer; // 0x18
	private static readonly int timeOffsetHash; // 0x0
	private static readonly int bulbIndexHash; // 0x4
	private static readonly int modeHash; // 0x8
	private AdvancedChristmasLights.AnimationType currentAnimationType; // 0x20
	private float timeOffset; // 0x24
	private int bulbIndex; // 0x28
	private bool isOn; // 0x2C
	private MaterialPropertyBlock materialPropertyBlock; // 0x30


	public virtual void SetOn(bool wantsOn) { }

	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	private void UpdateMaterialProperties() { }

	public void .ctor() { }

	private static void .cctor() { }

}

