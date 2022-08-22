internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10


	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }


	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	public IVisualTreeUpdater get_Item(int index) { }

}

