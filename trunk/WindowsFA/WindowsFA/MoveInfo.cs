namespace WindowsFA
{
   using System;

   /// <summary>
   ///    Summary description for MoveInfo.
   /// </summary>
   public class MoveInfo
   {
      public double fxMove;	           // Fraction to move at each compass point:X
      public double fyMove;              //                                        Y
      public double fMagnify;            // Fraction to grow or shrink at each compass point (X and Y)
   
      public MoveInfo()
      {
      }    
   
      public void setMoveInfo(double fNewXMove, double fNewYMove, double fNewMagnify)
      {
         fxMove = fNewXMove;
         fyMove = fNewYMove;
         fMagnify = fNewMagnify;
      }      
   }
}
