public class NVidiaReflex : MonoBehaviour // TypeDefIndex: 11982
{
	private uint previousIntervalUs;
	private int previousMode;
	private bool hasSimulationStarted;
	private bool prevUseMarkersToOptimize;
	private CommandBufferManager commandBufferManager;
	private CommandBufferDesc renderSubmitStart;
	private CommandBufferDesc renderSubmitEnd;

	public int intervalUs { get; }


	public int get_intervalUs() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void FixedUpdate() { }

	private void Update() { }

	private void LateUpdate() { }

	[IteratorStateMachineAttribute]
	private IEnumerator SleepCoroutine() { }

	private void OnRenderSubmitStart(CommandBuffer cb) { }

	private void OnRenderSubmitEnd(CommandBuffer cb) { }

	private void AfterPresent() { }

	private void TriggerFlash() { }

	private void PCLatencyPing() { }

	public static NVidiaReflex.NvReflex_Status IsReflexLowLatencySupported() { }

	public static NVidiaReflex.NvReflex_Status IsAutomaticReflexAnalyzerSupported() { }

	public static bool HasReceivedRenderEvent() { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_SetSleepMode(bool lowLatencyMode, uint minimumIntervalUs, bool lowLatencyBoost, bool markersOptimzation) { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_Sleep() { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_SetLatencyMarker(NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE marker, ulong frameID) { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_GetLatency(out NVidiaReflex.NvReflex_LATENCY_RESULT_PARAMS markers) { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_GetSleepStatus(out NVidiaReflex.NvReflex_GET_SLEEP_STATUS_PARAMS sleepStatusParams) { }

	public static extern int NvReflex_Plugin_GetEventIDForEvent(int inEvent) { }

	public static extern IntPtr NvReflex_Plugin_GetRenderEventAndDataFunc() { }

	public static extern bool NvReflex_Plugin_HasReceivedRenderEvent() { }

	public static extern NVidiaReflex.NvReflex_Status NvReflex_Plugin_GetDriverVersion(out uint ver) { }

	public void .ctor() { }

}

public enum NVidiaReflex.Mode // TypeDefIndex: 11983
{
	public int value__;
	public const NVidiaReflex.Mode OFF = 0;
	public const NVidiaReflex.Mode ON = 1;
	public const NVidiaReflex.Mode ON_PLUS_BOOST = 2;

}

public enum NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE // TypeDefIndex: 11984
{
	public int value__;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE SIMULATION_START = 0;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE SIMULATION_END = 1;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE RENDERSUBMIT_START = 2;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE RENDERSUBMIT_END = 3;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE PRESENT_START = 4;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE PRESENT_END = 5;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE INPUT_SAMPLE = 6;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE TRIGGER_FLASH = 7;
	public const NVidiaReflex.NvReflex_LATENCY_MARKER_TYPE PC_LATENCY_PING = 8;

}

public enum NVidiaReflex.NvReflex_Status // TypeDefIndex: 11985
{
	public int value__;
	public const NVidiaReflex.NvReflex_Status NvReflex_OK = 0;
	public const NVidiaReflex.NvReflex_Status NvReflex_ERROR = -1;
	public const NVidiaReflex.NvReflex_Status NvReflex_LIBRARY_NOT_FOUND = -2;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_IMPLEMENTATION = -3;
	public const NVidiaReflex.NvReflex_Status NvReflex_API_NOT_INITIALIZED = -4;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_ARGUMENT = -5;
	public const NVidiaReflex.NvReflex_Status NvReflex_NVIDIA_DEVICE_NOT_FOUND = -6;
	public const NVidiaReflex.NvReflex_Status NvReflex_END_ENUMERATION = -7;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_HANDLE = -8;
	public const NVidiaReflex.NvReflex_Status NvReflex_INCOMPATIBLE_STRUCT_VERSION = -9;
	public const NVidiaReflex.NvReflex_Status NvReflex_HANDLE_INVALIDATED = -10;
	public const NVidiaReflex.NvReflex_Status NvReflex_OPENGL_CONTEXT_NOT_CURRENT = -11;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_POINTER = -14;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_GL_EXPERT = -12;
	public const NVidiaReflex.NvReflex_Status NvReflex_INSTRUMENTATION_DISABLED = -13;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_GL_NSIGHT = -15;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_LOGICAL_GPU_HANDLE = -100;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_PHYSICAL_GPU_HANDLE = -101;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_DISPLAY_HANDLE = -102;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_COMBINATION = -103;
	public const NVidiaReflex.NvReflex_Status NvReflex_NOT_SUPPORTED = -104;
	public const NVidiaReflex.NvReflex_Status NvReflex_PORTID_NOT_FOUND = -105;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_UNATTACHED_DISPLAY_HANDLE = -106;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_PERF_LEVEL = -107;
	public const NVidiaReflex.NvReflex_Status NvReflex_DEVICE_BUSY = -108;
	public const NVidiaReflex.NvReflex_Status NvReflex_NV_PERSIST_FILE_NOT_FOUND = -109;
	public const NVidiaReflex.NvReflex_Status NvReflex_PERSIST_DATA_NOT_FOUND = -110;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_TV_DISPLAY = -111;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_TV_DISPLAY_ON_DCONNECTOR = -112;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_ACTIVE_SLI_TOPOLOGY = -113;
	public const NVidiaReflex.NvReflex_Status NvReflex_SLI_RENDERING_MODE_NOTALLOWED = -114;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_DIGITAL_FLAT_PANEL = -115;
	public const NVidiaReflex.NvReflex_Status NvReflex_ARGUMENT_EXCEED_MAX_SIZE = -116;
	public const NVidiaReflex.NvReflex_Status NvReflex_DEVICE_SWITCHING_NOT_ALLOWED = -117;
	public const NVidiaReflex.NvReflex_Status NvReflex_TESTING_CLOCKS_NOT_SUPPORTED = -118;
	public const NVidiaReflex.NvReflex_Status NvReflex_UNKNOWN_UNDERSCAN_CONFIG = -119;
	public const NVidiaReflex.NvReflex_Status NvReflex_TIMEOUT_RECONFIGURING_GPU_TOPO = -120;
	public const NVidiaReflex.NvReflex_Status NvReflex_DATA_NOT_FOUND = -121;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_ANALOG_DISPLAY = -122;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_VIDLINK = -123;
	public const NVidiaReflex.NvReflex_Status NvReflex_REQUIRES_REBOOT = -124;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_HYBRID_MODE = -125;
	public const NVidiaReflex.NvReflex_Status NvReflex_MIXED_TARGET_TYPES = -126;
	public const NVidiaReflex.NvReflex_Status NvReflex_SYSWOW64_NOT_SUPPORTED = -127;
	public const NVidiaReflex.NvReflex_Status NvReflex_IMPLICIT_SET_GPU_TOPOLOGY_CHANGE_NOT_ALLOWED = -128;
	public const NVidiaReflex.NvReflex_Status NvReflex_REQUEST_USER_TO_CLOSE_NON_MIGRATABLE_APPS = -129;
	public const NVidiaReflex.NvReflex_Status NvReflex_OUT_OF_MEMORY = -130;
	public const NVidiaReflex.NvReflex_Status NvReflex_WAS_STILL_DRAWING = -131;
	public const NVidiaReflex.NvReflex_Status NvReflex_FILE_NOT_FOUND = -132;
	public const NVidiaReflex.NvReflex_Status NvReflex_TOO_MANY_UNIQUE_STATE_OBJECTS = -133;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_CALL = -134;
	public const NVidiaReflex.NvReflex_Status NvReflex_D3D10_1_LIBRARY_NOT_FOUND = -135;
	public const NVidiaReflex.NvReflex_Status NvReflex_FUNCTION_NOT_FOUND = -136;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_USER_PRIVILEGE = -137;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_NON_PRIMARY_DISPLAY_HANDLE = -138;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXPECTED_COMPUTE_GPU_HANDLE = -139;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_NOT_INITIALIZED = -140;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_REGISTRY_ACCESS_FAILED = -141;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_REGISTRY_PROFILE_TYPE_NOT_SUPPORTED = -142;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_REGISTRY_VALUE_NOT_SUPPORTED = -143;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_NOT_ENABLED = -144;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_NOT_TURNED_ON = -145;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_INVALID_DEVICE_INTERFACE = -146;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_PARAMETER_OUT_OF_RANGE = -147;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_FRUSTUM_ADJUST_MODE_NOT_SUPPORTED = -148;
	public const NVidiaReflex.NvReflex_Status NvReflex_TOPO_NOT_POSSIBLE = -149;
	public const NVidiaReflex.NvReflex_Status NvReflex_MODE_CHANGE_FAILED = -150;
	public const NVidiaReflex.NvReflex_Status NvReflex_D3D11_LIBRARY_NOT_FOUND = -151;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_ADDRESS = -152;
	public const NVidiaReflex.NvReflex_Status NvReflex_STRING_TOO_SMALL = -153;
	public const NVidiaReflex.NvReflex_Status NvReflex_MATCHING_DEVICE_NOT_FOUND = -154;
	public const NVidiaReflex.NvReflex_Status NvReflex_DRIVER_RUNNING = -155;
	public const NVidiaReflex.NvReflex_Status NvReflex_DRIVER_NOTRUNNING = -156;
	public const NVidiaReflex.NvReflex_Status NvReflex_ERROR_DRIVER_RELOAD_REQUIRED = -157;
	public const NVidiaReflex.NvReflex_Status NvReflex_SET_NOT_ALLOWED = -158;
	public const NVidiaReflex.NvReflex_Status NvReflex_ADVANCED_DISPLAY_TOPOLOGY_REQUIRED = -159;
	public const NVidiaReflex.NvReflex_Status NvReflex_SETTING_NOT_FOUND = -160;
	public const NVidiaReflex.NvReflex_Status NvReflex_SETTING_SIZE_TOO_LARGE = -161;
	public const NVidiaReflex.NvReflex_Status NvReflex_TOO_MANY_SETTINGS_IN_PROFILE = -162;
	public const NVidiaReflex.NvReflex_Status NvReflex_PROFILE_NOT_FOUND = -163;
	public const NVidiaReflex.NvReflex_Status NvReflex_PROFILE_NAME_IN_USE = -164;
	public const NVidiaReflex.NvReflex_Status NvReflex_PROFILE_NAME_EMPTY = -165;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXECUTABLE_NOT_FOUND = -166;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXECUTABLE_ALREADY_IN_USE = -167;
	public const NVidiaReflex.NvReflex_Status NvReflex_DATATYPE_MISMATCH = -168;
	public const NVidiaReflex.NvReflex_Status NvReflex_PROFILE_REMOVED = -169;
	public const NVidiaReflex.NvReflex_Status NvReflex_UNREGISTERED_RESOURCE = -170;
	public const NVidiaReflex.NvReflex_Status NvReflex_ID_OUT_OF_RANGE = -171;
	public const NVidiaReflex.NvReflex_Status NvReflex_DISPLAYCONFIG_VALIDATION_FAILED = -172;
	public const NVidiaReflex.NvReflex_Status NvReflex_DPMST_CHANGED = -173;
	public const NVidiaReflex.NvReflex_Status NvReflex_INSUFFICIENT_BUFFER = -174;
	public const NVidiaReflex.NvReflex_Status NvReflex_ACCESS_DENIED = -175;
	public const NVidiaReflex.NvReflex_Status NvReflex_MOSAIC_NOT_ACTIVE = -176;
	public const NVidiaReflex.NvReflex_Status NvReflex_SHARE_RESOURCE_RELOCATED = -177;
	public const NVidiaReflex.NvReflex_Status NvReflex_REQUEST_USER_TO_DISABLE_DWM = -178;
	public const NVidiaReflex.NvReflex_Status NvReflex_D3D_DEVICE_LOST = -179;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_CONFIGURATION = -180;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_HANDSHAKE_NOT_DONE = -181;
	public const NVidiaReflex.NvReflex_Status NvReflex_EXECUTABLE_PATH_IS_AMBIGUOUS = -182;
	public const NVidiaReflex.NvReflex_Status NvReflex_DEFAULT_STEREO_PROFILE_IS_NOT_DEFINED = -183;
	public const NVidiaReflex.NvReflex_Status NvReflex_DEFAULT_STEREO_PROFILE_DOES_NOT_EXIST = -184;
	public const NVidiaReflex.NvReflex_Status NvReflex_CLUSTER_ALREADY_EXISTS = -185;
	public const NVidiaReflex.NvReflex_Status NvReflex_DPMST_DISPLAY_ID_EXPECTED = -186;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_DISPLAY_ID = -187;
	public const NVidiaReflex.NvReflex_Status NvReflex_STREAM_IS_OUT_OF_SYNC = -188;
	public const NVidiaReflex.NvReflex_Status NvReflex_INCOMPATIBLE_AUDIO_DRIVER = -189;
	public const NVidiaReflex.NvReflex_Status NvReflex_VALUE_ALREADY_SET = -190;
	public const NVidiaReflex.NvReflex_Status NvReflex_TIMEOUT = -191;
	public const NVidiaReflex.NvReflex_Status NvReflex_GPU_WORKSTATION_FEATURE_INCOMPLETE = -192;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_INIT_ACTIVATION_NOT_DONE = -193;
	public const NVidiaReflex.NvReflex_Status NvReflex_SYNC_NOT_ACTIVE = -194;
	public const NVidiaReflex.NvReflex_Status NvReflex_SYNC_MASTER_NOT_FOUND = -195;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_SYNC_TOPOLOGY = -196;
	public const NVidiaReflex.NvReflex_Status NvReflex_ECID_SIGN_ALGO_UNSUPPORTED = -197;
	public const NVidiaReflex.NvReflex_Status NvReflex_ECID_KEY_VERIFICATION_FAILED = -198;
	public const NVidiaReflex.NvReflex_Status NvReflex_FIRMWARE_OUT_OF_DATE = -199;
	public const NVidiaReflex.NvReflex_Status NvReflex_FIRMWARE_REVISION_NOT_SUPPORTED = -200;
	public const NVidiaReflex.NvReflex_Status NvReflex_LICENSE_CALLER_AUTHENTICATION_FAILED = -201;
	public const NVidiaReflex.NvReflex_Status NvReflex_D3D_DEVICE_NOT_REGISTERED = -202;
	public const NVidiaReflex.NvReflex_Status NvReflex_RESOURCE_NOT_ACQUIRED = -203;
	public const NVidiaReflex.NvReflex_Status NvReflex_TIMING_NOT_SUPPORTED = -204;
	public const NVidiaReflex.NvReflex_Status NvReflex_HDCP_ENCRYPTION_FAILED = -205;
	public const NVidiaReflex.NvReflex_Status NvReflex_PCLK_LIMITATION_FAILED = -206;
	public const NVidiaReflex.NvReflex_Status NvReflex_NO_CONNECTOR_FOUND = -207;
	public const NVidiaReflex.NvReflex_Status NvReflex_HDCP_DISABLED = -208;
	public const NVidiaReflex.NvReflex_Status NvReflex_API_IN_USE = -209;
	public const NVidiaReflex.NvReflex_Status NvReflex_NVIDIA_DISPLAY_NOT_FOUND = -210;
	public const NVidiaReflex.NvReflex_Status NvReflex_PRIV_SEC_VIOLATION = -211;
	public const NVidiaReflex.NvReflex_Status NvReflex_INCORRECT_VENDOR = -212;
	public const NVidiaReflex.NvReflex_Status NvReflex_DISPLAY_IN_USE = -213;
	public const NVidiaReflex.NvReflex_Status NvReflex_UNSUPPORTED_CONFIG_NON_HDCP_HMD = -214;
	public const NVidiaReflex.NvReflex_Status NvReflex_MAX_DISPLAY_LIMIT_REACHED = -215;
	public const NVidiaReflex.NvReflex_Status NvReflex_INVALID_DIRECT_MODE_DISPLAY = -216;
	public const NVidiaReflex.NvReflex_Status NvReflex_GPU_IN_DEBUG_MODE = -217;
	public const NVidiaReflex.NvReflex_Status NvReflex_D3D_CONTEXT_NOT_FOUND = -218;
	public const NVidiaReflex.NvReflex_Status NvReflex_STEREO_VERSION_MISMATCH = -219;
	public const NVidiaReflex.NvReflex_Status NvReflex_GPU_NOT_POWERED = -220;
	public const NVidiaReflex.NvReflex_Status NvReflex_ERROR_DRIVER_RELOAD_IN_PROGRESS = -221;
	public const NVidiaReflex.NvReflex_Status NvReflex_WAIT_FOR_HW_RESOURCE = -222;
	public const NVidiaReflex.NvReflex_Status NvReflex_REQUIRE_FURTHER_HDCP_ACTION = -223;
	public const NVidiaReflex.NvReflex_Status NvReflex_DISPLAY_MUX_TRANSITION_FAILED = -224;

}

public struct NVidiaReflex.NvReflex_FrameReport // TypeDefIndex: 11986
{
	public ulong frameID;
	public ulong inputSampleTime;
	public ulong simStartTime;
	public ulong simEndTime;
	public ulong renderSubmitStartTime;
	public ulong renderSubmitEndTime;
	public ulong presentStartTime;
	public ulong presentEndTime;
	public ulong driverStartTime;
	public ulong driverEndTime;
	public ulong osRenderQueueStartTime;
	public ulong osRenderQueueEndTime;
	public ulong gpuRenderStartTime;
	public ulong gpuRenderEndTime;

}

public struct NVidiaReflex.NvReflex_LATENCY_RESULT_PARAMS // TypeDefIndex: 11987
{
	public NVidiaReflex.NvReflex_FrameReport[] frameReport;

}

public struct NVidiaReflex.NvReflex_GET_SLEEP_STATUS_PARAMS // TypeDefIndex: 11988
{
	public byte bLowLatencyMode;

}

private sealed class NVidiaReflex.<SleepCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11989
{
	private int <>1__state;
	private object <>2__current;
	public NVidiaReflex <>4__this;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

