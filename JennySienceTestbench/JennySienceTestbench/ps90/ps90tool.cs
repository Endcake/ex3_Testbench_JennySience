using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ps90func;

namespace ps90tool
{
    class ps90tool
    {
        static void Main(string[] args)
        {
            CPS90Win PS90 = new CPS90Win();

            // parameters from the command line
            // parameter 1 (COM port)
            Int32 nComPort = 3; // args[0]
            // parameter 2 (axis number)
            Int32 nAxis = 1; // args[1]
            // parameter 3 (positioning velocity in Hz)
            Double dPosF = 30000.0; // args[2]
            // parameter 4 (distance for positioning in mm, distance=0 - reference run)
            Double dDistance = 10.0; // args[3]

            if (args.Length != 4)
            {
                Console.WriteLine("ps90tool <COM port> <axis no.> <velocity> <distance>");
                Console.WriteLine("e.g. ps90tool 3 1 30000 10");
                return;
            }

            // set parameters *************
            nComPort = Convert.ToInt32(args[0]);
            nAxis = Convert.ToInt32(args[1]);
            dPosF = Convert.ToDouble(args[2]);
            dDistance = Convert.ToDouble(args[3]);
            // ****************************

            // open virtual serial interface
            PS90.Connect(1, 0, nComPort, 9600, 0);

            // define constants for calculation Inc -> mm
            //PS90.SetStageAttributes(nAxis, 1.0, 200, 1.0);

            // initialize axis
            PS90.MotorInit(nAxis);

            // set target mode (0 - relative)
            PS90.SetTargetMode(nAxis, 0);

            // set velocity
            PS90.SetPosF(nAxis, dPosF);

            // check position
            Console.WriteLine("Position={0}", PS90.GetPositionEx(nAxis));

            // start positioning
            if (dDistance == 0.0) // go home (to start position)
            {
                PS90.GoRef(nAxis, 4);
            }
            else // move to target position (+ positive direction, - negative direction)
            {
                PS90.MoveEx(nAxis, dDistance, true);
            }

            // check move state of the axis
            Console.WriteLine("Axis is moving...");
            while (PS90.GetMoveState(nAxis) != 0) { ;}
            Console.WriteLine("Axis is in position.");

            // check position
            Console.WriteLine("Position={0}", PS90.GetPositionEx(nAxis));

            // close interface
            PS90.Disconnect();
        }
    }
}
