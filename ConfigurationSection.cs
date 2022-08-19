public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
	// Methods

	// RVA: 0x231C740 Offset: 0x231BB40 VA: 0x18231C740 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x231C770 Offset: 0x231BB70 VA: 0x18231C770 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x231C7A0 Offset: 0x231BBA0 VA: 0x18231C7A0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x231C7D0 Offset: 0x231BBD0 VA: 0x18231C7D0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

