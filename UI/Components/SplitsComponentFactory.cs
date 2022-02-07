using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class SplitsComponentFactory : IComponentFactory
    {
        public string ComponentName => "Splits w/ Counter";

        public string Description => "Splits with a Counter. Made by Minibeast.";

        public ComponentCategory Category => ComponentCategory.List;

        public IComponent Create(LiveSplitState state) => new SplitsComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.8.10");
    }
}
