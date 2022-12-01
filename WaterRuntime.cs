public class WaterRuntime // TypeDefIndex: 12380
{
	[CompilerGeneratedAttribute]
	private WaterCamera <WaterCamera>k__BackingField;
	[CompilerGeneratedAttribute]
	private Camera <Camera>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostOpaqueDepth <PostOpaqueDepth>k__BackingField;
	[CompilerGeneratedAttribute]
	private CommandBufferManager <CommandBufferManager>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <SimulateNextFrame>k__BackingField;
	[CompilerGeneratedAttribute]
	private WaterSimulation <Simulation>k__BackingField;
	[CompilerGeneratedAttribute]
	private WaterRendering <Rendering>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <VisibilityMask>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IsInitialized>k__BackingField;

	public WaterCamera WaterCamera { get; set; }
	public Camera Camera { get; set; }
	public PostOpaqueDepth PostOpaqueDepth { get; set; }
	public CommandBufferManager CommandBufferManager { get; set; }
	public bool SimulateNextFrame { get; set; }
	public WaterSimulation Simulation { get; set; }
	public WaterRendering Rendering { get; set; }
	public int VisibilityMask { get; set; }
	public bool IsInitialized { get; set; }


	[CompilerGeneratedAttribute]
	private void set_WaterCamera(WaterCamera value) { }

	[CompilerGeneratedAttribute]
	public WaterCamera get_WaterCamera() { }

	[CompilerGeneratedAttribute]
	private void set_Camera(Camera value) { }

	[CompilerGeneratedAttribute]
	public Camera get_Camera() { }

	[CompilerGeneratedAttribute]
	private void set_PostOpaqueDepth(PostOpaqueDepth value) { }

	[CompilerGeneratedAttribute]
	public PostOpaqueDepth get_PostOpaqueDepth() { }

	[CompilerGeneratedAttribute]
	private void set_CommandBufferManager(CommandBufferManager value) { }

	[CompilerGeneratedAttribute]
	public CommandBufferManager get_CommandBufferManager() { }

	[CompilerGeneratedAttribute]
	private void set_SimulateNextFrame(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_SimulateNextFrame() { }

	[CompilerGeneratedAttribute]
	private void set_Simulation(WaterSimulation value) { }

	[CompilerGeneratedAttribute]
	public WaterSimulation get_Simulation() { }

	[CompilerGeneratedAttribute]
	private void set_Rendering(WaterRendering value) { }

	[CompilerGeneratedAttribute]
	public WaterRendering get_Rendering() { }

	[CompilerGeneratedAttribute]
	private void set_VisibilityMask(int value) { }

	[CompilerGeneratedAttribute]
	public int get_VisibilityMask() { }

	[CompilerGeneratedAttribute]
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_IsInitialized() { }

	public void .ctor(WaterCamera camera) { }

	public void Initialize(WaterSystem water) { }

	public void Shutdown() { }

	public void SetVisibilityMask(int mask) { }

	private void Simulate() { }

	private void PrepareRender() { }

	public void Update() { }

	public void IssueRender() { }

}

