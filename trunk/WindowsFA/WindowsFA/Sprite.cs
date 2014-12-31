namespace WindowsFA
{
   using System;
   using System.Drawing; 

   /// <summary>
   ///    Class to support moving a 'sprite' around onscreen.
   /// </summary>
   /// 
   public class Sprite
   {
      // Constants' go here.
      protected const int POINTS_ON_COMPASS = 8;

      protected const float MIN_MAGNIFY = (float)0.75;   // Defines how small we can shrink our sprites: A/B 
      protected const float MAX_MAGNIFY = (float)4.0;   // Defines how large sprites can grow.
                       	
      protected const int TOP_EDGE = 0x0001;
      protected const int RIGHT_EDGE = 0x0002;
      protected const int BOTTOM_EDGE = 0x0004;
      protected const int LEFT_EDGE = 0x0008;
                            
      protected const int FRONT_EDGE = 0x0010;
      protected const int BACK_EDGE = 0x0020;

      protected const int SPRITE_TOO_SMALL = BACK_EDGE;
      protected const int SPRITE_TOO_BIG = FRONT_EDGE;                              
  
      // These constants are used to move and scale bitmaps
      // for each of the 8 points on the compass.                 
                  
      // Front (S)                   
      protected const float X1   	= (float)-0.0078; 
      protected const float Y1   	= (float)-0.0078; 
      protected const float MAG1 	= (float)1.0078; 

      // Front-Left (SW)
      protected const float X2  	= (float)-0.0391;  
      protected const float Y2   	= (float)0.0078156; 
      protected const float MAG2 	= (float)1.0156; 
                  
      // Left (W)                  
      protected const float X3 	   = (float)-0.0937;
      protected const float Y3 	   = (float)0.0;
      protected const float MAG3	= (float)1.0;

      // Back-Left (NW)
      protected const float X4 	   = (float)-0.0156;
      protected const float Y4 	   = (float)-0.0156;
      protected const float MAG4 	= (float)0.9844;
               
      // Back (N)               
      protected const float X5 	= (float)0.0156;
      protected const float Y5 	= (float)0.0156;
      protected const float MAG5 =	(float)0.9688;
           
      // Back-Right (NE)          
      protected const float X6 	= (float)0.0156;
      protected const float Y6 	= (float)-0.0156;
      protected const float MAG6 = (float)0.9844;
                  
      // Right (E)                                                         
      protected const float X7 	= (float)0.0937;
      protected const float Y7 	= (float)0.0;
      protected const float MAG7 = (float)1.0;
            
      // Front-Right (SE)                                                          
      protected const float X8 	= (float)0.0469;
      protected const float Y8 	= (float)0.0156; 
      protected const float MAG8 = (float)1.0156;
      
	   // Current scaling factor.  Sprites can shrink and grow to give the illusion of depth.
      protected float fMagnify = (float)1.0;

	   // Current position on-screen.
	   protected Point position;
    
      // Current compass point.
      protected int compassPoint;
                                 
	   // Current frame.
	   protected int frame; // Counts 'steps' for animated sprites.
      // If true, advance frames; if false, decrement them.        
	   protected bool shouldIncrementFrames = true; 
      protected int frameCountInUpOrDownMode = 0;  // Overcomes 'wiggling' in some cases.
      protected int frameCountThreshold = 5;       // Stay in up or down mode at least this many frames.
	                 
	   // Limits of stretching and shrinking.
	   protected float fMinMagnify = MIN_MAGNIFY;
	   protected float fMaxMagnify = MAX_MAGNIFY;
   
	   // Max pixels on our window.
	   protected int cxMaxWindow;
	   protected int cyMaxWindow;
  
      public bool isInitialized = false;

      protected Image imageCelPanel;
         
      protected int numCompassPoints = POINTS_ON_COMPASS;
      protected int numFrames;    
   
      protected int cxCel;
      protected int cyCel;
      protected int celsPerRow;
   
      // Stores array of MoveInfo records that 
      // stores attributes of each cel.
      protected MoveInfo[] moveInfoArray;
   
      protected Random rand;

      // Used to seed our object randomly.
      private static int objectCount = 0;

      private static Rectangle rDest = new Rectangle();

      // Constructor
      public Sprite(Image newImageCelPanel, int frames, int newCelX, int newCelY, int newCelsPerRow, int cxMax, int cyMax)
      {
         // Info. about our artwork -- organized as a series of cels on a grid.
         imageCelPanel = newImageCelPanel;
         numFrames = frames;
      
         cxCel = newCelX;
         cyCel = newCelY;
      
         celsPerRow = newCelsPerRow;
      
         //--------------------------------------------------------------------
         // Allocate room to store info. about each compass point =
         // [ N / NE / E / SE / S / SW / W / NW = 8]
         moveInfoArray = new MoveInfo[numCompassPoints];
      
         for(int i = 0; i < numCompassPoints; i++)
            moveInfoArray[i] = new MoveInfo();
            
         moveInfoArray[0].setMoveInfo(X1, Y1, MAG1); 
		   moveInfoArray[1].setMoveInfo(X2, Y2, MAG2); 
		   moveInfoArray[2].setMoveInfo(X3, Y3, MAG3); 
		   moveInfoArray[3].setMoveInfo(X4, Y4, MAG4); 
		   moveInfoArray[4].setMoveInfo(X5, Y5, MAG5); 
		   moveInfoArray[5].setMoveInfo(X6, Y6, MAG6); 
		   moveInfoArray[6].setMoveInfo(X7, Y7, MAG7); 
		   moveInfoArray[7].setMoveInfo(X8, Y8, MAG8); 
		
		   position = new Point();	                                           
	                                           
   	   // Get our max. screen size...                                 
	      cxMaxWindow = cxMax;
         cyMaxWindow = cyMax;
      
         // Initialize random object with current
         // time for more variation between objects.
         objectCount++;
	   
         rand = new Random(objectCount);  	   
      }
   
      /********************************************************************************
	      makeNewCoordinates() -- Generates an initial point for upper-left 
							      hand corner of sprite. Also sets sprite 
									to a randomly chosen frame, compass 
									point and magnification.
      ********************************************************************************/
	   public void makeNewCoordinates()
	   {
 		   // Generate random compass direction.
	      compassPoint = (int)Math.Abs(rand.Next()) % numCompassPoints;
	
	      // Generate random initial frame.	           
	      frame = (int)Math.Abs(rand.Next()) % numFrames;
      
         // Get width of bitmap at this compass direction and frame.
	      MoveInfo thisMoveInfo = moveInfoArray[compassPoint]; 
		   
	      int cx = cxCel;
	      int cy = cyCel;
	
	      // Generate magnification factor based on scale of 1 to 100
	      // re-mapped to current min. and max. ratios.
//	      int rawScale = (int)Math.Abs(rand.Next()) % 100;
           // don't rescale
           int rawScale = 1;
		
	      // Rescale this value based on magnification range.		                 
   	   fMagnify = fMinMagnify + ((float)rawScale * (fMaxMagnify - fMinMagnify)) / 100;
		                                                 
	      // Make sure initial position is on the screen.	                                                          	
         position.X = Math.Abs(rand.Next()) % (cxMaxWindow - (magnify(cxCel) - 1));
         position.Y = Math.Abs(rand.Next()) % (cyMaxWindow - (magnify(cyCel) - 1));
         
         // Up or down?
         int n = (int)Math.Abs(rand.Next()) % 2;
         shouldIncrementFrames = n == 0 ? true : false;
         frameCountInUpOrDownMode = 0; 
      }	   

      /********************************************************************************
		   calcNextCoordinates() -- Generates 'next frame' coodinates, 
							 updating all factors.  Does hit-testing for the edge of 
						 	 screen and changes Compass Point and Magnification accordingly.
						 	 If necessary, changes the direction of a sprite.           
					       
					       Note: You can modify this method or add new ones
					       		 to customize the behavior of each sprite.	
      ********************************************************************************/
	   public void calcNextCoordinates()
	   {
         MoveInfo thisMoveInfo;
      
	      int cxStretch, cyStretch;

	      int edgeCode;
	                                       
	      if(shouldIncrementFrames)
	 	      frame = ++frame % numFrames;
	      else
	      {
	         // Then decrement.
		      if(frame <= 0)
		         frame = numFrames - 1;
		      else
		         frame--;
	      }

	      thisMoveInfo = moveInfoArray[compassPoint];

	      // Re-scale our sprite.                                           
         fMagnify *= (float)thisMoveInfo.fMagnify;                                        
                                      
	      // Build new pixels and position based on this new magnification.                         	                 
	      cxStretch = (int)(fMagnify * (float)cxCel);
	      cyStretch = (int)(fMagnify * (float)cyCel);      
   
         position.X = position.X + (int)((float) cxStretch * thisMoveInfo.fxMove);
         //position.Y = position.Y + (int)((float) cyStretch * thisMoveInfo.fyMove);
   
	      // Notice that wherever this sprite is now, it will be displayed.
	      // Hit-testing below affects the direction AFTER the drawing
	      // and will affect the next move.
	      edgeCode = hitTestForEdge(position, fMagnify, cxStretch, cyStretch);
                         
	      if(edgeCode != 0)
	      {
		      changeDirection(edgeCode);
		      // Also change the sequence of frames -- unless image is 'caught' on edge.
		      if(frameCountInUpOrDownMode >= frameCountThreshold)
		      {
		         shouldIncrementFrames = shouldIncrementFrames ? false : true;
		         frameCountInUpOrDownMode = 0;
            }		      
		   }   
      }	   

	   /********************************************************************************
	      hitTestForEdge() -- Checks that sprite is in bounds of screen
							 	 and current magnification limits.
      ********************************************************************************/
	   protected int hitTestForEdge(Point ptTest, float fMagnifyTest, int cxBmpTestSize, int cyBmpTestSize)
	   {
		   int hitCode = 0;
	
	      if(fMagnify > fMaxMagnify)		
		      hitCode |= FRONT_EDGE;           
		
	      if (fMagnify < fMinMagnify)
		      hitCode |= BACK_EDGE;			
		
	      if (ptTest.X < 0)
		      hitCode |= LEFT_EDGE;
		
   	   if (ptTest.Y < 0)
	   	   hitCode |= TOP_EDGE;
		
	      if (ptTest.X + cxBmpTestSize > cxMaxWindow)
		      hitCode |= RIGHT_EDGE;
		
	      if (ptTest.Y + cyBmpTestSize > cyMaxWindow)
		      hitCode |= BOTTOM_EDGE;
		
   	   return hitCode;   
      }	   
   
      /********************************************************************************
	      changeDirection() -- Changes the direction of a sprite.           
			              	   (You can modify this or add other methods
	 	                     to complicated the behavior of each sprite.	
      ********************************************************************************/
	   protected void changeDirection(int edgeCode)
	   {
	      int n;

   	   // Changes direction of our sprite. Assumes direction needs changing.
	      if((edgeCode & TOP_EDGE) != 0)
	      {     
		      n = Math.Abs(rand.Next()) % 3;
		      if (n == 0)
			      compassPoint = 1;		
		      else if (n == 1)
			      compassPoint = 0;		
		      else
			      compassPoint = 7;
   		   return;	
         }
  	      if((edgeCode & RIGHT_EDGE) != 0)
	      {        
		      n = Math.Abs(rand.Next()) % 3;
		      if (n == 0)
   			   compassPoint = 1;		
	   	   else if (n == 1)
		   	   compassPoint = 2;		
		      else
			      compassPoint = 3;
      	   return;	
         }
	      if((edgeCode & BOTTOM_EDGE) != 0)
	      {        
		      n = Math.Abs(rand.Next()) % 3;
		      if (n == 0)
   			   compassPoint = 3;		
	   	   else if (n == 1)
			      compassPoint = 4;		
		      else
			      compassPoint = 5;
		      return;	
         }
	      if((edgeCode & LEFT_EDGE) != 0)
	      {        
   		   n = Math.Abs(rand.Next()) % 3;
	   	   if (n == 0)
			      compassPoint = 5;		
		      else if (n == 1)
			      compassPoint = 6;		
		      else
   			   compassPoint = 7;
   	   	return;	
         }
	      if((edgeCode & FRONT_EDGE) != 0)
	      {        
		      n = Math.Abs(rand.Next()) % 3;
		      if (n == 0)
      		   compassPoint = 3;		
   		   else if (n == 1)
	   		   compassPoint = 4;		
		      else
			      compassPoint = 5;
		      return;	
         }
         if((edgeCode & BACK_EDGE) != 0)
	      {     
   		   n = Math.Abs(rand.Next()) % 3;
	   	   if (n == 0)
	   		   compassPoint = 1;		
   		   else if (n == 1)
	   		   compassPoint = 0;		
      		else
	      		compassPoint = 7;
   	   	return;	
         }	   
      }
   
	   public void draw(Graphics g)
	   {
		   MoveInfo thisMoveInfo = thisMoveInfo = moveInfoArray[compassPoint];
      
	      int cxStretch = (int)(fMagnify * (float)cxCel);
	      int cyStretch = (int)(fMagnify * (float)cyCel);      

         int xInCelPanel = (frame % celsPerRow) * cxCel;           
         int yInCelPanel = (frame / celsPerRow) * cyCel;                           
      
         // Draw our sprite.                                 
         rDest.X = position.X;
         rDest.Y = position.Y;
         rDest.Width = cxStretch;
         rDest.Height = cyStretch;
	      g.DrawImage(imageCelPanel,
	                  rDest,
	                  xInCelPanel,
	                  yInCelPanel,
	                  cxCel,
	                  cyCel, 
	                  GraphicsUnit.Pixel);
      }
    
      // Accessor methods.... 
      public void setPosition(Point ptNew) 
      {
         position.X = ptNew.X; 
         position.Y = ptNew.Y; 
      }
    
	   public void setPosition(int xNew, int yNew) 
	   { 
	      position.X = xNew; 
	      position.Y = yNew; 
	   }

	   public Point getPosition() 
	   { 
	      return position; 
	   }
	
	   // Some shrink and grow helper methods.            
	   protected int magnify(float fScaleIt, int x) 
	   { 
	      return (int)((float)x * fScaleIt); 
	   }          
	
	   protected int magnify(int x) 
	   {  
	      return (int)((float)x * fMagnify); 
	   }          

	   protected int magnifyDiff(float fScaleIt, int n) 
	   { 
	      return (n + (int)(fScaleIt * (float)n)); 
	   }
	
	   protected int magnifyDiff(int n) 
	   { 
	      return (n + (int)(fMagnify * (float)n)); 
	   }                             
	
	   public static void sortArrayByZOrder(Sprite[] array)
	   {
	      // Sorts by magnification -- objects with lowest magnification factor
	      // are most 'distant' and are placed in front of array so
	      // they can be drawn first.
         bool wasSwitched = true;
		   while(wasSwitched)
		   {                     
		      wasSwitched = false;
			   for(int i = 0; i < array.Length - 1; i++)
			   {
			      if(array[i].fMagnify > array[i + 1].fMagnify)	
			      {
					   Sprite temp = array[i];
					   array[i] = array[i + 1];
					   array[i + 1] = temp;
					   wasSwitched = true;
				   }						  
			   }
		   }                                     
      }	   
   }
}
