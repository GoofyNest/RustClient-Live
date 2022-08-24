internal class ContextLevelActivator : IActivator // TypeDefIndex: 1205
{
	private IActivator m_NextActivator; 

	public IActivator NextActivator { get; }


	public void .ctor(IActivator next) { }

	public IActivator get_NextActivator() { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

