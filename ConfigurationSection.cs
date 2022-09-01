public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{

public abstract class ConfigurationSection : ConfigurationElement

	protected internal virtual void DeserializeSection(XmlReader reader) { }

	protected internal override bool IsModified() { }

	protected internal override void ResetModified() { }

	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

