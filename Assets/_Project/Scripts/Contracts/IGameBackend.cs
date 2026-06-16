namespace TheBonwater.Rebuild {
    public interface IGameBackend {
        CommandResult Execute(GameCommand command);
        GameSnapshot GetSnapshot();
        TheBonwater.Rebuild.Data.DataRepository repo { get; }
    }
}
