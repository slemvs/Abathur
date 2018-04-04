﻿using System.Collections.Generic;

namespace Abathur.Constants {
    public static class GameConstants {
        private static ISet<uint> MorphedUnits = new HashSet<uint> {
            BlizzardConstants.Unit.Baneling,
            BlizzardConstants.Unit.Drone,
            BlizzardConstants.Unit.Zergling,
            BlizzardConstants.Unit.Roach,
            BlizzardConstants.Unit.Ravager,
            BlizzardConstants.Unit.Hydralisk,
            BlizzardConstants.Unit.Lurker,
            BlizzardConstants.Unit.Infestor,
            BlizzardConstants.Unit.SwarmHost,
            BlizzardConstants.Unit.Ultralisk,
            BlizzardConstants.Unit.Overlord,
            BlizzardConstants.Unit.Overseer,
            BlizzardConstants.Unit.Mutalisk,
            BlizzardConstants.Unit.Corruptor,
            BlizzardConstants.Unit.BroodLord,
            BlizzardConstants.Unit.Viper,
            BlizzardConstants.Unit.Lair,
            BlizzardConstants.Unit.Hive,
            BlizzardConstants.Unit.LurkerDen,
            BlizzardConstants.Unit.GreaterSpire,
            BlizzardConstants.Unit.OverlordTransport,
            BlizzardConstants.Unit.OrbitalCommand,
            BlizzardConstants.Unit.PlanetaryFortress,
            BlizzardConstants.Unit.Archon,
            BlizzardConstants.Unit.WarpGate
        };
        private static ISet<uint> Cocoons = new HashSet<uint> {
            BlizzardConstants.Unit.BanelingCocoon,
            BlizzardConstants.Unit.BroodLordCocoon,
            BlizzardConstants.Unit.DevourerCocoon,
            BlizzardConstants.Unit.GuardianCocoon,
            BlizzardConstants.Unit.OverlordCocoon,
            BlizzardConstants.Unit.RavagerCocoon,
            BlizzardConstants.Unit.TransportOverlordCocoon,
            BlizzardConstants.Unit.Egg

        };

        /// <summary>
        /// Refinery (20), Extractor (88) and Assimilator (61)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type refinery.</returns>
        public static bool IsRefinery(uint id) => id == BlizzardConstants.Unit.Refinery || id == BlizzardConstants.Unit.Extractor || id == BlizzardConstants.Unit.Assimilator;

        /// <summary>
        /// Larva (151)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type larva.</returns>
        public static bool IsLarva(uint id) => id == BlizzardConstants.Unit.Larva;

        /// <summary>
        /// SCV (45), Probe (84), Drone (104) or DroneBurrowed (116)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type worker.</returns>
        public static bool IsWorker(uint id) => id == BlizzardConstants.Unit.SCV || id == BlizzardConstants.Unit.Probe || id == BlizzardConstants.Unit.Drone || id == BlizzardConstants.Unit.DroneBurrowed;
       
        /// <summary>
        /// Minerals have different IDs depending on the game map (due to theme)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type mineral field.</returns>
        public static bool IsMineralField(uint id) => id == 146 || id == 147 || id == 341 || id == 483 || id == 885 || id == 884 || id == 665 || id == 666;
        
        /// <summary>
        /// Vespene Geysers have different IDs depending on the game map (due to theme)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type vespene geyser.</returns>
        public static bool IsVepeneGeyser(uint id) => id == 342 || id == 344 || id == 343 || id == 880 || id == 608;

        /// <summary>
        /// Check if the the structure is the vespene building for any race.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>True if the ID is a refinery, assimilator or extractor</returns>
        public static bool IsVespeneGeyserBuilding(uint id) => id == 20 || id == 61 || id == 88;
        
        /// <summary>
        /// XelNagaTower (149)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type Xel Naga Tower.</returns>
        public static bool IsXelNagaTower(uint id) => id == 149;

        /// <summary>
        /// All IDs between 362 and 377 is (path) blocking and destructible. 
        /// IDs ranging from 472 - 474 is (placement) blocking and destructible.
        /// IDs ranging from 623 - 658 is (placement) blocking and destructible.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type destructible and blocks pathing.</returns>
        public static bool IsDestructible(uint id) => (361 < id && id < 378) || (472 <= id && id <= 474) || (623 <= id && id <= 658);

        /// <summary>
        /// TechLab (5), BarracksTechLab (37), FactoryTechLab (39) or StarPortTechLab (41)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type tech lab.</returns>
        public static bool IsTechLab(uint id) => id == BlizzardConstants.Unit.TechLab || id == BlizzardConstants.Unit.BarracksTechLab || id == BlizzardConstants.Unit.FactoryTechLab || id == BlizzardConstants.Unit.StarportTechLab;
        
        /// <summary>
        /// Reactor (6), BarracksReactor (38), FactoryReactor (40) or StarPortReactor (42)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type reactor.</returns>
        public static bool IsReactor(uint id) => id == BlizzardConstants.Unit.Reactor || id == BlizzardConstants.Unit.BarracksReactor || id == BlizzardConstants.Unit.FactoryReactor || id == BlizzardConstants.Unit.StarportReactor;

        /// <summary>
        /// Can this structure produce an add-on (techlab or reactor)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID can produce reactor or techlab.</returns>
        public static bool IsAddOnProducer(uint id) => id == BlizzardConstants.Unit.Barracks || id == BlizzardConstants.Unit.Factory || id == BlizzardConstants.Unit.Stargate;

        /// <summary>
        /// Check if the ability is for building a reactor.
        /// </summary>
        /// <param name="abilityId">Ability ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is the ability id of a reactor.</returns>
        public static bool IsReactorAbility(uint abilityId) => abilityId == BlizzardConstants.Unit.ReactorAbility || abilityId == BlizzardConstants.Unit.BarracksReactorAbility || abilityId == BlizzardConstants.Unit.FactoryReactorAbility || abilityId == BlizzardConstants.Unit.StarportReactorAbility;

        /// <summary>
        /// Check if the id corrosponds to a structure producing workers (HQ).
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is a Headquarter</returns>
        public static bool IsHeadquarter(uint id) => id == BlizzardConstants.Unit.Nexus ||
            id == BlizzardConstants.Unit.Hatchery || id == BlizzardConstants.Unit.Lair || id == BlizzardConstants.Unit.Hive ||
            id == BlizzardConstants.Unit.CommandCenter || id == BlizzardConstants.Unit.OrbitalCommand || id == BlizzardConstants.Unit.PlanetaryFortress;
        
        /// <summary>
        /// Check if the unit ID is a techlab or reactor.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type add-on.</returns>
        public static bool IsAddon(uint id) => IsReactor(id) || IsTechLab(id);

        /// <summary>
        /// Check if the unit ID is a morphed type.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type requires morphing from another unit</returns>
        public static bool IsMorphed(uint id) => MorphedUnits.Contains(id);

        /// <summary>
        /// Check if the unit ID requires an attached techlab in order to be build.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type requires attached techlab</returns>
        public static bool RequiresTechLab(uint id) => RequiresBarrackTechlab(id) || RequiresFactoryTechlab(id) || RequiresStarportTechLab(id);
        
        /// <summary>
        /// Check if the unit ID requires barracks with techlab.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type requires attached techlab</returns>
        public static bool RequiresBarrackTechlab(uint id) => id == BlizzardConstants.Unit.Marauder || id == BlizzardConstants.Unit.Ghost;
        
        /// <summary>
        /// Check if the unit ID requires factory with techlab.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type requires attached techlab</returns>
        public static bool RequiresFactoryTechlab(uint id) => id == BlizzardConstants.Unit.SiegeTank || id == BlizzardConstants.Unit.Thor;
        /// <summary>
        /// Check if the unit ID requires starport with techlab.
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is of the type requires attached techlab</returns>
        public static bool RequiresStarportTechLab(uint id) => id == BlizzardConstants.Unit.Raven || id == BlizzardConstants.Unit.Banshee || id == BlizzardConstants.Unit.Battlecruiser;

        /// <summary>
        /// Returns true if the unit id is cocoon (Zerg unit morphing)
        /// </summary>
        /// <param name="id">UnitType ID as defined by Blizzard</param>
        /// <returns>Returns true if the ID is a cocoon type</returns>
        public static bool IsCocoon(uint id) => Cocoons.Contains(id);
    }
}
