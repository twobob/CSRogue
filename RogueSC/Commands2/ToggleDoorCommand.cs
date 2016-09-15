﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSRogue.GameControl.Commands;
using CSRogue.Interfaces;
using CSRogue.Map_Generation;
using CSRogue.Utilities;
using Microsoft.Xna.Framework;
using Game = CSRogue.GameControl.Game;

namespace RogueSC.Commands
{
    class ToggleDoorCommand : IRogueCommand
    {
        private ICreature _agent;
        private MapCoordinates _doorLocation;
        internal ToggleDoorCommand(ICreature agent, MapCoordinates doorLocation)
        {
            _doorLocation = doorLocation;
            _agent = agent;
        }

        public void Execute(Game game)
        {
            SCMap scMap = (SCMap) game.Map;

            foreach (var doorLoc in scMap.Neighbors(scMap.Player.Location).Where(l => scMap[l].Terrain == TerrainType.Door))
            {
                if (scMap[doorLoc].Items.Count == 0)
                {
                    scMap[doorLoc].ToggleDoor();
                }
            }
            var moveCmd = new MovePlayerCommand(new MapCoordinates());
            game.EnqueueAndProcess(moveCmd);
        }
    }
}
