namespace TheBonwater.Rebuild {
    public abstract class GameCommand { }
    public class StartNewGameCommand : GameCommand { }
    public class AdvanceTimeCommand : GameCommand { }
    public class AssignWorkerCommand : GameCommand { }
    public class SaveGameCommand : GameCommand { }
    public class LoadGameCommand : GameCommand { }
    public class CollectWoodCommand : GameCommand { }
    public class BuildHutCommand : GameCommand { }
    public class BuildGuardTowerCommand : GameCommand { }
    public class BuildStorageCommand : GameCommand {}
    public class ForceRaidCommand : GameCommand {}
    public class SelectNextVillagerCommand : GameCommand {}
    public class SpawnVillagerCommand : GameCommand {}
    public class AssignVillagerJobCommand : GameCommand {
        public string villagerId;
        public string jobId;
    }
    public class SelectVillagerCommand : GameCommand {
        public string villagerId;
    }
}