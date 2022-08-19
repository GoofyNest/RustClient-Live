internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	// Fields
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0x22F2530 Offset: 0x22F1930 VA: 0x1822F2530
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x22F2400 Offset: 0x22F1800 VA: 0x1822F2400
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	public IVisualTreeUpdater get_Item(int index) { }

}

