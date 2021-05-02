public class Game
{
  //private fields
  private string _name;
  private int _pointTotal;
  private string _stateOfMind;

  //constructor
  public Game(string name)
  {
    _name = name;
    _pointTotal = 0;
    _stateOfMind = "neutral";
  }

  // Getters and Setters for feilds
  public string GetName()
  {
    return _name;
  }

  public void SetName(string name)
  {
    _name = name;
  }

  public int GetPointTotal()
  {
    return _pointTotal;
  }
      
  public void SetPointTotal()
  {
    _pointTotal = pointTotal;
  }

  public string GetStateOfMind()
  {
    return _stateOfMind
  }

  public void SetStateOfMind()
  {
    _stateOfMind = stateOfMind;
  }

  //// Public method 
  public void DetermineNextSteps()
  {
    IncreasePoints();
    UpdateMood();
    IsGameOver();
  }

  // private methods
  private void IncreasePoints()
  {
    _pointTotal++;
  }

  private void UpdateMood()
  {
    if(_pointTotal < 3)
    {
      _stateOfMind = "neautral";
    }
    else if (_pointTotal <6)
    {
      _stateOfMind = "happy";
    }
    else
    {
      _stateOfMind = "Thrilled";
    }
  }

  private string IsGameOver()
  {
    if(_stateOfMind == "thrilled")
    {
      return "You Win";
    }
    else
    {
      return "Keep Playing..";
    }
  }
}
