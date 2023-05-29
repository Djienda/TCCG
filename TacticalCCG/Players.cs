namespace TacticalCCG
{
    public class Player
    {
        public PlayerData Data { get; private set; }
        TurnManager _turnManager;
        IPlayerView _view;


        public Player(TurnManager turnManager, IPlayerView view, PlayerData data)
        {
            _turnManager = turnManager;
            _view = view;
            Data = data;
        }

        public void Open()
        {
            _view.SetPlayer(this);
            _view.Show();
        }
    }
}