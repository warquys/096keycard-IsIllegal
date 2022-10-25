using Exiled.API.Features;
using System;

namespace scp096keycard_IsIllegal
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "096keycard_IsIllegal";
        public override string Name => "096 keycard is illegal";
        public override string Author => "VT";
        public override Version Version { get; } = new Version(1, 0, 0);

        public EventHandler EventHandler { get; private set; }

        public override void OnEnabled()
        {
            base.OnEnabled();
            if (EventHandler == null)
                EventHandler = new EventHandler();
            else
                EventHandler.AttachEvent();
        }

        public override void OnDisabled()
        {
            EventHandler.DetachEvent();
            base.OnDisabled();
        }

    }
}