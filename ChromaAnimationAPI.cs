public class ChromaAnimationAPI // TypeDefIndex: 7675
{	// Fields
	private const string DLL_NAME = "CChromaEditorLibrary64";

	// Methods

	// RVA: 0x21B8F90 Offset: 0x21B8390 VA: 0x1821B8F90
	public static int CoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9030 Offset: 0x21B8430 VA: 0x1821B9030
	public static int CoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B90D0 Offset: 0x21B84D0 VA: 0x1821B90D0
	public static int CoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9170 Offset: 0x21B8570 VA: 0x1821B9170
	public static int CoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9210 Offset: 0x21B8610 VA: 0x1821B9210
	public static int CoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B92B0 Offset: 0x21B86B0 VA: 0x1821B92B0
	public static int CoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9350 Offset: 0x21B8750 VA: 0x1821B9350
	public static int CoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21B95C0 Offset: 0x21B89C0 VA: 0x1821B95C0
	public static int CoreInit() { }

	// RVA: 0x21B93E0 Offset: 0x21B87E0 VA: 0x1821B93E0
	public static int CoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21B9630 Offset: 0x21B8A30 VA: 0x1821B9630
	public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21B96D0 Offset: 0x21B8AD0 VA: 0x1821B96D0
	public static int CoreSetEffect(Guid effectId) { }

	// RVA: 0x21B9760 Offset: 0x21B8B60 VA: 0x1821B9760
	public static int CoreUnInit() { }

	// RVA: 0x21B8F90 Offset: 0x21B8390 VA: 0x1821B8F90
	private static extern int PluginCoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9030 Offset: 0x21B8430 VA: 0x1821B9030
	private static extern int PluginCoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B90D0 Offset: 0x21B84D0 VA: 0x1821B90D0
	private static extern int PluginCoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9170 Offset: 0x21B8570 VA: 0x1821B9170
	private static extern int PluginCoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9210 Offset: 0x21B8610 VA: 0x1821B9210
	private static extern int PluginCoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B92B0 Offset: 0x21B86B0 VA: 0x1821B92B0
	private static extern int PluginCoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21B9350 Offset: 0x21B8750 VA: 0x1821B9350
	private static extern int PluginCoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21B95C0 Offset: 0x21B89C0 VA: 0x1821B95C0
	private static extern int PluginCoreInit() { }

	// RVA: 0x21B93E0 Offset: 0x21B87E0 VA: 0x1821B93E0
	private static extern int PluginCoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21B9630 Offset: 0x21B8A30 VA: 0x1821B9630
	private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21B96D0 Offset: 0x21B8AD0 VA: 0x1821B96D0
	private static extern int PluginCoreSetEffect(Guid effectId) { }

	// RVA: 0x21B9760 Offset: 0x21B8B60 VA: 0x1821B9760
	private static extern int PluginCoreUnInit() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

