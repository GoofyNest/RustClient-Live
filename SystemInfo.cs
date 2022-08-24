public sealed class SystemInfo // TypeDefIndex: 3556
{
public static BatteryStatus batteryStatus { get; }
public static string operatingSystem { get; }
public static OperatingSystemFamily operatingSystemFamily { get; }
public static string processorType { get; }
public static int processorFrequency { get; }
public static int processorCount { get; }
public static int systemMemorySize { get; }
public static string deviceUniqueIdentifier { get; }
public static string deviceName { get; }
public static string deviceModel { get; }
public static DeviceType deviceType { get; }
public static int graphicsMemorySize { get; }
public static string graphicsDeviceName { get; }
public static string graphicsDeviceVendor { get; }
public static GraphicsDeviceType graphicsDeviceType { get; }
public static bool graphicsUVStartsAtTop { get; }
public static string graphicsDeviceVersion { get; }
public static int graphicsShaderLevel { get; }
public static bool graphicsMultiThreaded { get; }
	[ObsoleteAttribute] 
public static bool supportsRenderTextures { get; }
public static bool supportsMotionVectors { get; }
	[ObsoleteAttribute] 
public static bool supportsImageEffects { get; }
public static bool supports3DTextures { get; }
public static bool supports3DRenderTextures { get; }
public static CopyTextureSupport copyTextureSupport { get; }
public static bool supportsComputeShaders { get; }
public static bool supportsInstancing { get; }
public static int supportedRenderTargetCount { get; }
public static int supportedRandomWriteTargetCount { get; }
public static bool usesReversedZBuffer { get; }
public static bool supportsAsyncGPUReadback { get; }
public static bool supportsMipStreaming { get; }


public static BatteryStatus get_batteryStatus() { }

public static string get_operatingSystem() { }

public static OperatingSystemFamily get_operatingSystemFamily() { }

public static string get_processorType() { }

public static int get_processorFrequency() { }

public static int get_processorCount() { }

public static int get_systemMemorySize() { }

public static string get_deviceUniqueIdentifier() { }

public static string get_deviceName() { }

public static string get_deviceModel() { }

public static DeviceType get_deviceType() { }

public static int get_graphicsMemorySize() { }

public static string get_graphicsDeviceName() { }

public static string get_graphicsDeviceVendor() { }

public static GraphicsDeviceType get_graphicsDeviceType() { }

public static bool get_graphicsUVStartsAtTop() { }

public static string get_graphicsDeviceVersion() { }

public static int get_graphicsShaderLevel() { }

public static bool get_graphicsMultiThreaded() { }

public static bool get_supportsRenderTextures() { }

public static bool get_supportsMotionVectors() { }

public static bool get_supportsImageEffects() { }

public static bool get_supports3DTextures() { }

public static bool get_supports3DRenderTextures() { }

public static CopyTextureSupport get_copyTextureSupport() { }

public static bool get_supportsComputeShaders() { }

public static bool get_supportsInstancing() { }

public static int get_supportedRenderTargetCount() { }

public static int get_supportedRandomWriteTargetCount() { }

public static bool get_usesReversedZBuffer() { }

private static bool IsValidEnumValue(Enum value) { }

public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

public static bool SupportsTextureFormat(TextureFormat format) { }

public static bool get_supportsAsyncGPUReadback() { }

public static bool get_supportsMipStreaming() { }

	[FreeFunctionAttribute] 
private static BatteryStatus GetBatteryStatus() { }

	[FreeFunctionAttribute] 
private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] 
private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] 
private static string GetProcessorType() { }

	[FreeFunctionAttribute] 
private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] 
private static int GetProcessorCount() { }

	[FreeFunctionAttribute] 
private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] 
private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] 
private static string GetDeviceName() { }

	[FreeFunctionAttribute] 
private static string GetDeviceModel() { }

	[FreeFunctionAttribute] 
private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] 
private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] 
private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] 
private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] 
private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] 
private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] 
private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] 
private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] 
private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] 
private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] 
private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] 
private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] 
private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] 
private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] 
private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] 
private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] 
private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] 
private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] 
private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] 
private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] 
private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] 
private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] 
public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] 
public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] 
public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

