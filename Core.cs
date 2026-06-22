using System;

public static class Core
{

    public struct stGameInfo
    {
        public int NumOfRounds;
        public int StartRange;
        public int EndRange;
    }

   public  enum enCurrentRoundStatus { eWin=1,eLose=2}

    public static stGameInfo  GameInfo; 

    public static bool IsUserInput_InRange(int value)// to check if the user input in range or not 
    {
      return (value >= GameInfo.StartRange && value<=GameInfo.EndRange) ? true : false;
    }

    private static int ComputerNum()
    {
        Random rnd = new Random();
        return rnd.Next(GameInfo.StartRange, GameInfo.EndRange);
    }

   public static enCurrentRoundStatus CheckUserAnswer(int value)//to check user's answer 
    {
        return (ComputerNum() == value) ? enCurrentRoundStatus.eWin : enCurrentRoundStatus.eLose;
    }



}