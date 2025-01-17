﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Steam_VR_Utility
{
    class ProcessManager
    {

        public async Task<int> SuspendProcess(string imagename, int delaytime)
        {
            
            await Task.Delay(1000*delaytime);
            System.Diagnostics.Process.Start("pssuspend.exe", imagename);
            Console.Clear();
            


            return 1;
        }

        public async Task<int> ResumeProcess(string imagename )
        {
            Console.Clear();
            string arguments = "-r " + imagename;
            System.Diagnostics.Process.Start("pssuspend.exe", arguments);
            Console.Clear();


            return 1;
        }

        public void KillProcess(string imagename)
        {
            Console.Clear();
            System.Diagnostics.Process.Start("pskill.exe", imagename);
            Console.Clear();
            Console.WriteLine("Game ended");


        }




    }
}
