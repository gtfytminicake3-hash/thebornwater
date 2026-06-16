namespace TheBonwater.Rebuild {
    public static class GameServiceLocator {
        public static IGameBackend Backend { get; private set; }
        public static void RegisterBackend(IGameBackend backend) => Backend = backend;
    }
}
