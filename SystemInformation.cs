public struct SystemInformation // TypeDefIndex: 6205
{
	public SystemInformation.Hardware hardware; 
	public SystemInformation.Environment environment; 

}

public struct SystemInformation.Hardware // TypeDefIndex: 6206
{
	public string deviceName { get; }
	public string operatingSystem { get; }
	public string processorType { get; }
	public string processorCount { get; }
	public string systemMemorySize { get; }
	public string graphicsDeviceName { get; }
	public string graphicsDeviceVersion { get; }
	public string graphicsMemorySize { get; }
	public string graphicsShaderLevel { get; }
	public string graphicsDeviceType { get; }
	public string deviceUniqueIdentifier { get; }
	public string graphicsDeviceVendor { get; }
	public bool graphicsMultiThreaded { get; }
	public int processorFrequency { get; }
	public string processorArchitecture { get; }


	public string get_deviceName() { }

	public string get_operatingSystem() { }

	public string get_processorType() { }

	public string get_processorCount() { }

	public string get_systemMemorySize() { }

	public string get_graphicsDeviceName() { }

	public string get_graphicsDeviceVersion() { }

	public string get_graphicsMemorySize() { }

	public string get_graphicsShaderLevel() { }

	public string get_graphicsDeviceType() { }

	public string get_deviceUniqueIdentifier() { }

	public string get_graphicsDeviceVendor() { }

	public bool get_graphicsMultiThreaded() { }

	public int get_processorFrequency() { }

	public string get_processorArchitecture() { }

}

public struct SystemInformation.Environment // TypeDefIndex: 6207
{
	public string unityVersion { get; }
	public string version { get; }
	public string companyName { get; }
	public bool isEditor { get; }
	public bool isPlayer { get; }
	public string systemLanguage { get; }
	public int targetFrameRate { get; }
	public Resolution currentResolution { get; }
	public int screenWidth { get; }
	public int screenHeight { get; }
	public bool fullScreen { get; }
	public string anisotropicFiltering { get; }
	public string antiAliasing { get; }
	public string qualityLevel { get; }
	public string globalMaximumLOD { get; }
	public string lodBias { get; }
	public string maximumLODLevel { get; }
	public string particleRaycastBudget { get; }
	public string pixelLightCount { get; }
	public string realtimeReflectionProbes { get; }
	public string shadowCascades { get; }
	public string shadowDistance { get; }
	public string softVegetation { get; }
	public string vSyncCount { get; }


	public string get_unityVersion() { }

	public string get_version() { }

	public string get_companyName() { }

	public bool get_isEditor() { }

	public bool get_isPlayer() { }

	public string get_systemLanguage() { }

	public int get_targetFrameRate() { }

	public Resolution get_currentResolution() { }

	public int get_screenWidth() { }

	public int get_screenHeight() { }

	public bool get_fullScreen() { }

	public string get_anisotropicFiltering() { }

	public string get_antiAliasing() { }

	public string get_qualityLevel() { }

	public string get_globalMaximumLOD() { }

	public string get_lodBias() { }

	public string get_maximumLODLevel() { }

	public string get_particleRaycastBudget() { }

	public string get_pixelLightCount() { }

	public string get_realtimeReflectionProbes() { }

	public string get_shadowCascades() { }

	public string get_shadowDistance() { }

	public string get_softVegetation() { }

	public string get_vSyncCount() { }

}

