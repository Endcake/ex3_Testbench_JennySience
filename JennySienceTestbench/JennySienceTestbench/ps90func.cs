/*
*
* ps90func.cs
* created:      08.07.2008  alex
* last change:  07.02.2014  alex
*
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ps90func
{
    public unsafe class CPS90Win
    {
        // System                                                                                 
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_Connect(Int32 Index, Int32 Int, Int32 p1, Int32 p2, Int32 p3, Int32 p4, Int32 p5, Int32 p6);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SimpleConnect(Int32 Index, String strSerNum);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_Disconnect(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetConnectInfo(Int32 Index, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMessage(Int32 Index, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetTerminal(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetTerminal(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetBoardVersion(Int32 Index, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDriveVersion(Int32 Index, Int32 nAxis, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetSerNumber(Int32 Index, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetError(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CheckMem(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ResetBoard(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ResetDrives(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ClearError(Int32 Index);

        // Operate 
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MotorInit(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MotorOn(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MotorOff(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetTargetMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetTargetMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPosMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPosMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPosition(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPosition(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ResetCounter(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetTarget(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetTarget(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GoTarget(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GoRef(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_FreeSwitch(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_Stop(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GoVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_StopVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMotorType(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMotorType(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisActive(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAxisActive(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMotorCommMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMotorCommMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMotorCommCounts(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMotorCommCounts(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetEncLines(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetEncLines(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMotorPoles(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMotorPoles(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisMonitor(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAxisMonitor(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMoveState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetVelState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetErrorState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetRefReady(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetActVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysPos(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysPos(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ResetMsysCounter(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetEncPos(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPosError(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMaxPosError(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMaxPosError(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysTarget(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysTarget(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GoMsysTarget(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_StopMsys(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysPosState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysPosError(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysPosRange(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysDir(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysDir(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MultiGoTarget(Int32 Index, Int32 nAxisBits, Int32 nVector);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MultiGoVel(Int32 Index, Int32 nAxisBits);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MultiStop(Int32 Index, Int32 nAxisBits);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetVectorTabRow(Int32 Index, Int32 nLineIndex, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorTabRow(Int32 Index, Int32 nLineIndex, String strLine);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CopyVectorTab(Int32 Index, Int32 nTargetLine, Int32 nSourceLine, Int32 nNumber);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ClearVectorTab(Int32 Index, Int32 nLineIndex, Int32 nNumber);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GoVectorTab(Int32 Index, Int32 nStartLine, Int32 nEndLine);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_StopVectorTab(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CheckVectorTab(Int32 Index, Int32 nStartLine, Int32 nEndLine);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CircleToVectorTab(Int32 Index, Int32 nLineIndex, String strCircle);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ChangeTarget(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPIDTarget(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPosRange(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetActF(Int32 Index, Int32 nAxis);
        
 	    // Adjustments
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SaveGlobParams(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_LoadGlobParams(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SaveAxisParams(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_LoadAxisParams(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAccel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAccel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDecel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDecel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJerk(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJerk(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetBrakeDecel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetBrakeDecel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetRefDecel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetRefDecel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPosVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPosVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetSlowRefVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetSlowRefVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetFastRefVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFastRefVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetFreeVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFreeVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetStepWidth(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetStepWidth(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDriveCurrent(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDriveCurrent(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHoldCurrent(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetHoldCurrent(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPhaseInitTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPhaseInitTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPhaseInitAmp(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPhaseInitAmp(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPhasePwmFreq(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPhasePwmFreq(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetCurrentLevel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetCurrentLevel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetServoLoopMax(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetServoLoopMax(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetVectorVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetVectorAccel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorAccel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetPosF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPosF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetSlowRefF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetSlowRefF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetFastRefF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFastRefF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetFreeF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFreeF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetMsysF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysF(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetVectorF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorF(Int32 Index, Int32 nAxis, Double dVal);

	    // Software/hardware regulator
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetSampleTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetSampleTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetKP(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetKP(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetKI(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetKI(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetKD(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetKD(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetILimit(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetILimit(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetInPosMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetInPosMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetInPosTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetInPosTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetTargetWindow(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetTargetWindow(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysFacZ(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysFacZ(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysFacN(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysFacN(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysPosMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysPosMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMsysTargetWnd(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysTargetWnd(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHybridTargetOffset(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetHybridTargetOffset(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHybridTargetWnd(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetHybridTargetWnd(Int32 Index, Int32 nAxis, Int32 nValue);

        // Hardware/software switches
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitSwitch(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitSwitch(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitSwitchMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetRefSwitch(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetRefSwitch(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetRefSwitchMode(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetRefSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitSwitchLevel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetSwitchState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetSwitchHyst(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitControl(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitControl(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitMin(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitMin(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitMax(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitMax(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetLimitState(Int32 Index, Int32 nAxis);

	    // Joystick
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyX(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyX(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyY(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyY(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyZ(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyZ(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_JoystickOn(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_JoystickOff(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyVel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyVel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyAccel(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyAccel(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetServoJoyOff(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetServoJoyOff(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyZone(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyZone(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyZeroX(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyZeroX(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyZeroY(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyZeroY(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyZeroZ(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyZeroZ(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetJoyButton(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyButton(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetJoyF(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyF(Int32 Index, Int32 nAxis, Double dVal);

	    // Analog & digital I/O
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisSignals(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisIn(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAxisOut(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAxisOut(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetInOutConfig(Int32 Index, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigitalInput(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigInTTL(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigInSPS(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigitalOutput(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDigitalOutput(Int32 Index, Int32 nPin, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigOutTTL(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDigOutTTL(Int32 Index, Int32 nPin, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDigOutSPS(Int32 Index, Int32 nPin);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDigOutSPS(Int32 Index, Int32 nPin, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetInputMode(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetInputMode(Int32 Index, Int32 nMode);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAnalogInput(Int32 Index, Int32 nInput);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetAnalogOutput(Int32 Index, Int32 nOutput);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAnalogOutput(Int32 Index, Int32 nOutput, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPwmOutput(Int32 Index, Int32 nOutput);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPwmOutput(Int32 Index, Int32 nOutput, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPwmBrake(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPwmBrake(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPwmBrakeValue1(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPwmBrakeValue1(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPwmBrakeValue2(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPwmBrakeValue2(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPwmBrakeTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPwmBrakeTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPowerInput(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPowerOutput(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ResetPowerOutput(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHybridOutput(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMaxHybridOutput(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMaxHybridOutput(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHybridOutputTime(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetHybridOutputTime(Int32 Index, Int32 nAxis, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetHybridErrorState(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetPowerState(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetEmergencyInput(Int32 Index);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetStepperPowerControl(Int32 Index, Int32 nAxis, Int32 nParamNum, StringBuilder strBuffer, Int32 Len);

         [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetStepperPowerControl(Int32 Index, Int32 nAxis, Int32 nVal1, Int32 nVal2, Int32 nVal3, Int32 nVal4);

       // Stand-Alone-Compiler/Memory
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMem(Int32 Index, Int32 nMemIndex);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMem(Int32 Index, Int32 nMemIndex, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMem16(Int32 Index, Int32 nMemIndex);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMem16(Int32 Index, Int32 nMemIndex, Int32 nValue);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetMem32(Int32 Index, Int32 nMemIndex);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMem32(Int32 Index, Int32 nMemIndex, Int32 nValue);

	    // Extended functions
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetStageAttributes(Int32 Index, Int32 nAxis, Double pitch, Int32 inc_rev, Double ratio);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetCalcResol(Int32 Index, Int32 nAxis, Double cresol);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysResol(Int32 Index, Int32 nAxis, Double resol);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetPositionEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPositionEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetTargetEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetTargetEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_ChangeTargetEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetPIDTargetEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetMsysPosEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysPosEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetMsysTargetEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysTargetEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetMsysPosRangeEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetPosRangeEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetEncPosEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetLimitMinEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitMinEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetLimitMaxEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetLimitMaxEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_MoveEx(Int32 Index, Int32 nAxis, Double dVal, Int32 nNoInc);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetPosFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetPosFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetSlowRefFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetSlowRefFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetFastRefFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFastRefFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetFreeFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetFreeFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetJoyFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetActFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetMsysFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetMsysFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetVectorFEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorFEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetAccelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetAccelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetDecelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDecelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetBrakeDecelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetBrakeDecelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetRefDecelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetRefDecelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetJoyAccelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetJoyAccelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Double PS90_GetVectorAccelEx(Int32 Index, Int32 nAxis);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetVectorAccelEx(Int32 Index, Int32 nAxis, Double dVal);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_SetDEC(Int32 Index, Int32 nAxis, String strFile, String strSerNum, Int32 nMode, Double dLevel);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetDEC(Int32 Index, Int32 nAxis, StringBuilder strBuffer, Int32 Len);

	    // Communication
        [DllImport("ps90.dll")]
        public static extern Int32 PS90_LogFile(Int32 Index, Int32 nOpen, String strFile, Int32 nAppend, Int32 nMode);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CmdAns(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_CmdAnsEx(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest, Int32 nBreak);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetOWISidData(Int32 Index, Int32 nAxis, Int32 nParamNum, StringBuilder strBuffer, Int32 Len);

        [DllImport("ps90.dll")]
        public static extern Int32 PS90_GetReadError(Int32 Index);


        // class variables
        Int32 m_nController;	// Controller number 1...10
        Boolean m_bConnected;	// Is there an active connection?
        Int32 m_nLastError;	    // Last return code from a PS90 library function


	    // Contructors
        public CPS90Win()
        {
	        m_nController = 0;
	        m_bConnected = false;
	        m_nLastError = 0;
        }

        public CPS90Win(Int32 nController, Int32 nInt, Int32 nCom, Int32 nBaud, Int32 nHandshake)
        {
	        m_nController = nController;
	        m_bConnected = false;	
	        m_nLastError = 0;

	        Connect(nController, nInt, nCom, nBaud, nHandshake);
        }

        ~CPS90Win()
        {
	        if(m_bConnected) Disconnect();
        }

        // Member *********************************************************
        public Boolean IsConnected() {return m_bConnected;}
	    public Int32 GetIndex() {return m_nController;}
	    public Int32 GetLastError() {return m_nLastError;}

        // Operations *****************************************************
        // System
        public Int32 Connect(Int32 nController, Int32 nInt, Int32 nCom, Int32 nBaud, Int32 nHandshake)
        {
	        if(m_bConnected) Disconnect();
        	
            m_nLastError=PS90_Connect(
                nController, 
                nInt, 
                nCom, 
                nBaud, 
                nHandshake, 
                0,
                8, 
                0); 
        		
	        if(m_nLastError == 0)
	        {
		        m_nController = nController;
		        m_bConnected = true;
	        }
	        else
		        m_bConnected = false;
        	
	        return m_nLastError;		
        }

        public Int32 SimpleConnect(Int32 nController, String strSerNum)
        {
	        if(m_bConnected) Disconnect();
        	
            m_nLastError=PS90_SimpleConnect(
                nController, 
                strSerNum); 
        		
	        if(m_nLastError == 0)
	        {
		        m_nController = nController;
		        m_bConnected = true;
	        }
	        else
		        m_bConnected = false;
        	
	        return m_nLastError;		
        }

        public Int32 Disconnect()
        {
            m_nLastError=PS90_Disconnect(m_nController);
        		
	        if(m_nLastError == 0)
	        {
		        m_nController = 0;
		        m_bConnected = false;
	        }
        	
	        return m_nLastError;		
        }

        public String GetConnectInfo()
        {
	        String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
	        Int32 nStrLen;
        	
            nStrLen=PS90_GetConnectInfo(
		        m_nController, 
		        strBuffer,
                strBuffer.Capacity);
	        strMsg=strBuffer.ToString();
            m_nLastError=0;
        		
	        return strMsg;		
        }

        public String GetMessage()
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS90_GetMessage(
                m_nController,
                strBuffer,
                strBuffer.Capacity);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 GetTerminal()
        { 
	        Int32 nValue=0;

            nValue=PS90_GetTerminal(m_nController);
            m_nLastError=GetReadError();
        		
	        return nValue;		
        }

        public Int32 SetTerminal(Int32 nMode)
        {
            m_nLastError=PS90_SetTerminal(
                m_nController, 
                nMode);
        		
	        return m_nLastError;		
        }

        public String GetBoardVersion()
        {
            String strVersion;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS90_GetBoardVersion(
                m_nController,
                strBuffer,
                strBuffer.Capacity);
            strVersion = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strVersion;
        }

        public String GetDriveVersion(Int32 nAxis)
        {
            String strVersion;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS90_GetDriveVersion(
                m_nController,
                nAxis,
                strBuffer,
                strBuffer.Capacity);
            strVersion = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strVersion;
        }

        public String GetSerNumber()
        {
            String strNum;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS90_GetSerNumber(
                m_nController,
                strBuffer,
                strBuffer.Capacity);
            strNum = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strNum;
        }

        public Int32 GetError()
        { 
	        Int32 nValue=0;

            nValue=PS90_GetError(m_nController);
            m_nLastError=GetReadError();
        		
	        return nValue;		
        }

        public Int32 CheckMem()
        { 
	        Int32 nCheckSum=0;

            nCheckSum = PS90_CheckMem(m_nController);
            m_nLastError=GetReadError();

            return nCheckSum;		
        }

        public Int32 ResetBoard()
        {
            m_nLastError = PS90_ResetBoard(m_nController);
        		
	        return m_nLastError;		
        }

        public Int32 ResetDrives()
        {
            m_nLastError = PS90_ResetDrives(m_nController);
        		
	        return m_nLastError;		
        }

        public Int32 ClearError()
        {
            m_nLastError = PS90_ClearError(m_nController);
        		
	        return m_nLastError;		
        }

        // Operate
        public Int32 MotorInit(Int32 nAxis)
        {
            m_nLastError = PS90_MotorInit(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 MotorOn(Int32 nAxis)
        {
            m_nLastError = PS90_MotorOn(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 MotorOff(Int32 nAxis)
        {
            m_nLastError = PS90_MotorOff(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetTargetMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetTargetMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetTargetMode(Int32 nAxis, Int32 nMode)
        {
            m_nLastError = PS90_SetTargetMode(
                m_nController,
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetPosMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPosMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPosMode(Int32 nAxis, Int32 nMode)
        {
            m_nLastError = PS90_SetPosMode(
                m_nController,
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetPosition(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPosition(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPosition(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPosition(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 ResetCounter(Int32 nAxis)
        {
            m_nLastError = PS90_ResetCounter(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetTarget(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetTarget(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetTarget(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetTarget(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GoTarget(Int32 nAxis)
        {
            m_nLastError = PS90_GoTarget(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GoRef(Int32 nAxis, Int32 nRefMode)
        {
            m_nLastError = PS90_GoRef(
                m_nController,
                nAxis,
                nRefMode);

            return m_nLastError;
        }

        public Int32 FreeSwitch(Int32 nAxis)
        {
            m_nLastError = PS90_FreeSwitch(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 Stop(Int32 nAxis)
        {
            m_nLastError = PS90_Stop(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GoVel(Int32 nAxis)
        {
            m_nLastError = PS90_GoVel(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 StopVel(Int32 nAxis)
        {
            m_nLastError = PS90_StopVel(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetMotorType(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMotorType(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMotorType(Int32 nAxis, Int32 nType)
        {
            m_nLastError = PS90_SetMotorType(
                m_nController,
                nAxis,
                nType);

            return m_nLastError;
        }

        public Boolean IsAxisActive(Int32 nAxis)
        {
            Int32 nValue = 0;
            Boolean bActive = false;

            nValue = PS90_GetAxisActive(
                m_nController,
                nAxis);
            if (nValue > 0) bActive = true;
            m_nLastError = GetReadError();

            return bActive;
        }

        public Int32 SetAxisActive(Int32 nAxis, Boolean bActive)
        {
            m_nLastError = PS90_SetAxisActive(
                m_nController,
                nAxis,
                bActive ? 1 : 0);

            return m_nLastError;
        }

        public Int32 GetMotorCommMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMotorCommMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMotorCommMode(Int32 nAxis, Int32 nMode)
        {
            m_nLastError = PS90_SetMotorCommMode(
                m_nController,
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetMotorCommCounts(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMotorCommCounts(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMotorCommCounts(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMotorCommCounts(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetEncLines(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetEncLines(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetEncLines(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetEncLines(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMotorPoles(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMotorPoles(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMotorPoles(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMotorPoles(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetAxisMonitor(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAxisMonitor(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAxisMonitor(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetAxisMonitor(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetAxisState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAxisState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMoveState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMoveState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetVelState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetVelState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetErrorState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetErrorState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetRefReady(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetRefReady(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetActVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetActVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMsysPos(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysPos(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysPos(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysPos(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 ResetMsysCounter(Int32 nAxis)
        {
            m_nLastError = PS90_ResetMsysCounter(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetEncPos(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetEncPos(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetPosError(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPosError(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMaxPosError(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMaxPosError(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMaxPosError(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMaxPosError(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMsysTarget(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysTarget(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysTarget(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysTarget(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GoMsysTarget(Int32 nAxis)
        {
            m_nLastError = PS90_GoMsysTarget(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 StopMsys(Int32 nAxis)
        {
            m_nLastError = PS90_StopMsys(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetMsysPosState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysPosState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMsysPosError(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysPosError(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMsysPosRange(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysPosRange(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMsysDir(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysDir(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysDir(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysDir(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 MultiGoTarget(Int32 nAxisBits, Boolean bVector)
        {
            m_nLastError = PS90_MultiGoTarget(
                m_nController,
                nAxisBits,
                bVector?1:0);

            return m_nLastError;
        }

        public Int32 MultiGoVel(Int32 nAxisBits)
        {
            m_nLastError = PS90_MultiGoVel(
                m_nController,
                nAxisBits);

            return m_nLastError;
        }

        public Int32 MultiStop(Int32 nAxisBits)
        {
            m_nLastError = PS90_MultiStop(
                m_nController,
                nAxisBits);

            return m_nLastError;
        }

        public String GetVectorTabRow(Int32 nLineIndex)
        {
            String strLine;
            StringBuilder strBuffer = new StringBuilder(100);
            Int32 nStrLen;

            nStrLen = PS90_GetVectorTabRow(
                m_nController,
                nLineIndex,
                strBuffer,
                strBuffer.Capacity);
            strLine = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strLine;
        }

        public Int32 SetVectorTabRow(Int32 nLineIndex, String strLine)
        {
            m_nLastError = PS90_SetVectorTabRow(
                m_nController,
                nLineIndex,
                strLine);

            return m_nLastError;
        }

        public Int32 CopyVectorTab(Int32 nTargetLine, Int32 nSourceLine, Int32 nNumber)
        {
            m_nLastError = PS90_CopyVectorTab(
                m_nController,
                nTargetLine,
                nSourceLine,
                nNumber);

            return m_nLastError;
        }

        public Int32 ClearVectorTab(Int32 nLineIndex, Int32 nNumber)
        {
            m_nLastError = PS90_ClearVectorTab(
                m_nController,
                nLineIndex,
                nNumber);

            return m_nLastError;
        }

        public Int32 GoVectorTab(Int32 nStartLine, Int32 nEndLine)
        {
            m_nLastError = PS90_GoVectorTab(
                m_nController,
                nStartLine,
                nEndLine);

            return m_nLastError;
        }

        public Int32 StopVectorTab()
        {
            m_nLastError = PS90_StopVectorTab(m_nController);

            return m_nLastError;
        }

        public Int32 CheckVectorTab(Int32 nStartLine, Int32 nEndLine)
        {
            m_nLastError = PS90_CheckVectorTab(
                m_nController,
                nStartLine,
                nEndLine);

            return m_nLastError;
        }

        public Int32 CircleToVectorTab(Int32 nLineIndex, String strCircle)
        {
            m_nLastError = PS90_CircleToVectorTab(
                m_nController,
                nLineIndex,
                strCircle);

            return m_nLastError;
        }

        public Int32 ChangeTarget(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_ChangeTarget(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPIDTarget(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPIDTarget(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetPosRange(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPosRange(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Double GetActF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetActF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        // Adjustments
        public Int32 SaveGlobParams()
        {
            m_nLastError = PS90_SaveGlobParams(m_nController);

            return m_nLastError;
        }

        public Int32 LoadGlobParams()
        {
            m_nLastError = PS90_LoadGlobParams(m_nController);

            return m_nLastError;
        }

        public Int32 SaveAxisParams(Int32 nAxis)
        {
            m_nLastError = PS90_SaveAxisParams(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 LoadAxisParams(Int32 nAxis)
        {
            m_nLastError = PS90_LoadAxisParams(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetAccel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAccel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAccel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetAccel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDecel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDecel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDecel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetDecel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJerk(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetJerk(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJerk(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetJerk(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetBrakeDecel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetBrakeDecel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetBrakeDecel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetBrakeDecel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefDecel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetRefDecel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefDecel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetRefDecel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPosVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPosVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPosVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPosVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetSlowRefVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetSlowRefVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetSlowRefVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetSlowRefVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetFastRefVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetFastRefVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetFastRefVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetFastRefVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetFreeVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetFreeVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetFreeVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetFreeVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetStepWidth(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetStepWidth(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetStepWidth(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetStepWidth(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDriveCurrent(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDriveCurrent(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDriveCurrent(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetDriveCurrent(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHoldCurrent(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetHoldCurrent(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetHoldCurrent(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetHoldCurrent(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPhaseInitTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPhaseInitTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPhaseInitTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPhaseInitTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPhaseInitAmp(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPhaseInitAmp(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPhaseInitAmp(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPhaseInitAmp(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPhasePwmFreq(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPhasePwmFreq(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPhasePwmFreq(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPhasePwmFreq(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetCurrentLevel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetCurrentLevel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetCurrentLevel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetCurrentLevel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetServoLoopMax(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetServoLoopMax(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetServoLoopMax(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetServoLoopMax(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMsysVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetVectorVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetVectorVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetVectorVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetVectorVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetVectorAccel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetVectorAccel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetVectorAccel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetVectorAccel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Double GetPosF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetPosF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetPosF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetPosF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetSlowRefF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetSlowRefF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetSlowRefF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetSlowRefF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFastRefF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetFastRefF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFastRefF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetFastRefF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFreeF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetFreeF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFreeF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetFreeF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetMsysF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetMsysF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetMsysF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetMsysF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetVectorF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetVectorF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetVectorF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetVectorF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        // Software/hardware regulator
        public Int32 GetSampleTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetSampleTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetSampleTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetSampleTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKP(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetKP(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKP(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetKP(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKI(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetKI(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKI(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetKI(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKD(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetKD(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKD(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetKD(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetDTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetILimit(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetILimit(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetILimit(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetILimit(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetInPosMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetInPosMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetInPosMode(Int32 nAxis, Int32 nMode)
        {
            m_nLastError = PS90_SetInPosMode(
                m_nController,
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetInPosTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetInPosTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetInPosTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetInPosTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetTargetWindow(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetTargetWindow(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetTargetWindow(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetTargetWindow(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMsysFacZ(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysFacZ(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysFacZ(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysFacZ(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMsysFacN(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysFacN(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysFacN(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysFacN(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMsysPosMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysPosMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysPosMode(Int32 nAxis, Int32 nMode)
        {
            m_nLastError = PS90_SetMsysPosMode(
                m_nController,
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetMsysTargetWnd(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMsysTargetWnd(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMsysTargetWnd(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMsysTargetWnd(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHybridTargetOffset(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetHybridTargetOffset(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetHybridTargetOffset(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetHybridTargetOffset(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHybridTargetWnd(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetHybridTargetWnd(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetHybridTargetWnd(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetHybridTargetWnd(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        // Hardware/software switches
        public Int32 GetLimitSwitch(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitSwitch(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitSwitch(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitSwitch(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitSwitchMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitSwitchMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitSwitchMode(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitSwitchMode(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefSwitch(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetRefSwitch(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefSwitch(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetRefSwitch(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefSwitchMode(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetRefSwitchMode(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefSwitchMode(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetRefSwitchMode(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 SetLimitSwitchLevel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitSwitchLevel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetSwitchState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetSwitchState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetSwitchHyst(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetSwitchHyst(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetLimitControl(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitControl(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitControl(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitControl(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitMin(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitMin(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitMin(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitMin(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitMax(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitMax(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitMax(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetLimitMax(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetLimitState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        // Joystick
        public Int32 GetJoyX()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyX(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyX(Int32 nAxis)
        {
            m_nLastError = PS90_SetJoyX(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetJoyY()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyY(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyY(Int32 nAxis)
        {
            m_nLastError = PS90_SetJoyY(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 GetJoyZ()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyZ(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZ(Int32 nAxis)
        {
            m_nLastError = PS90_SetJoyZ(
                m_nController,
                nAxis);

            return m_nLastError;
        }

        public Int32 JoystickOn()
        {
            m_nLastError = PS90_JoystickOn(m_nController);

            return m_nLastError;
        }

        public Int32 JoystickOff()
        {
            m_nLastError = PS90_JoystickOff(m_nController);

            return m_nLastError;
        }

        public Int32 GetJoyVel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyVel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyVel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetJoyVel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyAccel(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyAccel(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyAccel(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetJoyAccel(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetServoJoyOff(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetServoJoyOff(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetServoJoyOff(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetServoJoyOff(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZone()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyZone(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZone(Int32 nValue)
        {
            m_nLastError = PS90_SetJoyZone(
                m_nController,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZeroX()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyZeroX(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZeroX(Int32 nValue)
        {
            m_nLastError = PS90_SetJoyZeroX(
                m_nController,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZeroY()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyZeroY(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZeroY(Int32 nValue)
        {
            m_nLastError = PS90_SetJoyZeroY(
                m_nController,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZeroZ()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyZeroZ(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZeroZ(Int32 nValue)
        {
            m_nLastError = PS90_SetJoyZeroZ(
                m_nController,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyButton()
        {
            Int32 nValue = 0;

            nValue = PS90_GetJoyButton(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyButton(Int32 nValue)
        {
            m_nLastError = PS90_SetJoyButton(
                m_nController,
                nValue);

            return m_nLastError;
        }

        public Double GetJoyF(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetJoyF(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetJoyF(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetJoyF(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }


        // Analog & digital I/O
        public Int32 GetAxisSignals(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAxisSignals(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetAxisIn(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAxisIn(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetAxisOut(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAxisOut(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAxisOut(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetAxisOut(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetInOutConfig(Int32 nValue)
        {
            Int32 nVal = 0;

            nVal = PS90_GetInOutConfig(
                m_nController,
                nValue);
            m_nLastError = GetReadError();

            return nVal;
        }

        public Int32 GetDigitalInput(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigitalInput(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetDigInTTL(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigInTTL(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetDigInSPS(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigInSPS(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetDigitalOutput(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigitalOutput(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDigitalOutput(Int32 nPin, Int32 nValue)
        {
            m_nLastError = PS90_SetDigitalOutput(
                m_nController,
                nPin,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDigOutTTL(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigOutTTL(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDigOutTTL(Int32 nPin, Int32 nValue)
        {
            m_nLastError = PS90_SetDigOutTTL(
                m_nController,
                nPin,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDigOutSPS(Int32 nPin)
        {
            Int32 nValue = 0;

            nValue = PS90_GetDigOutSPS(
                m_nController,
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDigOutSPS(Int32 nPin, Int32 nValue)
        {
            m_nLastError = PS90_SetDigOutSPS(
                m_nController,
                nPin,
                nValue);

            return m_nLastError;
        }

        public Int32 GetInputMode()
        {
            Int32 nValue = 0;

            nValue = PS90_GetInputMode(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetInputMode(Int32 nMode)
        {
            m_nLastError = PS90_SetInputMode(
                m_nController,
                nMode);

            return m_nLastError;
        }

        public Int32 GetAnalogInput(Int32 nInput)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAnalogInput(
                m_nController,
                nInput);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetAnalogOutput(Int32 nOutput)
        {
            Int32 nValue = 0;

            nValue = PS90_GetAnalogOutput(
                m_nController,
                nOutput);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAnalogOutput(Int32 nOutput, Int32 nValue)
        {
            m_nLastError = PS90_SetAnalogOutput(
                m_nController,
                nOutput,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmOutput(Int32 nOutput)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPwmOutput(
                m_nController,
                nOutput);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmOutput(Int32 nOutput, Int32 nValue)
        {
            m_nLastError = PS90_SetPwmOutput(
                m_nController,
                nOutput,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrake(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPwmBrake(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrake(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPwmBrake(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeValue1(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPwmBrakeValue1(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeValue1(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPwmBrakeValue1(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeValue2(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPwmBrakeValue2(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeValue2(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPwmBrakeValue2(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPwmBrakeTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPwmBrakeTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPowerInput(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPowerInput(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPowerOutput(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetPowerOutput(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 ResetPowerOutput(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_ResetPowerOutput(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHybridOutput(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetHybridOutput(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMaxHybridOutput(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMaxHybridOutput(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMaxHybridOutput(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetMaxHybridOutput(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHybridOutputTime(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetHybridOutputTime(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetHybridOutputTime(Int32 nAxis, Int32 nValue)
        {
            m_nLastError = PS90_SetHybridOutputTime(
                m_nController,
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHybridErrorState()
        {
            Int32 nValue = 0;

            nValue = PS90_GetHybridErrorState(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetPowerState(Int32 nAxis)
        {
            Int32 nValue = 0;

            nValue = PS90_GetPowerState(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetEmergencyInput()
        {
            Int32 nValue = 0;

            nValue = PS90_GetEmergencyInput(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetStepperPowerControl(Int32 nAxis, Int32 nParamNum, ref String strRetData)
        {
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nRetValue=0;

            nRetValue = PS90_GetStepperPowerControl(
                m_nController,
                nAxis,
                nParamNum,
                strBuffer,
                strBuffer.Capacity);
            strRetData = strBuffer.ToString();
            m_nLastError = GetReadError();

            return nRetValue;
        }

        public Int32 SetStepperPowerControl(Int32 nAxis, Int32 nVal1, Int32 nVal2, Int32 nVal3, Int32 nVal4)
        {
            m_nLastError = PS90_SetStepperPowerControl(
                m_nController,
                nAxis,
                nVal1,
                nVal2,
                nVal3,
                nVal4);

            return m_nLastError;
        }

        // Stand-Alone-Compiler/Memory
        public Int32 GetMem(Int32 nMemIndex)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMem(
                m_nController,
                nMemIndex);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMem(Int32 nMemIndex, Int32 nValue)
        {
            m_nLastError = PS90_SetMem(
                m_nController,
                nMemIndex,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMem16(Int32 nMemIndex)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMem16(
                m_nController,
                nMemIndex);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMem16(Int32 nMemIndex, Int32 nValue)
        {
            m_nLastError = PS90_SetMem16(
                m_nController,
                nMemIndex,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMem32(Int32 nMemIndex)
        {
            Int32 nValue = 0;

            nValue = PS90_GetMem32(
                m_nController,
                nMemIndex);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMem32(Int32 nMemIndex, Int32 nValue)
        {
            m_nLastError = PS90_SetMem32(
                m_nController,
                nMemIndex,
                nValue);

            return m_nLastError;
        }
 
        // Extended functions
        public Int32 SetStageAttributes(Int32 nAxis, Double pitch, Int32 inc_rev, Double ratio)
        {
            m_nLastError = PS90_SetStageAttributes(
                m_nController,
                nAxis,
                pitch,
                inc_rev,
                ratio);

            return m_nLastError;
        }

        public Int32 SetCalcResol(Int32 nAxis, Double cresol)
        {
            m_nLastError = PS90_SetCalcResol(
                m_nController,
                nAxis,
                cresol);

            return m_nLastError;
        }

        public Int32 SetMsysResol(Int32 nAxis, Double mresol)
        {
            m_nLastError = PS90_SetMsysResol(
                m_nController,
                nAxis,
                mresol);

            return m_nLastError;
        }

        public Double GetPositionEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetPositionEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetPositionEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetPositionEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetTargetEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetTargetEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetTargetEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetTargetEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Int32 ChangeTargetEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_ChangeTargetEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetPIDTargetEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetPIDTargetEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetMsysPosEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetMsysPosEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetMsysPosEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetMsysPosEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetMsysTargetEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetMsysTargetEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetMsysTargetEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetMsysTargetEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetMsysPosRangeEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetMsysPosRangeEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetPosRangeEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetPosRangeEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetEncPosEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetEncPosEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetLimitMinEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetLimitMinEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetLimitMinEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetLimitMinEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetLimitMaxEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetLimitMaxEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetLimitMaxEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetLimitMaxEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Int32 MoveEx(Int32 nAxis, Double dValue, Boolean bNoInc)
        {
            m_nLastError = PS90_MoveEx(
                m_nController,
                nAxis,
                dValue,
                bNoInc ? 1 : 0);

            return m_nLastError;
        }

        public Double GetPosFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetPosFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetPosFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetPosFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetSlowRefFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetSlowRefFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetSlowRefFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetSlowRefFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFastRefFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetFastRefFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFastRefFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetFastRefFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFreeFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetFreeFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFreeFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetFreeFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetJoyFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetJoyFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetJoyFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetJoyFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetActFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetActFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetMsysFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetMsysFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetMsysFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetMsysFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetVectorFEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetVectorFEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetVectorFEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetVectorFEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetAccelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetAccelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetAccelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetAccelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetDecelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetDecelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetDecelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetDecelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetBrakeDecelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetBrakeDecelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetBrakeDecelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetBrakeDecelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetRefDecelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetRefDecelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetRefDecelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetRefDecelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetJoyAccelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetJoyAccelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetJoyAccelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetJoyAccelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetVectorAccelEx(Int32 nAxis)
        {
            Double dValue = 0.0;

            dValue = PS90_GetVectorAccelEx(
                m_nController,
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetVectorAccelEx(Int32 nAxis, Double dValue)
        {
            m_nLastError = PS90_SetVectorAccelEx(
                m_nController,
                nAxis,
                dValue);

            return m_nLastError;
        }

        public String GetDEC(Int32 nAxis)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS90_GetDEC(
                m_nController,
                nAxis,
                strBuffer,
                strBuffer.Capacity);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 SetDEC(Int32 nAxis, String strFile, String strSerNum, Int32 nMode, Double dLevel)
        {
            m_nLastError = PS90_SetDEC(
                m_nController,
                nAxis,
                strFile,
                strSerNum,
                nMode,
                dLevel);

            return m_nLastError;
        }

        // Communication
        public Int32 LogFile(Boolean bOpen, String strFile, Boolean bAppend, Int32 nMode)
        {
            m_nLastError = PS90_LogFile(
                m_nController, 
                bOpen?1:0, 
                strFile, 
                bAppend?1:0, 
                nMode);

            return m_nLastError;		
        }

        public String CmdAns(String strCmd, Boolean bRequest)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(100);
            Int32 nStrLen;

            nStrLen = PS90_CmdAns(
                m_nController,
                strCmd,
                strBuffer,
                strBuffer.Capacity,
                bRequest?1:0);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public String CmdAnsEx(String strCmd, Boolean bRequest, Int32 nBreak)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(100);
            Int32 nStrLen;

            nStrLen = PS90_CmdAnsEx(
                m_nController,
                strCmd,
                strBuffer,
                strBuffer.Capacity,
                bRequest?1:0,
                nBreak);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public String GetOWISidData(Int32 nAxis, Int32 nParamNum)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(150);
            Int32 nStrLen;

            nStrLen = PS90_GetOWISidData(
                m_nController,
                nAxis,
                nParamNum,
                strBuffer,
                strBuffer.Capacity);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 GetReadError()
        {
            return  PS90_GetReadError(m_nController);
        }
    }
}
