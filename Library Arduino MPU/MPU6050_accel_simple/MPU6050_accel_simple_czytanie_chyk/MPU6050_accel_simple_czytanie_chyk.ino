/*
    MPU6050 Triple Axis Gyroscope & Accelerometer. Simple Accelerometer Example.
    Read more: http://www.jarzebski.pl/arduino/czujniki-i-sensory/3-osiowy-zyroskop-i-akcelerometr-mpu6050.html
    GIT: https://github.com/jarzebski/Arduino-MPU6050
    Web: http://www.jarzebski.pl
    (c) 2014 by Korneliusz Jarzebski
*/

#include <Wire.h>
#include <MPU6050.h>

MPU6050 mpu;

void setup() 
{
  Serial.begin(9600);

 
  while(!mpu.begin(MPU6050_SCALE_2000DPS, MPU6050_RANGE_2G))
  {
    Serial.println("Could not find a valid MPU6050 sensor, check wiring!");
    delay(500);
  }

}


void loop()
{
  
  Vector normAccel = mpu.readNormalizeAccel();

 
  Serial.print(" XI = ");
  Serial.print(normAccel.XAxis);
  Serial.print(" YI = ");
  Serial.print(normAccel.YAxis);
  Serial.print(" ZI = ");
  Serial.println(normAccel.ZAxis);
  
  delay(500);
}


