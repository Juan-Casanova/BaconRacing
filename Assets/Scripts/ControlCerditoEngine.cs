using System.Collections;
using System.Collections.Generic;


public class ControlCerditoEngine
{
    public float 
        torqueEngine,
        coefAceleration,
        wheelAngleMax,
        time;
    public int brake;
    public float buttonAxisVertical, buttonAxisHorizontal;

    public float backLeftBrake;
    public float backRightBrake;
    public float backLeftMotor;
    public float backRightMotor;

    public float frontLeftBrake;
    public float frontRightBrake;
    public float frontLeftMotor;
    public float frontRightMotor;

    public float frontLeftHorizontal;
    public float frontRightHorizontal;

    //(float backLeftBrake, float backRightBrake, float backLeftMotor, float backRightMotor,
    //    float frontLeftBrake, float frontRightBrake, float frontLeftMotor, float frontRightMotor)

    public void aceleration()
    {
        backLeftBrake  = 0;
        backRightBrake = 0;
        backLeftMotor  = buttonAxisVertical * torqueEngine * coefAceleration * time;
        backRightMotor = buttonAxisVertical * torqueEngine * coefAceleration * time;
        frontLeftBrake = 0;
        frontRightBrake = 0;
        frontLeftMotor= buttonAxisVertical * torqueEngine * coefAceleration * time;
        frontRightMotor= buttonAxisVertical * torqueEngine * coefAceleration * time;

    }

    public void reverse()
    {
        backLeftBrake = 0;
        backRightBrake = 0;
        backLeftMotor = buttonAxisVertical * torqueEngine * coefAceleration * time;
        backRightMotor = buttonAxisVertical * torqueEngine * coefAceleration * time;
        frontLeftBrake = 0;
        frontRightBrake = 0;
        frontLeftMotor = buttonAxisVertical * torqueEngine * coefAceleration * time;
        frontRightMotor = buttonAxisVertical * torqueEngine * coefAceleration * time;
    }

    public void deceleration()
    {
        backLeftBrake = 0;
        backRightBrake = 0;
        backLeftMotor = brake * coefAceleration * time;
        backRightMotor = brake * coefAceleration * time;
        frontLeftBrake = 0;
        frontRightBrake = 0;
        frontLeftMotor = brake * coefAceleration * time;
        frontRightMotor = brake * coefAceleration * time;
    }

    public void turn()
    {
        frontLeftHorizontal = buttonAxisHorizontal * wheelAngleMax;
        frontRightHorizontal = buttonAxisHorizontal * wheelAngleMax;

    }
    





}
