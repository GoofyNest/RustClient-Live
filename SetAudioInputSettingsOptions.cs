public struct SetAudioInputSettingsOptions // TypeDefIndex: 8708
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <DeviceId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Volume>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <PlatformAEC>k__BackingField; 

	public ProductUserId LocalUserId { get; set; }
	public Utf8String DeviceId { get; set; }
	public float Volume { get; set; }
	public bool PlatformAEC { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_DeviceId() { }

	[CompilerGeneratedAttribute] 
	public void set_DeviceId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public float get_Volume() { }

	[CompilerGeneratedAttribute] 
	public void set_Volume(float value) { }

	[CompilerGeneratedAttribute] 
	public bool get_PlatformAEC() { }

	[CompilerGeneratedAttribute] 
	public void set_PlatformAEC(bool value) { }

}

