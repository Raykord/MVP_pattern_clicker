

public abstract class Model
{
    protected View _view;
    protected PlayerData _playerData;
    protected int score;

    public Model(View view, PlayerData playerData)
    {
        _view = view;
        _playerData = playerData;
        playerData.score = score;
    }

    public abstract void IncreaceScore();
}
