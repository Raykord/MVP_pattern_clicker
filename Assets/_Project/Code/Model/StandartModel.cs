using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartModel : Model
{
    public StandartModel(View view, PlayerData playerData) : base(view, playerData)
    {
    }

    public override void IncreaceScore()
    {
        _playerData.score++;
        _view.DisplayScore(score: _playerData.score);
    }

    
}
