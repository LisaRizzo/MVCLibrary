﻿using System;

namespace Grand_Circus_Library
{
  class BookWelcomeView : IView
  {
    public void Display()
    {
      //logo for library
      Console.WriteLine(@"
  
                                     ██████╗ ██████╗  █████╗ ███╗   ██╗██████╗          
                                    ██╔════╝ ██╔══██╗██╔══██╗████╗  ██║██╔══██╗         
                                    ██║  ███╗██████╔╝███████║██╔██╗ ██║██║  ██║         
                                    ██║   ██║██╔══██╗██╔══██║██║╚██╗██║██║  ██║         
                                    ╚██████╔╝██║  ██║██║  ██║██║ ╚████║██████╔╝         
                                     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝          
                                                    
                                     ██████╗██╗██████╗  ██████╗██╗   ██╗███████╗        
                                    ██╔════╝██║██╔══██╗██╔════╝██║   ██║██╔════╝        
                                    ██║     ██║██████╔╝██║     ██║   ██║███████╗        
                                    ██║     ██║██╔══██╗██║     ██║   ██║╚════██║        
                                    ╚██████╗██║██║  ██║╚██████╗╚██████╔╝███████║        
                                     ╚═════╝╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═════╝ ╚══════╝        
                                                    
                                    ██╗     ██╗██████╗ ██████╗  █████╗ ██████╗ ██╗   ██╗
                                    ██║     ██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝
                                    ██║     ██║██████╔╝██████╔╝███████║██████╔╝ ╚████╔╝ 
                                    ██║     ██║██╔══██╗██╔══██╗██╔══██║██╔══██╗  ╚██╔╝  
                                    ███████╗██║██████╔╝██║  ██║██║  ██║██║  ██║   ██║   
                                    ╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ");     

    }
  }
}