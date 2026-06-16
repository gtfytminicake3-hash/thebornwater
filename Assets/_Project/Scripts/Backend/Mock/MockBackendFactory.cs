namespace TheBonwater.Rebuild
{
    public static class MockBackendFactory
    {
        public static IGameBackend Create() => new MockBackend();
    }
}