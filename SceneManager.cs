public class SceneManager // TypeDefIndex: 3656
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static UnityAction<Scene> sceneUnloaded; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x10

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeHeaderAttribute] // RVA: 0xE5BC0 Offset: 0xE4FC0 VA: 0x1800E5BC0
	[NativeMethodAttribute] // RVA: 0xE5BC0 Offset: 0xE4FC0 VA: 0x1800E5BC0
	[StaticAccessorAttribute] // RVA: 0xE5BC0 Offset: 0xE4FC0 VA: 0x1800E5BC0
	// RVA: 0x19AF2F0 Offset: 0x19AE6F0 VA: 0x1819AF2F0
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5D90 Offset: 0xE5190 VA: 0x1800E5D90
	// RVA: 0x19AEB40 Offset: 0x19ADF40 VA: 0x1819AEB40
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5D90 Offset: 0xE5190 VA: 0x1800E5D90
	// RVA: 0x19AEC60 Offset: 0x19AE060 VA: 0x1819AEC60
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	[StaticAccessorAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	// RVA: 0x19AEBC0 Offset: 0x19ADFC0 VA: 0x1819AEBC0
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	[StaticAccessorAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	// RVA: 0x19AEAB0 Offset: 0x19ADEB0 VA: 0x1819AEAB0
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	[StaticAccessorAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	// RVA: 0x19AF1C0 Offset: 0x19AE5C0 VA: 0x1819AF1C0
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[NativeThrowsAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	[StaticAccessorAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	// RVA: 0x19AEE40 Offset: 0x19AE240 VA: 0x1819AEE40
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	[StaticAccessorAttribute] // RVA: 0xE6080 Offset: 0xE5480 VA: 0x1800E6080
	// RVA: 0x19AF140 Offset: 0x19AE540 VA: 0x1819AF140
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AF240 Offset: 0x19AE640 VA: 0x1819AF240
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AF320 Offset: 0x19AE720 VA: 0x1819AF320
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	// RVA: 0x19AEA60 Offset: 0x19ADE60 VA: 0x1819AEA60
	public static Scene CreateScene(string sceneName) { }

	// RVA: 0x19AF040 Offset: 0x19AE440 VA: 0x1819AF040
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x19AEFA0 Offset: 0x19AE3A0 VA: 0x1819AEFA0
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19AEF40 Offset: 0x19AE340 VA: 0x1819AEF40
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AEEA0 Offset: 0x19AE2A0 VA: 0x1819AEEA0
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x19AEEF0 Offset: 0x19AE2F0 VA: 0x1819AEEF0
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19AF200 Offset: 0x19AE600 VA: 0x1819AF200
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AED10 Offset: 0x19AE110 VA: 0x1819AED10
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AED70 Offset: 0x19AE170 VA: 0x1819AED70
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AECB0 Offset: 0x19AE0B0 VA: 0x1819AECB0
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x19AEB00 Offset: 0x19ADF00 VA: 0x1819AEB00
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x19AEC10 Offset: 0x19AE010 VA: 0x1819AEC10
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x19AEB80 Offset: 0x19ADF80 VA: 0x1819AEB80
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x19AEA00 Offset: 0x19ADE00 VA: 0x1819AEA00
	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0x19AF180 Offset: 0x19AE580 VA: 0x1819AF180
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x19AEDD0 Offset: 0x19AE1D0 VA: 0x1819AEDD0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x19AF0F0 Offset: 0x19AE4F0 VA: 0x1819AF0F0
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

