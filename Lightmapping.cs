public static class Lightmapping // TypeDefIndex: 3888
{	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182C6B0 Offset: 0x182BAB0 VA: 0x18182C6B0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182C510 Offset: 0x182B910 VA: 0x18182C510
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182C640 Offset: 0x182BA40 VA: 0x18182C640
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182C570 Offset: 0x182B970 VA: 0x18182C570
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x182C740 Offset: 0x182BB40 VA: 0x18182C740
	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3889
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x180BAC0 Offset: 0x180AEC0 VA: 0x18180BAC0 Slot: 12
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x182D7D0 Offset: 0x182CBD0 VA: 0x18182D7D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3890
{	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x13B00

	// Methods

	// RVA: 0x182E290 Offset: 0x182D690 VA: 0x18182E290
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x182DEB0 Offset: 0x182D2B0 VA: 0x18182DEB0
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

}

