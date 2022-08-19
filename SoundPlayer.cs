public class SoundPlayer : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9039
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public bool playImmediately; // 0x20
	public float minStartDelay; // 0x24
	public float maxStartDelay; // 0x28
	public bool debugRepeat; // 0x2C
	public bool pending; // 0x2D
	public Vector3 soundOffset; // 0x30
	private int playOnFrame; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sound <sound>k__BackingField; // 0x40

	// Properties
	public Sound sound { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Sound get_sound() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	protected void set_sound(Sound value) { }

	// RVA: 0xA76350 Offset: 0xA75750 VA: 0x180A76350
	protected void Awake() { }

	// RVA: 0xA76AD0 Offset: 0xA75ED0 VA: 0x180A76AD0
	protected void OnEnable() { }

	// RVA: 0xA76680 Offset: 0xA75A80 VA: 0x180A76680
	public void DoPendingUpdate() { }

	// RVA: 0xA77050 Offset: 0xA76450 VA: 0x180A77050
	public bool ShouldStartThisFrame() { }

	// RVA: 0xA76F60 Offset: 0xA76360 VA: 0x180A76F60
	public void Play() { }

	// RVA: 0xA76EB0 Offset: 0xA762B0 VA: 0x180A76EB0
	public void PlayOneshot() { }

	// RVA: 0xA76C30 Offset: 0xA76030 VA: 0x180A76C30
	public void PlayOneshotRandomDelay(float min = 0, float max = 1) { }

	// RVA: 0xA766F0 Offset: 0xA75AF0 VA: 0x180A766F0
	public void FadeInAndPlay(float time = 0,5) { }

	// RVA: 0xA76790 Offset: 0xA75B90 VA: 0x180A76790
	public void FadeOutAndRecycle(float time = 0,5) { }

	// RVA: 0xA76400 Offset: 0xA75800 VA: 0x180A76400 Slot: 7
	public virtual void CreateSound() { }

	// RVA: 0xA76920 Offset: 0xA75D20 VA: 0x180A76920
	public bool IsPlaying() { }

	// RVA: 0xA768C0 Offset: 0xA75CC0 VA: 0x180A768C0
	public bool HasSound() { }

	// RVA: 0xA765D0 Offset: 0xA759D0 VA: 0x180A765D0
	public void DestroySound() { }

	// RVA: 0xA77080 Offset: 0xA76480 VA: 0x180A77080
	public void Stop() { }

	// RVA: 0xA76A40 Offset: 0xA75E40 VA: 0x180A76A40
	public void MakeThirdPerson() { }

	// RVA: 0xA769B0 Offset: 0xA75DB0 VA: 0x180A769B0
	public void MakeFirstPerson() { }

	// RVA: 0xA76830 Offset: 0xA75C30 VA: 0x180A76830
	public float GetLength() { }

	// RVA: 0x807130 Offset: 0x806530 VA: 0x180807130 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0xA77100 Offset: 0xA76500 VA: 0x180A77100
	public void .ctor() { }

}

