public class SceneManager // TypeDefIndex: 3659
{
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private static UnityAction<Scene> sceneUnloaded;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static UnityAction<Scene, Scene> activeSceneChanged;

	public static int sceneCount { get; }


	[NativeHeaderAttribute]
	[NativeMethodAttribute]
	[StaticAccessorAttribute]
	public static int get_sceneCount() { }

	[StaticAccessorAttribute]
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute]
	public static Scene GetSceneByName(string name) { }

	[StaticAccessorAttribute]
	[NativeThrowsAttribute]
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute]
	[StaticAccessorAttribute]
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[StaticAccessorAttribute]
	[NativeThrowsAttribute]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[NativeThrowsAttribute]
	[StaticAccessorAttribute]
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute]
	[StaticAccessorAttribute]
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute]
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute]
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	public static Scene CreateScene(string sceneName) { }

	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute]
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

