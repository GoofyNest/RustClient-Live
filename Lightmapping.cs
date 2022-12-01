public static class Lightmapping // TypeDefIndex: 3893
{
	[RequiredByNativeCodeAttribute]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate;
	[RequiredByNativeCodeAttribute]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;


	[RequiredByNativeCodeAttribute]
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute]
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute]
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute]
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3894
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3895
{
	public static readonly Lightmapping.<>c <>9;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>

}

