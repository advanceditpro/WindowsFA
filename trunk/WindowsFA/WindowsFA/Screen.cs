namespace WindowsFA
{
   using System;
   using System.Drawing;
   using System.Windows.Forms;

   /// <summary>
   ///    Screen class manages offscreen graphics.
   /// </summary>
   public class Screen
   {
      protected Graphics g = null;
   
      protected Image imageOffscreen = null;
      protected Graphics gOffscreen = null;
   
      public int x = 0;
      public int y = 0;
   
      public int width = 0;
      public int height = 0;

      public Color backColor;
      public Color transparentColor;
   
      // This constructor allows us to initialize using a component
      // and a rectangle within that component.  This is the default
      // way to specify an animated area of an applet/application.
      public Screen(Panel c, Rectangle r, Color thisBackColor, Color thisTransparentColor)
      {
         // Get visible screen.
         g = c.CreateGraphics();
      
         x = r.X;
         y = r.Y;
         width = r.Width;
         height = r.Height;
      
         // Get off-screen buffer.
         imageOffscreen = new Bitmap(width, height);
         
         gOffscreen = Graphics.FromImage(imageOffscreen);
      
         // Save colors.
         backColor = thisBackColor;
         transparentColor = thisTransparentColor;
      }   
  
      public Graphics getGraphics()
      {
         // Allow caller to access offscreen buffer for graphics.
         return gOffscreen;
      }      
  
      public void erase() 
      {
         // Erase all content in back buffer using background color.
         if(!isValidGraphics())
            return;

        SolidBrush blackBrush = new SolidBrush(System.Windows.Forms.Panel.DefaultBackColor);
         gOffscreen.FillRectangle(blackBrush, 0, 0, width - 1, height - 1);   
      }   
   
      public void flip()
      {
         // Flips back buffer to front buffer -- smooth animation with this 'double buffering'.
         g.DrawImage(imageOffscreen, x, y);
      }   
   
      public bool isValidGraphics()
      {
         if(g != null && gOffscreen != null)
            return true;
         else
            return false;
      }   
          
      public Screen()
      {
      }
   }
}
