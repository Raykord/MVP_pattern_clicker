using UnityEngine;

public abstract class Presenter 
{
    protected Model _model;

    public Presenter(Model model)
    {
        _model = model;
    }


    public void OnTargetClicked()
    {
        _model.IncreaceScore();
    }
}
