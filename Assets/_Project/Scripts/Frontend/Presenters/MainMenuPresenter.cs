namespace TheBonwater.Rebuild
{
    public static class MainMenuPresenter
    {
        public static void OnNewGame() => GameServiceLocator.Backend.Execute(new StartNewGameCommand());
        public static void OnLoadGame() => GameServiceLocator.Backend.Execute(new LoadGameCommand());
    }
}