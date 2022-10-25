using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;
using MapGeneration.Distributors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace scp096keycard_IsIllegal
{
    public class EventHandler
    {

        #region Constructor & Destructor
        internal EventHandler()
        {
            AttachEvent();
        }
        #endregion

        #region Methods
        public void AttachEvent()
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnWhaitForPlayer;
        }

        public void DetachEvent()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnWhaitForPlayer;
        }
        #endregion

        #region Events
        //@AccessDev Oui je fait cella en mode bourrin mais ça fonctionne ¯\_(˶′◡′˶)_/¯
        private void OnWhaitForPlayer()
        {
            var hcz096 = Room.Get(Exiled.API.Enums.RoomType.Hcz096);

            Map.Pickups.First(p =>
                p.Type == ItemType.KeycardNTFLieutenant &&
                Vector3.Distance(p.Position, hcz096.Position) < 25).Destroy();
        }
        #endregion
    }
}